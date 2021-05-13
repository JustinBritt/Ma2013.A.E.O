namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardSpareBeds
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardSpareBeds;

    public interface IδPlusFactory
    {
        IδPlus Create(
            VariableCollection<IwIndexElement> value);
    }
}