namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementMeans
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;

    public interface IμFactory
    {
        Iμ Create(
            VariableCollection<IwIndexElement, IdIndexElement> value);
    }
}