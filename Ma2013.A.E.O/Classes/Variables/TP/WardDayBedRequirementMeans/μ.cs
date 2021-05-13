namespace Ma2013.A.E.O.Classes.Variables.TP.WardDayBedRequirementMeans
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementMeans;

    internal sealed class μ : Iμ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μ(
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

        public Interfaces.Results.TP.WardDayBedRequirementMeans.Iμ GetElementsAt(
            IμResultElementFactory μResultElementFactory,
            IμFactory μFactory,
            Iwd wd)
        {
            return μFactory.Create(
                wd.Value
                .Select(
                    i => μResultElementFactory.Create(
                        i.wIndexElement,
                        i.dIndexElement,
                        (decimal)this.GetElementAt(
                            i.wIndexElement,
                            i.dIndexElement)))
                .ToImmutableList());
        }
    }
}