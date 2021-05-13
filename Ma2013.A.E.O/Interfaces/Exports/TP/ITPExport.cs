namespace Ma2013.A.E.O.Interfaces.Exports.TP
{
    using System.Threading.Tasks;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Configurations.TP;
    using Ma2013.A.E.O.Interfaces.Contexts.TP;
    using Ma2013.A.E.O.Interfaces.SolverConfigurations;

    public interface ITPExport
    {
        Task<ITPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            ITPConfiguration TPConfiguration,
            ITPInputContext TPInputContext,
            ISolverConfiguration solverConfiguration);
    }
}