namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory();

        IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory();

        IConstraints5ConstraintElementFactory CreateConstraints5ConstraintElementFactory();

        IConstraints6LConstraintElementFactory CreateConstraints6LConstraintElementFactory();

        IConstraints6UConstraintElementFactory CreateConstraints6UConstraintElementFactory();

        IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory();

        IConstraints11ConstraintElementFactory CreateConstraints11ConstraintElementFactory();

        IConstraints12ConstraintElementFactory CreateConstraints12ConstraintElementFactory();

        IConstraints13LConstraintElementFactory CreateConstraints13LConstraintElementFactory();

        IConstraints13MConstraintElementFactory CreateConstraints13MConstraintElementFactory();

        IConstraints13UConstraintElementFactory CreateConstraints13UConstraintElementFactory();

        IConstraints14ConstraintElementFactory CreateConstraints14ConstraintElementFactory();

        IConstraints15ConstraintElementFactory CreateConstraints15ConstraintElementFactory();

        IConstraints16ConstraintElementFactory CreateConstraints16ConstraintElementFactory();
    }
}