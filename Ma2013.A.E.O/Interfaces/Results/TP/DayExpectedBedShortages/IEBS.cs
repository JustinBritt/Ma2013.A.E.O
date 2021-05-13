namespace Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IEBS
    {
        ImmutableList<IEBSResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IdIndexElement dIndexElement);

        ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}