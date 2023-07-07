﻿namespace Ma2013.A.E.O.Factories.ParameterElements.Common.WardSubsetPatientGroups
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups;

    internal sealed class PParameterElementFactory : IPParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PParameterElementFactory()
        {
        }

        public IPParameterElement Create(
            IwIndexElement wIndexElement,
            ImmutableSortedSet<IpIndexElement> value)
        {
            IPParameterElement parameterElement = null;

            try
            {
                parameterElement = new PParameterElement(
                    wIndexElement,
                    value);
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