namespace Ma2013.A.E.O.InterfacesFactories.Constraints.TP
{
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    public interface IConstraint2Factory
    {
        IConstraint2 Create(
            Iw w,
            IBEDS BEDS,
            ITPy y);
    }
}