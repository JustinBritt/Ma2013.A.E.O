namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;

    public interface IConstraints6UConstraintElementFactory
    {
        IConstraints6UConstraintElement Create(
            IpIndexElement pIndexElement,
            Ia a,
            IUB UB,
            ISPx x);
    }
}