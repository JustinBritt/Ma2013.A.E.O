namespace Ma2013.A.E.O.Classes.Parameters.TP.PatientGroupDayLengthOfStayProbabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;

    internal sealed class prob : Iprob
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public prob(
            RedBlackTree<IpIndexElement, RedBlackTree<IlIndexElement, IprobParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IpIndexElement, RedBlackTree<IlIndexElement, IprobParameterElement>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement,
            IlIndexElement lIndexElement)
        {
            return this.Value[pIndexElement][lIndexElement].Value.Value.Value;
        }
    }
}