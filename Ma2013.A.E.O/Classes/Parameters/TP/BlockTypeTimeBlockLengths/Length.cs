namespace Ma2013.A.E.O.Classes.Parameters.TP.BlockTypeTimeBlockLengths
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;

    internal sealed class Length : ILength
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Length(
            ImmutableList<ILengthParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ILengthParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.kIndexElement == kIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}