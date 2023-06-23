namespace Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupProfits
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            RedBlackTree<IpIndexElement, IrParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IpIndexElement, IrParameterElement> Value { get; }

        public Money GetElementAt(
            IpIndexElement pIndexElement)
        {
            return this.Value[pIndexElement].Value;
        }

        public decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement)
        {
            return this.Value[pIndexElement].Value.Value.Value;
        }
    }
}