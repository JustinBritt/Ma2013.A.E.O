namespace Ma2013.A.E.O.Factories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class SPzFactory : ISPzFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPzFactory()
        {
        }

        public ISPz Create(
            ImmutableList<ISPzResultElement> value)
        {
            ISPz result = null;

            try
            {
                result = new SPz(
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