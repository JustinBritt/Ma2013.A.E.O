namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;

    public interface IαFactory
    {
        Iα Create(
            ImmutableList<IαParameterElement> value);
    }
}