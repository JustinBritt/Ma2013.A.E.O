namespace Ma2013.A.E.O.Classes.Indices.Common
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class d : Interfaces.Indices.Common.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            RedBlackTree<FhirDateTime, IdIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<FhirDateTime, IdIndexElement> Value { get; }

        public IdIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value[value];
        }

        public int GetMaximumKey()
        {
            return this.Value.Values
                .Select(w => w.Key)
                .Max();
        }
    }
}