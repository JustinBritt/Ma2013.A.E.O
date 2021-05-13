namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Models.SP;
    using Ma2013.A.E.O.InterfacesFactories.Models.TP;

    public interface IModelsAbstractFactory
    {
        ISPModelFactory CreateSPModelFactory();

        ITPModelFactory CreateTPModelFactory();
    }
}