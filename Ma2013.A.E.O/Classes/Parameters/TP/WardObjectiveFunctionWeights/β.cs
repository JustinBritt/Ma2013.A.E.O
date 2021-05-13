namespace Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class β : Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            ImmutableList<IβParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IβParameterElement> Value { get; }

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