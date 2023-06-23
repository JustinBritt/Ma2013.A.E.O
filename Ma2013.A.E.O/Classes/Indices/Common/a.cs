namespace Ma2013.A.E.O.Classes.Indices.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;

    internal sealed class a : Ia
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public a(
            RedBlackTree<FhirDateTime, IaIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<FhirDateTime, IaIndexElement> Value { get; }

        public IaIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value[value];
        }
    }
}