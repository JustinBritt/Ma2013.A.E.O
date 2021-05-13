namespace Ma2013.A.E.O.Classes.Parameters.TP.PatientGroupDayLengthOfStayProbabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;

    internal sealed class prob : Iprob
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public prob(
            ImmutableList<IprobParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IprobParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement,
            IlIndexElement lIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement && x.lIndexElement == lIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}