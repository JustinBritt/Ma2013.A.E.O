namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;

    public interface IPParameterElementFactory
    {
        IPParameterElement Create(
            IsIndexElement sIndexElement,
            IpIndexElement pIndexElement);
    }
}