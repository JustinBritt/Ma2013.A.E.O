namespace Ma2013.A.E.O.Interfaces.Models.TP
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    public interface ITPModel
    {
        /// <summary>
        /// Gets the Model instance
        /// </summary>
        Model Model { get; }

        Ia a { get; }

        Id d { get; }

        Ip p { get; }

        Ir r { get; }

        Is s { get; }

        Iw w { get; }

        Ipa pa { get; }

        Isark sark { get; }

        Iwd wd { get; }

        IBEDS BEDS { get; }

        Idur dur { get; }

        ILength Length { get; }

        Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups.IP Ps { get; }

        IW W { get; }

        Iα α { get; }

        Iβ β { get; }

        Iγ γ { get; }

        ITPx x { get; }

        ITPy y { get; }

        ITPz z { get; }

        IδMinus δMinus { get; }

        Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w { get; }

        Interfaces.Variables.TP.WardDayBedAvailabilityDeviations.IδPlus δPlus_wd { get; }

        Iμ μ { get; }

        Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w { get; }

        Interfaces.Variables.TP.WardDayBedRequirementVariances.IVariance Variance_wd { get; }
    }
}