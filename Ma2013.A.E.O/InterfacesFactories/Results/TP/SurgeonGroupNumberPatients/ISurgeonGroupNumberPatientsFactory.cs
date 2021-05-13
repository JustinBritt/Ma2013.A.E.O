namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberPatients
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients;

    public interface ISurgeonGroupNumberPatientsFactory
    {
        ISurgeonGroupNumberPatients Create(
            ImmutableList<ISurgeonGroupNumberPatientsResultElement> value);
    }
}