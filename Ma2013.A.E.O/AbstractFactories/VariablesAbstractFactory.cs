namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Factories.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Factories.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Factories.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Factories.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Factories.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Factories.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Factories.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardNumberBedAssignments;

    internal sealed class VariablesAbstractFactory : IVariablesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariablesAbstractFactory()
        {
        }

        public ISPxFactory CreateSPxFactory()
        {
            ISPxFactory factory = null;

            try
            {
                factory = new SPxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISPyFactory CreateSPyFactory()
        {
            ISPyFactory factory = null;

            try
            {
                factory = new SPyFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISPzFactory CreateSPzFactory()
        {
            ISPzFactory factory = null;

            try
            {
                factory = new SPzFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPxFactory CreateTPxFactory()
        {
            ITPxFactory factory = null;

            try
            {
                factory = new TPxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPyFactory CreateTPyFactory()
        {
            ITPyFactory factory = null;

            try
            {
                factory = new TPyFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPzFactory CreateTPzFactory()
        {
            ITPzFactory factory = null;

            try
            {
                factory = new TPzFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardBedOccupancyVariances.IVarianceFactory CreateVariancewFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardBedOccupancyVariances.IVarianceFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Variables.TP.WardBedOccupancyVariances.VarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementVariances.IVarianceFactory CreateVariancewdFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementVariances.IVarianceFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Variables.TP.WardDayBedRequirementVariances.VarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IδMinusFactory CreateδMinusFactory()
        {
            IδMinusFactory factory = null;

            try
            {
                factory = new δMinusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardSpareBeds.IδPlusFactory CreateδPluswFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardSpareBeds.IδPlusFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Variables.TP.WardSpareBeds.δPlusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations.IδPlusFactory CreateδPluswdFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations.IδPlusFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Variables.TP.WardDayBedAvailabilityDeviations.δPlusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            μFactory factory = null;

            try
            {
                factory = new μFactory();
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