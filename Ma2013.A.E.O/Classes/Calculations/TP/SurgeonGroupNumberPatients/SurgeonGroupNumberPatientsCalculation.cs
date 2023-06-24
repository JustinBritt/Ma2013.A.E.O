namespace Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsCalculation : ISurgeonGroupNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsCalculation()
        {
        }

        public ISurgeonGroupNumberPatients Calculate(
            ISurgeonGroupNumberPatientsResultElementFactory surgeonGroupNumberPatientsResultElementFactory,
            ISurgeonGroupNumberPatientsFactory surgeonGroupNumberPatientsFactory,
            ISurgeonGroupNumberPatientsResultElementCalculation surgeonGroupNumberPatientsResultElementCalculation,
            Is s,
            Ipa pa,
            IP P,
            ITPx x)
        {
            return surgeonGroupNumberPatientsFactory.Create(
                s.Value.Values
                .Select(w => surgeonGroupNumberPatientsResultElementCalculation.Calculate(
                    surgeonGroupNumberPatientsResultElementFactory,
                    w,
                    pa,
                    P,
                    x))
                .ToImmutableList());
        }
    }
}