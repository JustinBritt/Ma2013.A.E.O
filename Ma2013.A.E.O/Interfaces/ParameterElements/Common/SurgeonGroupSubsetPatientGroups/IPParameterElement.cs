namespace Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IPParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IpIndexElement pIndexElement { get; }
    }
}