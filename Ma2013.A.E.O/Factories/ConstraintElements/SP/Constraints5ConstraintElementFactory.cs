namespace Ma2013.A.E.O.Factories.ConstraintElements.SP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP;

    internal sealed class Constraints5ConstraintElementFactory : IConstraints5ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5ConstraintElementFactory()
        {
        }

        public IConstraints5ConstraintElement Create(
            IaIndexElement aIndexElement,
            IsIndexElement sIndexElement,
            Ip p,
            Idur dur,
            ILENGTH LENGTH,
            IP P,
            ISPx x,
            ISPz z)
        {
            IConstraints5ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5ConstraintElement(
                    aIndexElement,
                    sIndexElement,
                    p,
                    dur,
                    LENGTH,
                    P,
                    x,
                    z);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}