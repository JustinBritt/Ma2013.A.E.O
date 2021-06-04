namespace Ma2013.A.E.O.Factories.Exports.SP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Exports.SP;
    using Ma2013.A.E.O.Interfaces.Exports.SP;
    using Ma2013.A.E.O.InterfacesFactories.Exports.SP;

    internal sealed class SPExportFactory : ISPExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPExportFactory()
        {
        }

        public ISPExport Create()
        {
            ISPExport export = null;

            try
            {
                export = new SPExport();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}