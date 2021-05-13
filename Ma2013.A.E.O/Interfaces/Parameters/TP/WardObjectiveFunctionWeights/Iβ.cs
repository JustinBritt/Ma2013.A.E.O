namespace Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;

    public interface Iβ
    {
        ImmutableList<IβParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement);
    }
}