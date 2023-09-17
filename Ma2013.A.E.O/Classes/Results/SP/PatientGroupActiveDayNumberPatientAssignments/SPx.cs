namespace Ma2013.A.E.O.Classes.Results.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SPx : ISPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPx(
            ImmutableList<ISPxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISPxResultElement> Value { get; }

        public ImmutableList<Tuple<INullableValue<int>, FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Ip p)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    (INullableValue<int>)i.pIndexElement.Value,
                    i.aIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}