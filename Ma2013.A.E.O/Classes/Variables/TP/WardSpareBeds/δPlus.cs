namespace Ma2013.A.E.O.Classes.Variables.TP.WardSpareBeds
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds;

    internal sealed class δPlus : IδPlus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlus(
            VariableCollection<IwIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IwIndexElement> Value { get; }

        public double GetElementAt(
            IwIndexElement wIndexElement)
        {
            return this.Value[wIndexElement].Value;
        }

        public Interfaces.Results.TP.WardSpareBeds.IδPlus GetElementsAt(
            IδPlusResultElementFactory δPlusResultElementFactory,
            IδPlusFactory δPlusFactory,
            Iw w)
        {
            return δPlusFactory.Create(
                w.Value.Values
                .Select(
                    i => δPlusResultElementFactory.Create(
                        i,
                        (decimal)this.GetElementAt(
                            i)))
                .ToImmutableList());
        }
    }
}