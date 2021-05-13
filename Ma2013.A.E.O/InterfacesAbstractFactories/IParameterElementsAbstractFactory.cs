namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.WardObjectiveFunctionWeights;

    public interface IParameterElementsAbstractFactory
    {
        IAParameterElementFactory CreateAParameterElementFactory();

        IdurParameterElementFactory CreatedurParameterElementFactory();

        ILengthParameterElementFactory CreateLengthParameterElementFactory();

        ILBParameterElementFactory CreateLBParameterElementFactory();

        IORdayParameterElementFactory CreateORdayParameterElementFactory();

        Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups.IPParameterElementFactory CreatePsParameterElementFactory();

        Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups.IPParameterElementFactory CreatePwParameterElementFactory();

        IprobParameterElementFactory CreateprobParameterElementFactory();

        IrParameterElementFactory CreaterParameterElementFactory();

        ITHRParameterElementFactory CreateTHRParameterElementFactory();

        IUBParameterElementFactory CreateUBParameterElementFactory();

        IWParameterElementFactory CreateWParameterElementFactory();

        IαParameterElementFactory CreateαParameterElementFactory();

        IβParameterElementFactory CreateβParameterElementFactory();

        IγParameterElementFactory CreateγParameterElementFactory();
    }
}