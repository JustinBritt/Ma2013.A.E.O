namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;

    public interface IAParameterElementFactory
    {
        IAParameterElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            ImmutableList<IdIndexElement> value);
    }
}