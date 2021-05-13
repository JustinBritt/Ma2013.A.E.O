namespace Ma2013.A.E.O.Interfaces.Results.TP.WardSpareBeds
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IδPlus
    {
        ImmutableList<IδPlusResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement);

        ImmutableList<Tuple<Organization, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}