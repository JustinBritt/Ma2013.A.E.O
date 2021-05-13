namespace Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberPatients
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsResultElementCalculation : ISurgeonGroupNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsResultElementCalculation()
        {
        }

        public ISurgeonGroupNumberPatientsResultElement Calculate(
            ISurgeonGroupNumberPatientsResultElementFactory surgeonGroupNumberPatientsResultElementFactory,
            IsIndexElement sIndexElement,
            Ipa pa,
            IP P,
            ITPx x)
        {
            return surgeonGroupNumberPatientsResultElementFactory.Create(
                sIndexElement,
                pa.Value
                .Where(w => P.IsThereElementAt(sIndexElement, w.pIndexElement))
                .Select(w => x.GetElementAtAsint(w.pIndexElement, w.aIndexElement))
                .Sum());
        }
    }
}