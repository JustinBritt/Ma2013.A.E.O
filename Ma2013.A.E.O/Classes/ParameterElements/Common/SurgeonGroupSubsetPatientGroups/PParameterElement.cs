namespace Ma2013.A.E.O.Classes.ParameterElements.Common.SurgeonGroupSubsetPatientGroups
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;

    internal sealed class PParameterElement : IPParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PParameterElement(
            IsIndexElement sIndexElement,
            ImmutableSortedSet<IpIndexElement> value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public ImmutableSortedSet<IpIndexElement> Value { get; }
    }
}