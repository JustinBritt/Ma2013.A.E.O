namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints12ConstraintElementFactory : IConstraints12ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints12ConstraintElementFactory()
        {
        }

        public IConstraints12ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Id d,
            Il l,
            Ipa pa,
            IP P,
            Iprob prob,
            ITPx x,
            IVariance Variance)
        {
            IConstraints12ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints12ConstraintElement(
                    dIndexElement,
                    wIndexElement,
                    d,
                    l,
                    pa,
                    P,
                    prob,
                    x,
                    Variance);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}