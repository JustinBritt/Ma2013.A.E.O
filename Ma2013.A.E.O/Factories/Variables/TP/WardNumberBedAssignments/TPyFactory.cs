namespace Ma2013.A.E.O.Factories.Variables.TP.WardNumberBedAssignments
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardNumberBedAssignments;

    internal sealed class TPyFactory : ITPyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPyFactory()
        {
        }

        public ITPy Create(
            VariableCollection<IwIndexElement> value)
        {
            ITPy variable = null;

            try
            {
                variable = new TPy(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }
    }
}