namespace Ma2013.A.E.O.Interfaces.Models.SP
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;

    public interface ISPModel
    {
        /// <summary>
        /// Gets the Model instance
        /// </summary>
        Model Model { get; }

        Iw w { get; }

        Ipa pa { get; }

        Isa sa { get; }

        Ir r { get; }

        ISPx x { get; }

        ISPy y { get; }

        ISPz z { get; }
    }
}