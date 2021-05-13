namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances;

    public interface IConstraints14ConstraintElementFactory
    {
        IConstraints14ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w,
            Interfaces.Variables.TP.WardDayBedRequirementVariances.IVariance Variance_wd);
    }
}