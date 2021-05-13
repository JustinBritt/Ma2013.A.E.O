namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Solutions.SP;
    using Ma2013.A.E.O.InterfacesFactories.Solutions.TP;

    public interface ISolutionsAbstractFactory
    {
        ISPSolutionFactory CreateSPSolutionFactory();

        ITPSolutionFactory CreateTPSolutionFactory();
    }
}