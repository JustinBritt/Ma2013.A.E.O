namespace Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>> Value { get; }

        public bool IsThereElementAt(
            IpaCrossJoinElement paCrossJoinElement,
            IdIndexElement dIndexElement)
        {
            return this.Value[paCrossJoinElement]
                .Contains(
                dIndexElement);
        }
    }
}