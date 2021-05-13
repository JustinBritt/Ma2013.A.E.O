namespace Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedOperatingRooms;

    internal sealed class WardNumberAssignedOperatingRoomsCalculation : IWardNumberAssignedOperatingRoomsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRoomsCalculation()
        {
        }

        public IWardNumberAssignedOperatingRooms Calculate(
            IWardNumberAssignedOperatingRoomsResultElementFactory wardNumberAssignedOperatingRoomsResultElementFactory,
            IWardNumberAssignedOperatingRoomsFactory wardNumberAssignedOperatingRoomsFactory,
            IWardNumberAssignedOperatingRoomsResultElementCalculation wardNumberAssignedOperatingRoomsResultElementCalculation,
            IW W,
            ITPz z)
        {
            return wardNumberAssignedOperatingRoomsFactory.Create(
                W.Value
                .Select(i => wardNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                    wardNumberAssignedOperatingRoomsResultElementFactory,
                    i,
                    z))
                .ToImmutableList());
        }
    }
}