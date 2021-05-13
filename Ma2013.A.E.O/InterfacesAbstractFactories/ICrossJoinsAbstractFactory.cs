namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP;

    public interface ICrossJoinsAbstractFactory
    {
        IarFactory CreatearFactory();

        IpaFactory CreatepaFactory();

        IrkFactory CreaterkFactory();

        IsaFactory CreatesaFactory();

        IsarFactory CreatesarFactory();

        IsarkFactory CreatesarkFactory();

        IskFactory CreateskFactory();

        IwdFactory CreatewdFactory();
    }
}