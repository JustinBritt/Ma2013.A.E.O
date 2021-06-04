namespace Ma2013.A.E.O.Factories.ConstraintElements.SP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP;

    internal sealed class Constraints3ConstraintElementFactory : IConstraints3ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElementFactory()
        {
        }

        public IConstraints3ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Ipa pa,
            IA A,
            IP P,
            ISPx x,
            ISPy y)
        {
            IConstraints3ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints3ConstraintElement(
                    dIndexElement,
                    wIndexElement,
                    pa,
                    A,
                    P,
                    x,
                    y);
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