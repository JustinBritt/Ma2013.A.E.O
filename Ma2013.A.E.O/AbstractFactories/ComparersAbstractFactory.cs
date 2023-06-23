namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Comparers;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Comparers;

    internal sealed class ComparersAbstractFactory : IComparersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ComparersAbstractFactory()
        {
        }

        public IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory()
        {
            IFhirDateTimeComparerFactory factory = null;

            try
            {
                factory = new FhirDateTimeComparerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOrganizationComparerFactory CreateOrganizationComparerFactory()
        {
            IOrganizationComparerFactory factory = null;

            try
            {
                factory = new OrganizationComparerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}