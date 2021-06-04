namespace Ma2013.A.E.O.Factories.Parameters.Common.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgicalSpecialties;

    internal sealed class WFactory : IWFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WFactory()
        {
        }

        public IW Create(
            ImmutableList<IWParameterElement> value)
        {
            IW parameter = null;

            try
            {
                parameter = new W(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}