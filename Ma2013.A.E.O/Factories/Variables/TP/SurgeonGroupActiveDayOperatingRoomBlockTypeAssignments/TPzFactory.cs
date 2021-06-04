namespace Ma2013.A.E.O.Factories.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    internal sealed class TPzFactory : ITPzFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPzFactory()
        {
        }

        public ITPz Create(
            VariableCollection<IsIndexElement, IaIndexElement, IrIndexElement, IkIndexElement> value)
        {
            ITPz variable = null;

            try
            {
                variable = new TPz(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}