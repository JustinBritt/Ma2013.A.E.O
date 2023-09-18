namespace Ma2013.A.E.O.Classes.Results.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPx : ITPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPx(
            ImmutableList<ITPxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITPxResultElement> Value { get; }

        public int GetElementAtAsint(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement && x.aIndexElement == aIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

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