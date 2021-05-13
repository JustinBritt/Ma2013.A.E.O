namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.BlockTypeTimeBlockLengths
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;

    public interface ILengthFactory
    {
        ILength Create(
            ImmutableList<ILengthParameterElement> value);
    }
}