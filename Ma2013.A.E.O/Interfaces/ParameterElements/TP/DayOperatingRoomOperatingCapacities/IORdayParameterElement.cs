namespace Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IORdayParameterElement
    {
        IaIndexElement aIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        Duration Value { get; }
    }
}