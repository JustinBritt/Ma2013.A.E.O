namespace Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupProfits
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;

    internal sealed class rParameterElement : IrParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rParameterElement(
            IpIndexElement pIndexElement,
            Money value)
        {
            this.pIndexElement = pIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public Money Value { get; }
    }
}