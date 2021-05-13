namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.Factories.ObjectiveFunctions.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.TP;

    internal sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public ISPObjectiveFunctionFactory CreateSPObjectiveFunctionFactory()
        {
            ISPObjectiveFunctionFactory factory = null;

            try
            {
                factory = new SPObjectiveFunctionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITPObjectiveFunctionFactory CreateTPObjectiveFunctionFactory()
        {
            ITPObjectiveFunctionFactory factory = null;

            try
            {
                factory = new TPObjectiveFunctionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}