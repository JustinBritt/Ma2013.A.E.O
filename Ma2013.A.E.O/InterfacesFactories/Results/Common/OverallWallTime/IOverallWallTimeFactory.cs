namespace Ma2013.A.E.O.InterfacesFactories.Results.Common.OverallWallTime
{
    using System;

    using Ma2013.A.E.O.Interfaces.Results.Common.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}