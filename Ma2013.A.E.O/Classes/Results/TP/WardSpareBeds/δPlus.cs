namespace Ma2013.A.E.O.Classes.Results.TP.WardSpareBeds
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardSpareBeds;
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

        public decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement)
        {
            return this.Value
                .Where(x => x.wIndexElement == wIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<Organization, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.wIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}