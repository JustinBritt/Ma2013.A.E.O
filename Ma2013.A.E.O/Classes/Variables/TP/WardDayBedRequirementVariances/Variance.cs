namespace Ma2013.A.E.O.Classes.Variables.TP.WardDayBedRequirementVariances
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementVariances;

    internal sealed class Variance : IVariance
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Variance(
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

        public Interfaces.Results.TP.WardDayBedRequirementVariances.IVariance GetElementsAt(
            IVarianceResultElementFactory VarianceResultElementFactory,
            IVarianceFactory VarianceFactory,
            Iwd wd)
        {
            return VarianceFactory.Create(
                wd.Value
                .Select(
                    i => VarianceResultElementFactory.Create(
                        i.wIndexElement,
                        i.dIndexElement,
                        (decimal)this.GetElementAt(
                            i.wIndexElement,
                            i.dIndexElement)))
                .ToImmutableList());
        }
    }
}