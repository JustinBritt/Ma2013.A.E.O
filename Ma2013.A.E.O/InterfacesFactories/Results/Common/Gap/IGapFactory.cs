namespace Ma2013.A.E.O.InterfacesFactories.Results.Common.Gap
{
    using Ma2013.A.E.O.Interfaces.Results.Common.Gap;

    public interface IGapFactory
    {
        IGap Create(
            decimal value);
    }
}