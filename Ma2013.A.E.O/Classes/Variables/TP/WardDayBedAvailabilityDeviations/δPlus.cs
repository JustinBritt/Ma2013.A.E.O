namespace Ma2013.A.E.O.Classes.Variables.TP.WardDayBedAvailabilityDeviations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δPlus : IδPlus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlus(
            VariableCollection<IwIndexElement, IdIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IwIndexElement, IdIndexElement> Value { get; }

        public double GetElementAt(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value[wIndexElement, dIndexElement].Value;
        }

        public Interfaces.Results.TP.WardDayBedAvailabilityDeviations.IδPlus GetElementsAt(
            IδPlusResultElementFactory δPlusResultElementFactory,
            IδPlusFactory δPlusFactory,
            Iwd wd)
        {
            return δPlusFactory.Create(
                wd.Value
                .Select(
                    i => δPlusResultElementFactory.Create(
                        i.wIndexElement,
                        i.dIndexElement,
                        (decimal)this.GetElementAt(
                            i.wIndexElement,
                            i.dIndexElement)))
                .ToImmutableList());
        }
    }
}