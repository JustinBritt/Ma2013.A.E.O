namespace Ma2013.A.E.O.Factories.ConstraintElements.SP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP;

    internal sealed class Constraints6UConstraintElementFactory : IConstraints6UConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6UConstraintElementFactory()
        {
        }

        public IConstraints6UConstraintElement Create(
            IpIndexElement pIndexElement,
            Ia a,
            IUB UB,
            ISPx x)
        {
            IConstraints6UConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints6UConstraintElement(
                    pIndexElement,
                    a,
                    UB,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}