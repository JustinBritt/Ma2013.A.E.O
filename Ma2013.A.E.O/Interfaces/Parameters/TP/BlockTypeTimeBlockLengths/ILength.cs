namespace Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;

    public interface ILength
    {
        ImmutableList<ILengthParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IkIndexElement kIndexElement);
    }
}