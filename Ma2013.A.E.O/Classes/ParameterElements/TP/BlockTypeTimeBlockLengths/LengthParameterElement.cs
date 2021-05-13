namespace Ma2013.A.E.O.Classes.ParameterElements.TP.BlockTypeTimeBlockLengths
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;

    internal sealed class LengthParameterElement : ILengthParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LengthParameterElement(
            IkIndexElement kIndexElement,
            Duration value)
        {
            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IkIndexElement kIndexElement { get; }

        public Duration Value { get; }
    }
}