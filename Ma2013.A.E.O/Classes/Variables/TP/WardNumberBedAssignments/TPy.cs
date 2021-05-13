namespace Ma2013.A.E.O.Classes.Variables.TP.WardNumberBedAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberBedAssignments;

    internal sealed class TPy : ITPy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPy(
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

        public Interfaces.Results.TP.WardNumberBedAssignments.ITPy GetElementsAt(
            ITPyResultElementFactory yResultElementFactory,
            ITPyFactory yFactory,
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