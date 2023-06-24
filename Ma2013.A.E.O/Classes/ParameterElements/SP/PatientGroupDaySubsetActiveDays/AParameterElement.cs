namespace Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;

    internal sealed class AParameterElement : IAParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElement(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            ImmutableList<IdIndexElement> value)
        {
            this.pIndexElement = pIndexElement;

            this.aIndexElement = aIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public IaIndexElement aIndexElement { get; }

        public ImmutableList<IdIndexElement> Value { get; }
    }
}