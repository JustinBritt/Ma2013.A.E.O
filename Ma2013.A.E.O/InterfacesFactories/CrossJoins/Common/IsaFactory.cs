﻿namespace Ma2013.A.E.O.InterfacesFactories.CrossJoins.Common
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;

    public interface IsaFactory
    {
        Isa Create(
            ImmutableList<IsaCrossJoinElement> value);
    }
}