namespace Ma2013.A.E.O.Classes.Calculations.TP.NumberPatients
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.NumberPatients;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.NumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.NumberPatients;

    internal sealed class NumberPatientsCalculation : INumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberPatientsCalculation()
        {
        }

        public INumberPatients Calculate(
            INumberPatientsFactory numberPatientsFactory,
            Ipa pa,
            ITPx x)
        {
            return numberPatientsFactory.Create(
                pa.Value
                .Select(
                    i =>
                    x.GetElementAtAsint(
                        i.pIndexElement,
                        i.aIndexElement))
                .Sum());
        }
    }
}