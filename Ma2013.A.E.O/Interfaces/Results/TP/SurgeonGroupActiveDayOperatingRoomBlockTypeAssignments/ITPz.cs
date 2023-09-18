namespace Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ITPz
    {
        ImmutableList<ITPzResultElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement);

        ImmutableList<Tuple<Organization, FhirDateTime, Location, INullableValue<int>, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Is s);
    }
}