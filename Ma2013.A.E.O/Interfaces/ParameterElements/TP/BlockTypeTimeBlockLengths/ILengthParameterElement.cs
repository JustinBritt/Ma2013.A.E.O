namespace Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface ILengthParameterElement
    {
        IkIndexElement kIndexElement { get; }

        Duration Value { get; }
    }
}