namespace Ma2013.A.E.O.Interfaces.Results.TP.WardBedOccupancyVariances
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IVariance
    {
        ImmutableList<IVarianceResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement);

        ImmutableList<Tuple<Organization, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}