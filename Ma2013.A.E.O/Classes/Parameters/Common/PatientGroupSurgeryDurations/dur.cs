namespace Ma2013.A.E.O.Classes.Parameters.Common.PatientGroupSurgeryDurations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;

    internal sealed class dur : Idur
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dur(
            ImmutableList<IdurParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IdurParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}