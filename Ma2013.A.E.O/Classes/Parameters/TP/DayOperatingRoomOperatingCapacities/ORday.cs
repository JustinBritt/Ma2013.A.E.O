namespace Ma2013.A.E.O.Classes.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;

    internal sealed class ORday : IORday
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ORday(
            RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value[aIndexElement][rIndexElement].Value.Value.Value;
        }
    }
}