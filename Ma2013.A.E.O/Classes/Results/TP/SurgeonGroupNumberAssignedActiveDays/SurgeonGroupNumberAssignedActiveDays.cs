namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonGroupNumberAssignedActiveDays : ISurgeonGroupNumberAssignedActiveDays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDays(
            ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> Value { get; }

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