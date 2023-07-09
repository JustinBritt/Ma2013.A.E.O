﻿namespace Ma2013.A.E.O.Classes.Parameters.Common.WardPatientGroupActiveDays
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays;

    internal sealed class wpa : Iwpa
    {
        public wpa(
            RedBlackTree<IwIndexElement, RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IwIndexElement, RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>> Value { get; }
    }
}