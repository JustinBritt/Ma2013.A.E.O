namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupProfits
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;

    public interface IrFactory
    {
        Ir Create(
            ImmutableList<IrParameterElement> value);
    }
}