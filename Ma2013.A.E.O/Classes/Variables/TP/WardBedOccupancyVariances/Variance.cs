namespace Ma2013.A.E.O.Classes.Variables.TP.WardBedOccupancyVariances
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances;

    internal sealed class Variance : IVariance
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Variance(
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

        public Interfaces.Results.TP.WardBedOccupancyVariances.IVariance GetElementsAt(
            IVarianceResultElementFactory VarianceResultElementFactory,
            IVarianceFactory VarianceFactory,
            Iw w)
        {
            return VarianceFactory.Create(
                w.Value
                .Select(
                    i => VarianceResultElementFactory.Create(
                        i,
                        (decimal)this.GetElementAt(
                            i)))
                .ToImmutableList());
        }
    }
}