namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    public interface ICrossJoinElementsAbstractFactory
    {
        IarCrossJoinElementFactory CreatearCrossJoinElementFactory();

        IpaCrossJoinElementFactory CreatepaCrossJoinElementFactory();

        IrkCrossJoinElementFactory CreaterkCrossJoinElementFactory();

        IsaCrossJoinElementFactory CreatesaCrossJoinElementFactory();

        IsarCrossJoinElementFactory CreatesarCrossJoinElementFactory();

        IsarkCrossJoinElementFactory CreatesarkCrossJoinElementFactory();

        IskCrossJoinElementFactory CreateskCrossJoinElementFactory();

        IwdCrossJoinElementFactory CreatewdCrossJoinElementFactory();
    }
}