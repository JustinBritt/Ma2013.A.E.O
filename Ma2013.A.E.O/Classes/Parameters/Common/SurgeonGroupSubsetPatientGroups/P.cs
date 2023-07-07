namespace Ma2013.A.E.O.Classes.Parameters.Common.SurgeonGroupSubsetPatientGroups
{
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;

    internal sealed class P : IP
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public P(
            RedBlackTree<IsIndexElement, IPParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, IPParameterElement> Value { get; }

        public bool IsThereElementAt(
            IsIndexElement sIndexElement,
            IpIndexElement pIndexElement)
        {
            int count = this.Value.Values
                .Where(x => x.sIndexElement == sIndexElement && x.Value.Contains(pIndexElement))
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