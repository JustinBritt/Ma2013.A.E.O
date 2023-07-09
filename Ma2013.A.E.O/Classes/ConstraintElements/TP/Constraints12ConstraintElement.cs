namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances;

    internal sealed class Constraints12ConstraintElement : IConstraints12ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints12ConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Id d,
            Il l,
            Iprob prob,
            Iwpa wpa,
            ITPx x,
            IVariance Variance)
        {
            Expression LHS = Variance.Value[wIndexElement, dIndexElement];

            RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, double>> outerRedBlackTree = new RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, double>>();

            foreach (IpIndexElement pIndexElement in wpa.Value[wIndexElement].Keys)
            {
                RedBlackTree<IaIndexElement, double> innerRedBlackTree = new RedBlackTree<IaIndexElement, double>();

                foreach (IaIndexElement aIndexElement in wpa.Value[wIndexElement][pIndexElement].Keys)
                {
                    int dLowerBound = aIndexElement.Key <= dIndexElement.Key ? dIndexElement.Key - aIndexElement.Key : d.GetMaximumKey() + dIndexElement.Key - aIndexElement.Key;

                    double RHSSum = 0;

                    for (int w = dLowerBound;
                        w <= l.GetMaximumLengthOfStay();
                        w = w + 1)
                    {
                        RHSSum +=
                            (double)prob.GetElementAtAsdecimal(
                                pIndexElement,
                                l.GetElementAt(
                                    w))
                            *
                            (double)(1 - prob.GetElementAtAsdecimal(
                                pIndexElement,
                                l.GetElementAt(
                                    w)));
                    }

                    innerRedBlackTree.Add(
                        aIndexElement,
                        RHSSum);
                }

                outerRedBlackTree.Add(
                    pIndexElement,
                    innerRedBlackTree);
            }

            Expression RHS = Expression.Sum(
                wpa.Value[wIndexElement].Values.SelectMany(w => w.Values)
                .Select(
                    y =>
                    outerRedBlackTree[y.pIndexElement][y.aIndexElement]
                    *
                    x.Value[
                        y.pIndexElement,
                        y.aIndexElement]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}