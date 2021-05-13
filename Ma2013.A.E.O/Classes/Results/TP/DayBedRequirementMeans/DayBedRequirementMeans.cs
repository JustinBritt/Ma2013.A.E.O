namespace Ma2013.A.E.O.Classes.Results.TP.DayBedRequirementMeans
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class DayBedRequirementMeans : IDayBedRequirementMeans
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeans(
            ImmutableList<IDayBedRequirementMeansResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IDayBedRequirementMeansResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.dIndexElement == dIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.dIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}