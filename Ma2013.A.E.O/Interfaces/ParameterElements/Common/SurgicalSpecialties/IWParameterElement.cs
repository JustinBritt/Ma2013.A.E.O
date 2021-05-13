namespace Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IWParameterElement
    {
        IwIndexElement wIndexElement { get; }

        ImmutableList<IsIndexElement> Value { get; }
    }
}