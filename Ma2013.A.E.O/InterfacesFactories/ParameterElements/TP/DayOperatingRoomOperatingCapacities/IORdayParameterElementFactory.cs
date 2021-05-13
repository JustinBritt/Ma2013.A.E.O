namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.DayOperatingRoomOperatingCapacities
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;

    public interface IORdayParameterElementFactory
    {
        IORdayParameterElement Create(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            Duration value);
    }
}