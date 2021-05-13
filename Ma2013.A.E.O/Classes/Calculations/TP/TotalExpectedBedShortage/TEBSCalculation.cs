namespace Ma2013.A.E.O.Classes.Calculations.TP.TotalExpectedBedShortage
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalExpectedBedShortage;

    internal sealed class TEBSCalculation : ITEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculation()
        {
        }

        public ITEBS Calculate(
            ITEBSFactory TEBSFactory,
            Id d,
            IEBS EBS)
        {
            return TEBSFactory.Create(
                d.Value
                .Select(y => EBS.GetElementAtAsdecimal(
                    y))
                .ToImmutableList()
                .Sum());
        }
    }
}