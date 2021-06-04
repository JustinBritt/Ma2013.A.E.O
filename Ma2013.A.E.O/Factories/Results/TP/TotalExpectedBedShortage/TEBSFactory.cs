namespace Ma2013.A.E.O.Factories.Results.TP.TotalExpectedBedShortage
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalExpectedBedShortage;

    internal sealed class TEBSFactory : ITEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSFactory()
        {
        }

        public ITEBS Create(
            decimal value)
        {
            ITEBS result = null;

            try
            {
                result = new TEBS(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}