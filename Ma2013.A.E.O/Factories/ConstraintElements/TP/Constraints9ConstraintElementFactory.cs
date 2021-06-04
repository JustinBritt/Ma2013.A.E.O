namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints9ConstraintElementFactory : IConstraints9ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElementFactory()
        {
        }

        public IConstraints9ConstraintElement Create(
            IpIndexElement pIndexElement,
            Ia a,
            ITHR THR,
            ITPx x)
        {
            IConstraints9ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints9ConstraintElement(
                    pIndexElement,
                    a,
                    THR,
                    x);
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