namespace Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            RedBlackTree<IwIndexElement, IγParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IwIndexElement, IγParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement)
        {
            return this.Value[wIndexElement].Value.Value.Value;
        }
    }
}