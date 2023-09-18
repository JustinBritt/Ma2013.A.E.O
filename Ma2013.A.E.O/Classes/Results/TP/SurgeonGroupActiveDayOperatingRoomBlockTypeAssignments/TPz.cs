namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPz : ITPz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPz(
            ImmutableList<ITPzResultElement> value)
        {
            this.Value = value;
        }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.aIndexElement == aIndexElement && x.rIndexElement == rIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value ? 1 : 0)
                .SingleOrDefault();
        }

        public ImmutableList<ITPzResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, Location, INullableValue<int>, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Ir r,
            Is s)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.aIndexElement.Value,
                    i.rIndexElement.Value,
                    (INullableValue<int>)i.kIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}