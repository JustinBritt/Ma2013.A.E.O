namespace Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupNumberPatientBounds
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;

    internal sealed class LB : ILB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LB(
            ImmutableList<ILBParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ILBParameterElement> Value { get; }

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