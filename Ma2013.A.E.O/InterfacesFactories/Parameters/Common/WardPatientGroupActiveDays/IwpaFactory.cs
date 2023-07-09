namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardPatientGroupActiveDays
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;

    public interface IwpaFactory
    {
        Iwpa Create(
            Ia a,
            Ip p,
            Iw w,
            Ipa pa,
            IP P,
            IW W);
    }
}