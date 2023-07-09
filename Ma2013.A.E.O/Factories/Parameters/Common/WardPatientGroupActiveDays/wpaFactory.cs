namespace Ma2013.A.E.O.Factories.Parameters.Common.WardPatientGroupActiveDays
{
    using System;
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardPatientGroupActiveDays;

    internal sealed class wpaFactory : IwpaFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wpaFactory()
        {
        }

        public Iwpa Create(
            Ia a,
            Ip p,
            Iw w,
            Ipa pa,
            IP P,
            IW W)
        {
            Iwpa instance = null;

            try
            {
                instance = new wpa(
                    this.CreateRedBlackTree(
                        a,
                        p,
                        w,
                        pa,
                        P,
                        W));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        private RedBlackTree<IwIndexElement, RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>> CreateRedBlackTree(
            Ia a,
            Ip p,
            Iw w,
            Ipa pa,
            IP P,
            IW W)
        {
            RedBlackTree<IwIndexElement, RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>> outerRedBlackTree = new RedBlackTree<IwIndexElement, RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>>();
            
            foreach (IwIndexElement wIndexElement in w.Value.Values)
            {
                RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>> firstInnerRedBlackTree = new RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>();

                foreach (IpIndexElement pIndexElement in p.Value.Values.Where(x => P.IsThereElementAt(wIndexElement, x)))
                {
                    RedBlackTree<IaIndexElement, IpaCrossJoinElement> secondInnerRedBlackTree = new RedBlackTree<IaIndexElement, IpaCrossJoinElement>();

                    foreach (IaIndexElement aIndexElement in a.Value.Values)
                    {
                        secondInnerRedBlackTree.Add(
                            aIndexElement,
                            pa.Value.Where(x => x.pIndexElement == pIndexElement && x.aIndexElement == aIndexElement).SingleOrDefault());
                    }

                    firstInnerRedBlackTree.Add(
                        pIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    wIndexElement,
                    firstInnerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}