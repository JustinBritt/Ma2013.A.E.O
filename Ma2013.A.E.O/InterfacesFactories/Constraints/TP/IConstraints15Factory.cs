namespace Ma2013.A.E.O.InterfacesFactories.Constraints.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    public interface IConstraints15Factory
    {
        IConstraints15 Create(
            ImmutableList<IConstraints15ConstraintElement> value);
    }
}