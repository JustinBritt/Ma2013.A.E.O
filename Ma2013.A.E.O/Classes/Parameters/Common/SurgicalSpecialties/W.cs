namespace Ma2013.A.E.O.Classes.Parameters.Common.SurgicalSpecialties
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;

    internal sealed class W : IW
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public W(
            ImmutableList<IWParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWParameterElement> Value { get; }

        public IwIndexElement GetSurgicalSpecialtyOfSurgeon(
            IsIndexElement sIndexElement)
        {
            IwIndexElement value = null;

            foreach (IWParameterElement WParameterElement in this.Value)
            {
                if (this.IsSurgeonMemberOfSurgicalSpecialty(
                    WParameterElement.wIndexElement,
                    sIndexElement))
                {
                    value = WParameterElement.wIndexElement;
                }
            }

            return value;
        }

        public bool IsSurgeonMemberOfSurgicalSpecialty(
            IwIndexElement wIndexElement,
            IsIndexElement sIndexElement)
        {
            bool value = this.Value
                .Where(x => x.wIndexElement == wIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault()
                .Contains(sIndexElement);

            return value;
        }
    }
}