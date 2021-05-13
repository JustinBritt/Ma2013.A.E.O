namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalExpectedBedShortage
{
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalExpectedBedShortage;

    public interface ITEBSFactory
    {
        ITEBS Create(
            decimal value);
    }
}