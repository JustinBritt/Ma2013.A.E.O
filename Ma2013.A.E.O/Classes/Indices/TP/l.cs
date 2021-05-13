namespace Ma2013.A.E.O.Classes.Indices.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            ImmutableList<IlIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IlIndexElement> Value { get; }

        public IlIndexElement GetElementAt(
            int value)
        {
            return this.Value
                .Where(x => x.Value.Value.Value == value)
                .SingleOrDefault();
        }

        public IlIndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }

        public int GetMaximumLengthOfStay()
        {
            return this.Value
                .Select(w => w.Value.Value.Value)
                .Max();
        }
    }
}