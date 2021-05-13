namespace Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.SP
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface ISPObjectiveFunctionFactory
    {
        ISPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Ipa pa,
            Ir r,
            ISPx x);
    }
}