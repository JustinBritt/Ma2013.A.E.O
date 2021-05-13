namespace Ma2013.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue
{
    using Ma2013.A.E.O.Interfaces.Results.Common.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}