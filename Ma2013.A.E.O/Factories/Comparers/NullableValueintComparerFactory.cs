namespace Ma2013.A.E.O.Factories.Comparers
{
    using Ma2013.A.E.O.Classes.Comparers;
    using Ma2013.A.E.O.Interfaces.Comparers;
    using Ma2013.A.E.O.InterfacesFactories.Comparers;

    internal sealed class NullableValueintComparerFactory : INullableValueintComparerFactory
    {
        public NullableValueintComparerFactory()
        {
        }

        public INullableValueintComparer Create()
        {
            INullableValueintComparer instance = null;

            try
            {
                instance = new NullableValueintComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}