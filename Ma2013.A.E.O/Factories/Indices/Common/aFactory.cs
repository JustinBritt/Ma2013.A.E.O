namespace Ma2013.A.E.O.Factories.Indices.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Indices.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.Indices.Common;
    
    internal sealed class aFactory : IaFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public aFactory()
        {
        }

        public Ia Create(
            RedBlackTree<FhirDateTime, IaIndexElement> value)
        {
            Ia index = null;

            try
            {
                index = new a(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}