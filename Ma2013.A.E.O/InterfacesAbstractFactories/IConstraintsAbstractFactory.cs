namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Constraints.SP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    public interface IConstraintsAbstractFactory
    {
        Ma2013.A.E.O.InterfacesFactories.Constraints.SP.IConstraint2Factory CreateSPConstraint2Factory();

        Ma2013.A.E.O.InterfacesFactories.Constraints.TP.IConstraint2Factory CreateTPConstraint2Factory();

        IConstraints3Factory CreateConstraints3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraints5Factory CreateConstraints5Factory();

        IConstraints6LFactory CreateConstraints6LFactory();

        IConstraints6UFactory CreateConstraints6UFactory();

        IConstraints9Factory CreateConstraints9Factory();

        IConstraints11Factory CreateConstraints11Factory();

        IConstraints12Factory CreateConstraints12Factory();

        IConstraints13LFactory CreateConstraints13LFactory();

        IConstraints13MFactory CreateConstraints13MFactory();

        IConstraints13UFactory CreateConstraints13UFactory();

        IConstraints14Factory CreateConstraints14Factory();

        IConstraints15Factory CreateConstraints15Factory();

        IConstraints16Factory CreateConstraints16Factory();
    }
}