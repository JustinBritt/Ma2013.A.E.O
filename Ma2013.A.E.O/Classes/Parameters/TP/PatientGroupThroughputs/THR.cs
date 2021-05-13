namespace Ma2013.A.E.O.Classes.Parameters.TP.PatientGroupThroughputs
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;

    internal sealed class THR : ITHR
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public THR(
            ImmutableList<ITHRParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITHRParameterElement> Value { get; }

        public int GetElementAtAsint(
            IpIndexElement pIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}