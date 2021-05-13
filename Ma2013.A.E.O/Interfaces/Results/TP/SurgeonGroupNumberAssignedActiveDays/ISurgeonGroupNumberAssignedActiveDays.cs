namespace Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonGroupNumberAssignedActiveDays
    {
        ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}