namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory();

        ILocationComparerFactory CreateLocationComparerFactory();

        INullableValueintComparerFactory CreateNullableValueintComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}