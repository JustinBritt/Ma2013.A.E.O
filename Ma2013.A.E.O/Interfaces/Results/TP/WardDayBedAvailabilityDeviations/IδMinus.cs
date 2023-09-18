namespace Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedAvailabilityDeviations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IδMinus
    {
        ImmutableList<IδMinusResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement);

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ma2013.A.E.O.Interfaces.Indices.Common.Id d,
            Iw w);
    }
}