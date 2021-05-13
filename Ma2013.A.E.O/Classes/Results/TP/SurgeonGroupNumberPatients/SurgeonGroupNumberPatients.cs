namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonGroupNumberPatients : ISurgeonGroupNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatients(
            ImmutableList<ISurgeonGroupNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonGroupNumberPatientsResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}