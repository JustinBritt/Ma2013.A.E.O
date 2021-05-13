namespace Ma2013.A.E.O.Classes.Variables.TP.PatientGroupActiveDayNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.PatientGroupActiveDayNumberPatientAssignments;

    internal sealed class TPx : ITPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPx(
            VariableCollection<IpIndexElement, IaIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IpIndexElement, IaIndexElement> Value { get; }

        public int GetElementAt(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[pIndexElement, aIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[pIndexElement, aIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments.ITPx GetElementsAt(
            ITPxResultElementFactory xResultElementFactory,
            ITPxFactory xFactory,
            Ipa pa)
        {
            return xFactory.Create(
                pa.Value
                .Select(
                    i => xResultElementFactory.Create(
                        i.pIndexElement,
                        i.aIndexElement,
                        this.GetElementAt(
                            i.pIndexElement,
                            i.aIndexElement)))
                .ToImmutableList());
        }
    }
}