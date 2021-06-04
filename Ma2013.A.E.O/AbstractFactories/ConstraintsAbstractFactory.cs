namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Constraints.SP;
    using Ma2013.A.E.O.Factories.Constraints.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.SP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public Ma2013.A.E.O.InterfacesFactories.Constraints.SP.IConstraint2Factory CreateSPConstraint2Factory()
        {
            Ma2013.A.E.O.InterfacesFactories.Constraints.SP.IConstraint2Factory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Constraints.SP.Constraint2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Constraints.TP.IConstraint2Factory CreateTPConstraint2Factory()
        {
            Ma2013.A.E.O.InterfacesFactories.Constraints.TP.IConstraint2Factory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Constraints.TP.Constraint2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints3Factory CreateConstraints3Factory()
        {
            IConstraints3Factory factory = null;

            try
            {
                factory = new Constraints3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints4Factory CreateConstraints4Factory()
        {
            IConstraints4Factory factory = null;

            try
            {
                factory = new Constraints4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5Factory CreateConstraints5Factory()
        {
            IConstraints5Factory factory = null;

            try
            {
                factory = new Constraints5Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints6LFactory CreateConstraints6LFactory()
        {
            IConstraints6LFactory factory = null;

            try
            {
                factory = new Constraints6LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints6UFactory CreateConstraints6UFactory()
        {
            IConstraints6UFactory factory = null;

            try
            {
                factory = new Constraints6UFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints9Factory CreateConstraints9Factory()
        {
            IConstraints9Factory factory = null;

            try
            {
                factory = new Constraints9Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints11Factory CreateConstraints11Factory()
        {
            IConstraints11Factory factory = null;

            try
            {
                factory = new Constraints11Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints12Factory CreateConstraints12Factory()
        {
            IConstraints12Factory factory = null;

            try
            {
                factory = new Constraints12Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints13LFactory CreateConstraints13LFactory()
        {
            IConstraints13LFactory factory = null;

            try
            {
                factory = new Constraints13LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints13MFactory CreateConstraints13MFactory()
        {
            IConstraints13MFactory factory = null;

            try
            {
                factory = new Constraints13MFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints13UFactory CreateConstraints13UFactory()
        {
            IConstraints13UFactory factory = null;

            try
            {
                factory = new Constraints13UFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints14Factory CreateConstraints14Factory()
        {
            IConstraints14Factory factory = null;

            try
            {
                factory = new Constraints14Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints15Factory CreateConstraints15Factory()
        {
            IConstraints15Factory factory = null;

            try
            {
                factory = new Constraints15Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints16Factory CreateConstraints16Factory()
        {
            IConstraints16Factory factory = null;

            try
            {
                factory = new Constraints16Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}