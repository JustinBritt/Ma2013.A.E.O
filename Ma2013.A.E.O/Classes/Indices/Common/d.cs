namespace Ma2013.A.E.O.Classes.Indices.Common
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class d : Interfaces.Indices.Common.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            ImmutableList<IdIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IdIndexElement> Value { get; }

        public IdIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }

        public int GetMaximumKey()
        {
            return this.Value
                .Select(w => w.Key)
                .Max();
        }
    }
}