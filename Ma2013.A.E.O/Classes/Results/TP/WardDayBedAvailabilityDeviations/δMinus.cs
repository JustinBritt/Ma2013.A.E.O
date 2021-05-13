﻿namespace Ma2013.A.E.O.Classes.Results.TP.WardDayBedAvailabilityDeviations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class δMinus : IδMinus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δMinus(
            ImmutableList<IδMinusResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IδMinusResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.wIndexElement == wIndexElement && x.dIndexElement == dIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
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