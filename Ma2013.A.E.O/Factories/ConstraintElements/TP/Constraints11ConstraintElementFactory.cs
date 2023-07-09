namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;
 
    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints11ConstraintElementFactory : IConstraints11ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints11ConstraintElementFactory()
        {
        }

        public IConstraints11ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Id d,
            Il l,
            Iprob prob,
            Iwpa wpa,
            ITPx x,
            Iμ μ)
        {
            IConstraints11ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints11ConstraintElement(
                    dIndexElement,
                    wIndexElement,
                    d,
                    l,
                    prob,
                    wpa,
                    x,
                    μ);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}