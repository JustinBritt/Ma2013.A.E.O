namespace Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IAParameterElement
    {
        IpIndexElement pIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        IaIndexElement aIndexElement { get; }
    }
}