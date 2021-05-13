namespace Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupProfits
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            ImmutableList<IrParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IrParameterElement> Value { get; }

        public Money GetElementAt(
            IpIndexElement pIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}