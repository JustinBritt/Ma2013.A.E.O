namespace Ma2013.A.E.O.InterfacesFactories.Constraints.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    public interface IConstraints13LFactory
    {
        IConstraints13L Create(
            ImmutableList<IConstraints13LConstraintElement> value);
    }
}