namespace Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    
    internal sealed class SurgeonGroupNumberAssignedOperatingRoomsCalculation : ISurgeonGroupNumberAssignedOperatingRoomsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRoomsCalculation()
        {
        }

        public ISurgeonGroupNumberAssignedOperatingRooms Calculate(
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory surgeonGroupNumberAssignedOperatingRoomsResultElementFactory,
            ISurgeonGroupNumberAssignedOperatingRoomsFactory surgeonGroupNumberAssignedOperatingRoomsFactory,
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation surgeonGroupNumberAssignedOperatingRoomsResultElementCalculation,
            Is s,
            ITPz z)
        {
            return surgeonGroupNumberAssignedOperatingRoomsFactory.Create(
                s.Value.Values
                .Select(w => surgeonGroupNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                    surgeonGroupNumberAssignedOperatingRoomsResultElementFactory,
                    w,
                    z))
                .ToImmutableList());
        }
    }
}