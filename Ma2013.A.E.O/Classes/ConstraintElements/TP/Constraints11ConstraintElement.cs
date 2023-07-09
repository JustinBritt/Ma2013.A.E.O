namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;

    internal sealed class Constraints11ConstraintElement : IConstraints11ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints11ConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Id d,
            Il l,
            Ipa pa,
            IP P,
            Iprob prob,
            Iwpa wpa,
            ITPx x,
            Iμ μ)
        {
            Expression LHS = μ.Value[wIndexElement, dIndexElement];

            ImmutableList<Tuple<IpIndexElement, IaIndexElement, double>>.Builder builder = ImmutableList.CreateBuilder<Tuple<IpIndexElement, IaIndexElement, double>>();

            foreach (IpIndexElement pIndexElement in wpa.Value[wIndexElement].Keys)
            {
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
                                    w));
                    }

                    builder.Add(
                        Tuple.Create(
                            pIndexElement,
                            aIndexElement,
                            RHSSum));
                }
            }

            ImmutableList<Tuple<IpIndexElement, IaIndexElement, double>> RHSSums = builder.ToImmutableList();

            Expression RHS = Expression.Sum(
                wpa.Value[wIndexElement].Values.SelectMany(w => w.Values)
                .Select(
                    y =>
                    RHSSums.Where(w => w.Item1 == y.pIndexElement && w.Item2 == y.aIndexElement).Select(w => w.Item3).SingleOrDefault()
                    *
                    x.Value[
                        y.pIndexElement,
                        y.aIndexElement]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}