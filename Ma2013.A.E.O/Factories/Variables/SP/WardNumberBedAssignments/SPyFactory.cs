namespace Ma2013.A.E.O.Factories.Variables.SP.WardNumberBedAssignments
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.WardNumberBedAssignments;

    internal sealed class SPyFactory : ISPyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPyFactory()
        {
        }

        public ISPy Create(
            VariableCollection<IwIndexElement> value)
        {
            ISPy variable = null;

            try
            {
                variable = new SPy(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}