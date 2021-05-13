namespace Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonGroupNumberPatients
    {
        ImmutableList<ISurgeonGroupNumberPatientsResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}