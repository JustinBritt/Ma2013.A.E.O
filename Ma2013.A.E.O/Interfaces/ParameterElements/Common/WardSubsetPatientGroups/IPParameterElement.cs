namespace Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IPParameterElement
    {
        IwIndexElement wIndexElement { get; }

        IpIndexElement pIndexElement { get; }
    }
}