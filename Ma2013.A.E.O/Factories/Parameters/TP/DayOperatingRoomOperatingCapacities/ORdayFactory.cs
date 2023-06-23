namespace Ma2013.A.E.O.Factories.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.DayOperatingRoomOperatingCapacities;

    internal sealed class ORdayFactory : IORdayFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ORdayFactory()
        {
        }

        public IORday Create(
            RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>> value)
        {
            IORday parameter = null;

            try
            {
                parameter = new ORday(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}