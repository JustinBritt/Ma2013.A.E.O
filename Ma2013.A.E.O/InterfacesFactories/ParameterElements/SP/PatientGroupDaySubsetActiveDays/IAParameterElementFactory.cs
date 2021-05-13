namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;

    public interface IAParameterElementFactory
    {
        IAParameterElement Create(
            IpIndexElement pIndexElement,
            IdIndexElement dIndexElement,
            IaIndexElement aIndexElement);
    }
}