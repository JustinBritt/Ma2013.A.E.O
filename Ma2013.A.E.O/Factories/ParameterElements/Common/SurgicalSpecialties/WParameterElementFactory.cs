namespace Ma2013.A.E.O.Factories.ParameterElements.Common.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;
 
    using log4net;

    using Ma2013.A.E.O.Classes.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgicalSpecialties;

    internal sealed class WParameterElementFactory : IWParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WParameterElementFactory()
        {
        }

        public IWParameterElement Create(
            IwIndexElement wIndexElement,
            ImmutableList<IsIndexElement> value)
        {
            IWParameterElement parameterElement = null;

            try
            {
                parameterElement = new WParameterElement(
                    wIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}