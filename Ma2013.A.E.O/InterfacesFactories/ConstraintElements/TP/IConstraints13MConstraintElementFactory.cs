namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    public interface IConstraints13MConstraintElementFactory
    {
        IConstraints13MConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            ITPy y,
            IδPlus δPlus,
            Iμ μ);
    }
}