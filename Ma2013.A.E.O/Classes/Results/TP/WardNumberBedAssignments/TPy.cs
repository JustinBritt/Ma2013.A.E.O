namespace Ma2013.A.E.O.Classes.Results.TP.WardNumberBedAssignments
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPy : ITPy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPy(
            ImmutableList<ITPyResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITPyResultElement> Value { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => KeyValuePair.Create(
                    i.wIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}