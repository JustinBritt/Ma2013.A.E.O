namespace Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;

    public interface IP
    {
        ImmutableList<IPParameterElement> Value { get; }

        bool IsThereElementAt(
            IwIndexElement wIndexElement,
            IpIndexElement pIndexElement);
    }
}