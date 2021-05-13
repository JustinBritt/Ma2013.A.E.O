namespace Ma2013.A.E.O.Interfaces.Exports.SP
{
    using System.Threading.Tasks;
    
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Configurations.SP;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.SolverConfigurations;

    public interface ISPExport
    {
        Task<ISPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            ISPConfiguration SPConfiguration,
            ISPInputContext SPInputContext,
            ISolverConfiguration solverConfiguration);
    }
}