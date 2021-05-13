namespace Ma2013.A.E.O.Classes.Results.TP.WardNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class WardNumberAssignedOperatingRooms : IWardNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRooms(
            ImmutableList<IWardNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWardNumberAssignedOperatingRoomsResultElement> Value { get; }

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