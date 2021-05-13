namespace Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedActiveDays
{
    using System;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;

    internal sealed class WardNumberAssignedActiveDaysResultElementCalculation : IWardNumberAssignedActiveDaysResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedActiveDaysResultElementCalculation()
        {
        }

        public IWardNumberAssignedActiveDaysResultElement Calculate(
            IWardNumberAssignedActiveDaysResultElementFactory wardNumberAssignedActiveDaysResultElementFactory,
            IWParameterElement WParameterElement,
            ITPz z)
        {
            return wardNumberAssignedActiveDaysResultElementFactory.Create(
                WParameterElement.wIndexElement,
                WParameterElement.Value
                .SelectMany(a => z.Value.Where(i => i.sIndexElement == a && i.Value)
                .Select(i => i.aIndexElement.Value.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.DayOfWeek))
                .Distinct()
                .Count());
        }
    }
}