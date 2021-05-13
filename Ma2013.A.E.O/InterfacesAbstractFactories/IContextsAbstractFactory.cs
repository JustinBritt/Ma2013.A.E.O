namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Contexts.SP;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.TP;

    public interface IContextsAbstractFactory
    {
        ISPInputContextFactory CreateSPInputContextFactory();

        ISPOutputContextFactory CreateSPOutputContextFactory();

        ITPInputContextFactory CreateTPInputContextFactory();

        ITPOutputContextFactory CreateTPOutputContextFactory();
    }
}