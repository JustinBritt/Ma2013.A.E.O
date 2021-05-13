namespace Ma2013.A.E.O.Interfaces.Variables.TP.WardSpareBeds
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds;

    public interface IδPlus
    {
        VariableCollection<IwIndexElement> Value { get; }

        double GetElementAt(
            IwIndexElement wIndexElement);

        Interfaces.Results.TP.WardSpareBeds.IδPlus GetElementsAt(
            IδPlusResultElementFactory δPlusResultElementFactory,
            IδPlusFactory δPlusFactory,
            Iw w);
    }
}