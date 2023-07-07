namespace Ma2013.A.E.O.Classes.ParameterElements.Common.WardSubsetPatientGroups
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;

    internal sealed class PParameterElement : IPParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PParameterElement(
            IwIndexElement wIndexElement,
            ImmutableSortedSet<IpIndexElement> value)
        {
            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public ImmutableSortedSet<IpIndexElement> Value { get; }
    }
}