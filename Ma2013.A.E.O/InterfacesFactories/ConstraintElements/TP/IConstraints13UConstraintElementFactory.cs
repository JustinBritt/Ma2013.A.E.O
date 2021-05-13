namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IConstraints13UConstraintElementFactory
    {
        IConstraints13UConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w,
            Interfaces.Variables.TP.WardDayBedAvailabilityDeviations.IδPlus δPlus_wd);
    }
}