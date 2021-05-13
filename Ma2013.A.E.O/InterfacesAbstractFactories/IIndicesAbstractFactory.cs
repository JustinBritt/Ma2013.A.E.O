namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.Indices.TP;

    public interface IIndicesAbstractFactory
    {
        IaFactory CreateaFactory();

        IdFactory CreatedFactory();

        IkFactory CreatekFactory();

        IlFactory CreatelFactory();

        IpFactory CreatepFactory();

        IrFactory CreaterFactory();

        IsFactory CreatesFactory();

        IwFactory CreatewFactory();
    }
}