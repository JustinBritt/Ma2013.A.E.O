namespace Ma2013.A.E.O.InterfacesFactories.Constraints.SP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    public interface IConstraints6LFactory
    {
        IConstraints6L Create(
            ImmutableList<IConstraints6LConstraintElement> value);
    }
}