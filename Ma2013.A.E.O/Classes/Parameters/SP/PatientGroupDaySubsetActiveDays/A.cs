namespace Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            ImmutableList<IAParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IAParameterElement> Value { get; }

        public bool IsThereElementAt(
            IpIndexElement pIndexElement,
            IdIndexElement dIndexElement,
            IaIndexElement aIndexElement)
        {
            int count = this.Value
                .Where(x => x.pIndexElement == pIndexElement && x.dIndexElement == dIndexElement && x.aIndexElement == aIndexElement)
                .Distinct()
                .Count();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}