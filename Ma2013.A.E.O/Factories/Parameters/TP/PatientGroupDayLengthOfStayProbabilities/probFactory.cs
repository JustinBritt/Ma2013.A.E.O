namespace Ma2013.A.E.O.Factories.Parameters.TP.PatientGroupDayLengthOfStayProbabilities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;

    internal sealed class probFactory : IprobFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public probFactory()
        {
        }

        public Iprob Create(
            ImmutableList<IprobParameterElement> value)
        {
            Iprob parameter = null;

            try
            {
                parameter = new prob(
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