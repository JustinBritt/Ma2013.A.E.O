namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Factories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Factories.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Factories.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Factories.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Factories.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Factories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Factories.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public IDayBedRequirementMeansResultElementFactory CreateDayBedRequirementMeansResultElementFactory()
        {
            IDayBedRequirementMeansResultElementFactory factory = null;

            try
            {
                factory = new DayBedRequirementMeansResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IDayBedRequirementVariancesResultElementFactory CreateDayBedRequirementVariancesResultElementFactory()
        {
            IDayBedRequirementVariancesResultElementFactory factory = null;

            try
            {
                factory = new DayBedRequirementVariancesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IEBSResultElementFactory CreateEBSResultElementFactory()
        {
            IEBSResultElementFactory factory = null;

            try
            {
                factory = new EBSResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISPxResultElementFactory CreateSPxResultElementFactory()
        {
            ISPxResultElementFactory factory = null;

            try
            {
                factory = new SPxResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISPyResultElementFactory CreateSPyResultElementFactory()
        {
            ISPyResultElementFactory factory = null;

            try
            {
                factory = new SPyResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISPzResultElementFactory CreateSPzResultElementFactory()
        {
            ISPzResultElementFactory factory = null;

            try
            {
                factory = new SPzResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonGroupNumberAssignedOperatingRoomsResultElementFactory()
        {
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedOperatingRoomsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedActiveDaysResultElementFactory CreateSurgeonGroupNumberAssignedActiveDaysResultElementFactory()
        {
            ISurgeonGroupNumberAssignedActiveDaysResultElementFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedActiveDaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonGroupNumberPatientsResultElementFactory CreateSurgeonGroupNumberPatientsResultElementFactory()
        {
            ISurgeonGroupNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITPxResultElementFactory CreateTPxResultElementFactory()
        {
            ITPxResultElementFactory factory = null;

            try
            {
                factory = new TPxResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITPyResultElementFactory CreateTPyResultElementFactory()
        {
            ITPyResultElementFactory factory = null;

            try
            {
                factory = new TPyResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITPzResultElementFactory CreateTPzResultElementFactory()
        {
            ITPzResultElementFactory factory = null;

            try
            {
                factory = new TPzResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances.IVarianceResultElementFactory CreateVariancewResultElementFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances.IVarianceResultElementFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.ResultElements.TP.WardBedOccupancyVariances.VarianceResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances.IVarianceResultElementFactory CreateVariancewdResultElementFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances.IVarianceResultElementFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedRequirementVariances.VarianceResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWardNumberAssignedOperatingRoomsResultElementFactory CreateWardNumberAssignedOperatingRoomsResultElementFactory()
        {
            IWardNumberAssignedOperatingRoomsResultElementFactory factory = null;

            try
            {
                factory = new WardNumberAssignedOperatingRoomsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWardNumberAssignedActiveDaysResultElementFactory CreateWardNumberAssignedActiveDaysResultElementFactory()
        {
            IWardNumberAssignedActiveDaysResultElementFactory factory = null;

            try
            {
                factory = new WardNumberAssignedActiveDaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IδMinusResultElementFactory CreateδMinusResultElementFactory()
        {
            IδMinusResultElementFactory factory = null;

            try
            {
                factory = new δMinusResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds.IδPlusResultElementFactory CreateδPluswResultElementFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds.IδPlusResultElementFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.ResultElements.TP.WardSpareBeds.δPlusResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations.IδPlusResultElementFactory CreateδPluswdResultElementFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations.IδPlusResultElementFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedAvailabilityDeviations.δPlusResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμResultElementFactory CreateμResultElementFactory()
        {
            IμResultElementFactory factory = null;

            try
            {
                factory = new μResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}