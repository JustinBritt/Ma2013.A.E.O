namespace Ma2013.A.E.O.Classes.Variables.SP.WardNumberBedAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.WardNumberBedAssignments;

    internal sealed class SPy : ISPy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPy(
            VariableCollection<IwIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IwIndexElement> Value { get; }

        public int GetElementAt(
            IwIndexElement wIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[wIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[wIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.SP.WardNumberBedAssignments.ISPy GetElementsAt(
            ISPyResultElementFactory yResultElementFactory,
            ISPyFactory yFactory,
            Iw w)
        {
            return yFactory.Create(
                w.Value
                .Select(
                    i => yResultElementFactory.Create(
                        i,
                        this.GetElementAt(
                            i)))
                .ToImmutableList());
        }
    }
}