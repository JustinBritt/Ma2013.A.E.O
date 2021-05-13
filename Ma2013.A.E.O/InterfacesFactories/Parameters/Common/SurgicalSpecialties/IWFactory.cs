namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;

    public interface IWFactory
    {
        IW Create(
            ImmutableList<IWParameterElement> value);
    }
}