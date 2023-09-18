namespace Ma2013.A.E.O.Classes.Results.TP.WardDayBedAvailabilityDeviations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class δPlus : IδPlus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlus(
            ImmutableList<IδPlusResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IδPlusResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ma2013.A.E.O.Interfaces.Indices.Common.Id d,
            Iw w)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.wIndexElement.Value,
                    i.dIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}