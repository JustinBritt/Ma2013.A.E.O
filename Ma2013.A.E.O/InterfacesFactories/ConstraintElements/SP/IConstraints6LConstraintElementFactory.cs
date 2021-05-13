namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;

    public interface IConstraints6LConstraintElementFactory
    {
        IConstraints6LConstraintElement Create(
            IpIndexElement pIndexElement,
            Ia a,
            ILB LB,
            ISPx x);
    }
}