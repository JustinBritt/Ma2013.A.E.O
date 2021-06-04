namespace Ma2013.A.E.O.Factories.Exports.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Exports.TP;
    using Ma2013.A.E.O.Interfaces.Exports.TP;
    using Ma2013.A.E.O.InterfacesFactories.Exports.TP;

    internal sealed class TPExportFactory : ITPExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPExportFactory()
        {
        }

        public ITPExport Create()
        {
            ITPExport export = null;

            try
            {
                export = new TPExport();
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