namespace Ma2013.A.E.O.Classes.Parameters.Common.WardSubsetPatientGroups
{
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;

    internal sealed class P : IP
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public P(
            RedBlackTree<IwIndexElement, IPParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IwIndexElement, IPParameterElement> Value { get; }

        public bool IsThereElementAt(
            IwIndexElement wIndexElement,
            IpIndexElement pIndexElement)
        {
            int count = this.Value.Values
                .Where(x => x.wIndexElement == wIndexElement && x.Value.Contains(pIndexElement))
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