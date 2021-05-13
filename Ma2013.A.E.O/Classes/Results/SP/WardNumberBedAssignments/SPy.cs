namespace Ma2013.A.E.O.Classes.Results.SP.WardNumberBedAssignments
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SPy : ISPy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPy(
            ImmutableList<ISPyResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISPyResultElement> Value { get; }

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