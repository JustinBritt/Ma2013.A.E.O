namespace Ma2013.A.E.O.Classes.Results.TP.WardNumberAssignedActiveDays
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class WardNumberAssignedActiveDays : IWardNumberAssignedActiveDays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedActiveDays(
            ImmutableList<IWardNumberAssignedActiveDaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWardNumberAssignedActiveDaysResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.wIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}