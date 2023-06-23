namespace Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupNumberPatientBounds
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;

    internal sealed class LB : ILB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LB(
            RedBlackTree<IpIndexElement, ILBParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IpIndexElement, ILBParameterElement> Value { get; }

        public int GetElementAtAsint(
            IpIndexElement pIndexElement)
        {
            return this.Value[pIndexElement].Value.Value.Value;
        }
    }
}