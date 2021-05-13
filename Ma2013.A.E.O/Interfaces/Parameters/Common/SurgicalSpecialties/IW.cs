namespace Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;

    public interface IW
    {
        ImmutableList<IWParameterElement> Value { get; }

        IwIndexElement GetSurgicalSpecialtyOfSurgeon(
            IsIndexElement sIndexElement);

        bool IsSurgeonMemberOfSurgicalSpecialty(
            IwIndexElement wIndexElement,
            IsIndexElement sIndexElement);
    }
}