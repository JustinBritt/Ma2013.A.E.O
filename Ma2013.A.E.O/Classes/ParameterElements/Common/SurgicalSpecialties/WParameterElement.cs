namespace Ma2013.A.E.O.Classes.ParameterElements.Common.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;

    internal sealed class WParameterElement : IWParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WParameterElement(
            IwIndexElement wIndexElement,
            ImmutableList<IsIndexElement> value)
        {
            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public ImmutableList<IsIndexElement> Value { get; }
    }
}