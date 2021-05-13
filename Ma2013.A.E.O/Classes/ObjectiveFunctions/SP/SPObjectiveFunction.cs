namespace Ma2013.A.E.O.Classes.ObjectiveFunctions.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class SPObjectiveFunction : ISPObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            Ipa pa,
            Ir r,
            ISPx x)
        {
            Expression expression = Expression.Sum(
                pa.Value
                .Select(
                    i =>
                    (double)r.GetElementAtAsdecimal(
                        i.pIndexElement)
                    *
                    x.Value[i.pIndexElement, i.aIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Maximize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}