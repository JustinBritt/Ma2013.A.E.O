namespace Ma2013.A.E.O.Classes.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SPz : ISPz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPz(
            ImmutableList<ISPzResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISPzResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.aIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}