namespace Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysResultElementCalculation : ISurgeonGroupNumberAssignedActiveDaysResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysResultElementCalculation()
        {
        }

        public ISurgeonGroupNumberAssignedActiveDaysResultElement Calculate(
            ISurgeonGroupNumberAssignedActiveDaysResultElementFactory surgeonGroupNumberAssignedActiveDaysResultElementFactory,
            IsIndexElement sIndexElement,
            ITPz z)
        {
            return surgeonGroupNumberAssignedActiveDaysResultElementFactory.Create(
                sIndexElement,
                z.Value
                .Where(i => i.sIndexElement == sIndexElement && i.Value)
                .Select(i => i.aIndexElement.Value.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.DayOfWeek)
                .Distinct()
                .Count());
        }
    }
}