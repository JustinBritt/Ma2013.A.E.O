namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;

    public interface IConstraints9ConstraintElementFactory
    {
        IConstraints9ConstraintElement Create(
            IpIndexElement pIndexElement,
            Ia a,
            ITHR THR,
            ITPx x);
    }
}