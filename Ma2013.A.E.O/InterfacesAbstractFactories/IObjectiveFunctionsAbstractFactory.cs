namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.TP;

    public interface IObjectiveFunctionsAbstractFactory
    {
        ISPObjectiveFunctionFactory CreateSPObjectiveFunctionFactory();

        ITPObjectiveFunctionFactory CreateTPObjectiveFunctionFactory();
    }
}