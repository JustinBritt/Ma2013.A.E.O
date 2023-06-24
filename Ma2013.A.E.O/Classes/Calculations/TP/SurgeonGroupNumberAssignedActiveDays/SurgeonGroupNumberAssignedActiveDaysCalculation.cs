namespace Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysCalculation : ISurgeonGroupNumberAssignedActiveDaysCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysCalculation()
        {
        }

        public ISurgeonGroupNumberAssignedActiveDays Calculate(
            ISurgeonGroupNumberAssignedActiveDaysResultElementFactory surgeonGroupNumberAssignedActiveDaysResultElementFactory,
            ISurgeonGroupNumberAssignedActiveDaysFactory surgeonGroupNumberAssignedActiveDaysFactory,
            ISurgeonGroupNumberAssignedActiveDaysResultElementCalculation surgeonGroupNumberAssignedActiveDaysResultElementCalculation,
            Is s,
            ITPz z)
        {
            return surgeonGroupNumberAssignedActiveDaysFactory.Create(
                s.Value.Values
                .Select(w => surgeonGroupNumberAssignedActiveDaysResultElementCalculation.Calculate(
                    surgeonGroupNumberAssignedActiveDaysResultElementFactory,
                    w,
                    z))
                .ToImmutableList());
        }
    }
}