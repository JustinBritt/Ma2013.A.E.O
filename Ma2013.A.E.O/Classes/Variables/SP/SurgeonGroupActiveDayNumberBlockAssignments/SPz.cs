namespace Ma2013.A.E.O.Classes.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class SPz : ISPz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPz(
            VariableCollection<IsIndexElement, IaIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IaIndexElement> Value { get; }

        public int GetElementAt(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[sIndexElement, aIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[sIndexElement, aIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments.ISPz GetElementsAt(
            ISPzResultElementFactory zResultElementFactory,
            ISPzFactory zFactory,
            Isa sa)
        {
            return zFactory.Create(
                sa.Value
                .Select(
                    i => zResultElementFactory.Create(
                        i.sIndexElement,
                        i.aIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.aIndexElement)))
                .ToImmutableList());
        }
    }
}