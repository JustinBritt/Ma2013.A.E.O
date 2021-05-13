namespace Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common
{
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IwdCrossJoinElementFactory
    {
        IwdCrossJoinElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement);
    }
}