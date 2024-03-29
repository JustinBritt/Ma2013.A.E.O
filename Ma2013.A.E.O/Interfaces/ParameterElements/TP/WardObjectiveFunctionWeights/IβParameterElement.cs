﻿namespace Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IβParameterElement
    {
        IwIndexElement wIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}