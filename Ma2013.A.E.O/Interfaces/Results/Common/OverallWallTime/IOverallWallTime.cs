namespace Ma2013.A.E.O.Interfaces.Results.Common.OverallWallTime
{
    using System;

    public interface IOverallWallTime
    {
        TimeSpan Value { get; }

        TimeSpan GetValueForOutputContext();
    }
}