namespace Ma2013.A.E.O.Classes.Parameters.SP.TimeBlockLength
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;

    internal sealed class LENGTH : ILENGTH
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LENGTH(
            Duration value)
        {
            this.Value = value;
        }

        public Duration Value { get; }
    }
}