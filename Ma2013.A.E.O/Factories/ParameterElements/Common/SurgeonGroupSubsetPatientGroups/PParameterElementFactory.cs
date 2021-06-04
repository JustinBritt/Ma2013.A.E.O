﻿namespace Ma2013.A.E.O.Factories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;

    internal sealed class PParameterElementFactory : IPParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PParameterElementFactory()
        {
        }

        public IPParameterElement Create(
            IsIndexElement sIndexElement,
            IpIndexElement pIndexElement)
        {
            IPParameterElement parameterElement = null;

            try
            {
                parameterElement = new PParameterElement(
                    sIndexElement,
                    pIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}