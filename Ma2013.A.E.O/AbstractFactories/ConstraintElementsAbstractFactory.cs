namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.ConstraintElements.SP;
    using Ma2013.A.E.O.Factories.ConstraintElements.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory()
        {
            IConstraints3ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints3ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory()
        {
            IConstraints4ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints4ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints5ConstraintElementFactory CreateConstraints5ConstraintElementFactory()
        {
            IConstraints5ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints6LConstraintElementFactory CreateConstraints6LConstraintElementFactory()
        {
            IConstraints6LConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints6LConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints6UConstraintElementFactory CreateConstraints6UConstraintElementFactory()
        {
            IConstraints6UConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints6UConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory()
        {
            IConstraints9ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints9ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints11ConstraintElementFactory CreateConstraints11ConstraintElementFactory()
        {
            IConstraints11ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints11ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints12ConstraintElementFactory CreateConstraints12ConstraintElementFactory()
        {
            IConstraints12ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints12ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints13LConstraintElementFactory CreateConstraints13LConstraintElementFactory()
        {
            IConstraints13LConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints13LConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints13MConstraintElementFactory CreateConstraints13MConstraintElementFactory()
        {
            IConstraints13MConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints13MConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints13UConstraintElementFactory CreateConstraints13UConstraintElementFactory()
        {
            IConstraints13UConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints13UConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints14ConstraintElementFactory CreateConstraints14ConstraintElementFactory()
        {
            IConstraints14ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints14ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints15ConstraintElementFactory CreateConstraints15ConstraintElementFactory()
        {
            IConstraints15ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints15ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints16ConstraintElementFactory CreateConstraints16ConstraintElementFactory()
        {
            IConstraints16ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints16ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}