namespace Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            ImmutableList<IγParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IγParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement)
        {
            return this.Value
                .Where(x => x.wIndexElement == wIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}