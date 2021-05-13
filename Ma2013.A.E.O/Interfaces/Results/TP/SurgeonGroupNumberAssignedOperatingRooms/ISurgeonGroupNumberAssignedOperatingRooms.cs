namespace Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonGroupNumberAssignedOperatingRooms
    {
        ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> Value { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}