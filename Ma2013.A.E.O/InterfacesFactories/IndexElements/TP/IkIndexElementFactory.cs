﻿namespace Ma2013.A.E.O.InterfacesFactories.IndexElements.TP
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IkIndexElementFactory
    {
        IkIndexElement Create(
            INullableValue<int> value);
    }
}