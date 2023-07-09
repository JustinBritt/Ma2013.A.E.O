namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights;

    public interface IParametersAbstractFactory
    {
        IAFactory CreateAFactory();

        IBEDSFactory CreateBEDSFactory();

        IBLOCKSFactory CreateBLOCKSFactory();

        IdurFactory CreatedurFactory();

        ILENGTHFactory CreateLENGTHFactory();

        ILengthFactory CreateLengthFactory();

        ILBFactory CreateLBFactory();

        IORdayFactory CreateORdayFactory();

        Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups.IPFactory CreatePsFactory();

        Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups.IPFactory CreatePwFactory();

        IprobFactory CreateprobFactory();

        IrFactory CreaterFactory();

        ITHRFactory CreateTHRFactory();

        IUBFactory CreateUBFactory();

        IWFactory CreateWFactory();

        IwpaFactory CreatewpaFactory();

        IαFactory CreateαFactory();

        IβFactory CreateβFactory();

        IγFactory CreateγFactory();
    }
}