namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;

    public interface ISurgeonGroupNumberPatientsResultElementFactory
    {
        ISurgeonGroupNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}