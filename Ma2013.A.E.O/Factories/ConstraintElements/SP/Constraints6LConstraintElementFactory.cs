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

    internal sealed class Constraints6LConstraintElementFactory : IConstraints6LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6LConstraintElementFactory()
        {
        }

        public IConstraints6LConstraintElement Create(
            IpIndexElement pIndexElement,
            Ia a,
            ILB LB,
            ISPx x)
        {
            IConstraints6LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints6LConstraintElement(
                    pIndexElement,
                    a,
                    LB,
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