namespace Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedActiveDays
{
    using System.Collections.Immutable;
    using System.Linq;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedActiveDays;

    internal sealed class WardNumberAssignedActiveDaysCalculation : IWardNumberAssignedActiveDaysCalculation
    {
        public WardNumberAssignedActiveDaysCalculation()
        {
        }

        public IWardNumberAssignedActiveDays Calculate(
            IWardNumberAssignedActiveDaysResultElementFactory wardNumberAssignedActiveDaysResultElementFactory,
            IWardNumberAssignedActiveDaysFactory wardNumberAssignedActiveDaysFactory,
            IWardNumberAssignedActiveDaysResultElementCalculation wardNumberAssignedActiveDaysResultElementCalculation,
            IW W,
            ITPz z)
        {
            return wardNumberAssignedActiveDaysFactory.Create(
                W.Value
                .Select(i => wardNumberAssignedActiveDaysResultElementCalculation.Calculate(
                    wardNumberAssignedActiveDaysResultElementFactory,
                    i,
                    z))
                .ToImmutableList());
        }
    }
}