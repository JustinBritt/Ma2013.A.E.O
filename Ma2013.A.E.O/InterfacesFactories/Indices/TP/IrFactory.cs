﻿namespace Ma2013.A.E.O.InterfacesFactories.Indices.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.Comparers;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;

    public interface IrFactory
    {
        Ir Create(
            ILocationComparer locationComparer,
            ImmutableList<IrIndexElement> value);
    }
}