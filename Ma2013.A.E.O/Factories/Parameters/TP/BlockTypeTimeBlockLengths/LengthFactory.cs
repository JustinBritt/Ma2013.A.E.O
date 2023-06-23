namespace Ma2013.A.E.O.Factories.Parameters.TP.BlockTypeTimeBlockLengths
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.BlockTypeTimeBlockLengths;

    internal sealed class LengthFactory : ILengthFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LengthFactory()
        {
        }

        public ILength Create(
            RedBlackTree<IkIndexElement, ILengthParameterElement> value)
        {
            ILength parameter = null;

            try
            {
                parameter = new Length(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}