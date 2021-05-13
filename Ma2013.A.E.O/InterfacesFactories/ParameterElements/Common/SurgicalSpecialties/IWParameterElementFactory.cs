namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;

    public interface IWParameterElementFactory
    {
        IWParameterElement Create(
            IwIndexElement wIndexElement,
            ImmutableList<IsIndexElement> value);
    }
}