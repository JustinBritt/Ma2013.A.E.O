namespace Ma2013.A.E.O.Classes.Indices.Common
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            ImmutableList<IwIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IwIndexElement> Value { get; }

        public IwIndexElement GetElementAt(
            Organization value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}