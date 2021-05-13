namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonGroupNumberAssignedOperatingRooms : ISurgeonGroupNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRooms(
            ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> Value { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => KeyValuePair.Create(
                    i.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}