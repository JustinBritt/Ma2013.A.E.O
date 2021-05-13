namespace Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;

    public interface IA
    {
        ImmutableList<IAParameterElement> Value { get; }

        bool IsThereElementAt(
            IpIndexElement pIndexElement,
            IdIndexElement dIndexElement,
            IaIndexElement aIndexElement);
    }
}