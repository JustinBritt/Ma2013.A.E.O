namespace Ma2013.A.E.O.Classes.Parameters.Common.PatientGroupSurgeryDurations
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;

    internal sealed class dur : Idur
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dur(
            RedBlackTree<IpIndexElement, IdurParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IpIndexElement, IdurParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement)
        {
            return this.Value[pIndexElement].Value.Value.Value;
        }
    }
}