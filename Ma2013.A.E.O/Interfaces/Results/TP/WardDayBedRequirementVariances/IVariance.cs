namespace Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IVariance
    {
        ImmutableList<IVarianceResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement);

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}