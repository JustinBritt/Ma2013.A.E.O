namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupNumberPatientBounds
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;

    public interface ILBFactory
    {
        ILB Create(
            ImmutableList<ILBParameterElement> value);
    }
}