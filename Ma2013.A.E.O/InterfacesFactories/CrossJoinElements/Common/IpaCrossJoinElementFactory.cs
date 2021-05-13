namespace Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common
{
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IpaCrossJoinElementFactory
    {
        IpaCrossJoinElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement);
    }
}