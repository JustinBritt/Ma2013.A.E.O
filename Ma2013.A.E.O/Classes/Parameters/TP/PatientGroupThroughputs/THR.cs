namespace Ma2013.A.E.O.Classes.Parameters.TP.PatientGroupThroughputs
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;

    internal sealed class THR : ITHR
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public THR(
            RedBlackTree<IpIndexElement, ITHRParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IpIndexElement, ITHRParameterElement> Value { get; }

        public int GetElementAtAsint(
            IpIndexElement pIndexElement)
        {
            return this.Value[pIndexElement].Value.Value.Value;
        }
    }
}