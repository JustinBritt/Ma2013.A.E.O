namespace Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;

    internal sealed class SurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation : ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory surgeonGroupNumberAssignedOperatingRoomsResultElementFactory,
            IsIndexElement sIndexElement,
            ITPz z)
        {
            return surgeonGroupNumberAssignedOperatingRoomsResultElementFactory.Create(
                sIndexElement,
                z.Value
                .Where(w => w.sIndexElement == sIndexElement && w.Value)
                .Select(w => w.rIndexElement)
                .Distinct()
                .Count());
        }
    }
}