namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Exports.SP;
    using Ma2013.A.E.O.InterfacesFactories.Exports.TP;

    public interface IExportsAbstractFactory
    {
        ISPExportFactory CreateSPExportFactory();

        ITPExportFactory CreateTPExportFactory();
    }
}