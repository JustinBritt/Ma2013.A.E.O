namespace Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;
    
    internal sealed class WardNumberAssignedOperatingRoomsResultElementCalculation : IWardNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public IWardNumberAssignedOperatingRoomsResultElement Calculate(
            IWardNumberAssignedOperatingRoomsResultElementFactory wardNumberAssignedOperatingRoomsResultElementFactory,
            IWParameterElement WParameterElement,
            ITPz z)
        {
            return wardNumberAssignedOperatingRoomsResultElementFactory.Create(
                WParameterElement.wIndexElement,
                WParameterElement.Value
                .SelectMany(a => z.Value.Where(i => i.sIndexElement == a && i.Value)
                .Select(w => w.rIndexElement))
                .Distinct()
                .Count());
        }
    }
}