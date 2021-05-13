namespace Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupNumberPatientBounds
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;

    internal sealed class LBParameterElement : ILBParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LBParameterElement(
            IpIndexElement pIndexElement,
            PositiveInt value)
        {
            this.pIndexElement = pIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public PositiveInt Value { get; }
    }
}