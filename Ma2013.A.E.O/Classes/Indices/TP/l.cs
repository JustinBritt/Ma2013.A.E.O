namespace Ma2013.A.E.O.Classes.Indices.TP
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            RedBlackTree<INullableValue<int>, IlIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IlIndexElement> Value { get; }

        public IlIndexElement GetElementAt(
            int value)
        {
            return this.Value.Values
                .Where(x => x.Value.Value.Value == value)
                .SingleOrDefault();
        }

        public IlIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }

        public int GetMaximumLengthOfStay()
        {
            return this.Value.Values
                .Select(w => w.Value.Value.Value)
                .Max();
        }
    }
}