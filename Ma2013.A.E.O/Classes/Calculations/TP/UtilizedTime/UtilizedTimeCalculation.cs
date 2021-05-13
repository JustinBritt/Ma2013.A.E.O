namespace Ma2013.A.E.O.Classes.Calculations.TP.UtilizedTime
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.UtilizedTime;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UtilizedTime;
    
    internal sealed class UtilizedTimeCalculation : IUtilizedTimeCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UtilizedTimeCalculation()
        {
        }

        public IUtilizedTime Calculate(
            IUtilizedTimeFactory utilizedTimeFactory,
            Ipa pa,
            Idur dur,
            ITPx x)
        {
            return utilizedTimeFactory.Create(
                pa.Value
                .Select(w =>
                x.GetElementAtAsint(
                    w.pIndexElement,
                    w.aIndexElement)
                *
                dur.GetElementAtAsdecimal(
                    w.pIndexElement))
                .Sum());
        }
    }
}