namespace Ma2013.A.E.O.Classes.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    internal sealed class TPz : ITPz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPz(
            VariableCollection<IsIndexElement, IaIndexElement, IrIndexElement, IkIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IaIndexElement, IrIndexElement, IkIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, aIndexElement, rIndexElement, kIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments.ITPz GetElementsAt(
            ITPzResultElementFactory zResultElementFactory,
            ITPzFactory zFactory,
            Isark sark)
        {
            return zFactory.Create(
                sark.Value
                .Select(
                    i => zResultElementFactory.Create(
                        i.sIndexElement,
                        i.aIndexElement,
                        i.rIndexElement,
                        i.kIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.aIndexElement,
                            i.rIndexElement,
                            i.kIndexElement)))
                .ToImmutableList());
        }
    }
}