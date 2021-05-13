namespace Ma2013.A.E.O.AbstractFactories
{
    using System;
 
    using log4net;

    using Ma2013.A.E.O.Factories.Results.Common.BestBound;
    using Ma2013.A.E.O.Factories.Results.Common.Gap;
    using Ma2013.A.E.O.Factories.Results.Common.NumberOfExploredNodes;
    using Ma2013.A.E.O.Factories.Results.Common.ObjectiveValue;
    using Ma2013.A.E.O.Factories.Results.Common.OverallWallTime;
    using Ma2013.A.E.O.Factories.Results.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Factories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Factories.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Factories.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Factories.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Factories.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Factories.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Factories.Results.TP.NumberPatients;
    using Ma2013.A.E.O.Factories.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Factories.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.Factories.Results.TP.TotalTime;
    using Ma2013.A.E.O.Factories.Results.TP.Underutilization;
    using Ma2013.A.E.O.Factories.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.Factories.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.Factories.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Factories.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Factories.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Factories.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Factories.Results.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.BestBound;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.Gap;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.Underutilization;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberBedAssignments;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IDayBedRequirementMeansFactory CreateDayBedRequirementMeansFactory()
        {
            IDayBedRequirementMeansFactory factory = null;

            try
            {
                factory = new DayBedRequirementMeansFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IDayBedRequirementVariancesFactory CreateDayBedRequirementVariancesFactory()
        {
            IDayBedRequirementVariancesFactory factory = null;

            try
            {
                factory = new DayBedRequirementVariancesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IEBSFactory CreateEBSFactory()
        {
            IEBSFactory factory = null;

            try
            {
                factory = new EBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public INumberPatientsFactory CreateNumberPatientsFactory()
        {
            INumberPatientsFactory factory = null;

            try
            {
                factory = new NumberPatientsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsFactory CreateSurgeonGroupNumberAssignedOperatingRoomsFactory()
        {
            ISurgeonGroupNumberAssignedOperatingRoomsFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedOperatingRoomsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedActiveDaysFactory CreateSurgeonGroupNumberAssignedActiveDaysFactory()
        {
            ISurgeonGroupNumberAssignedActiveDaysFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedActiveDaysFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonGroupNumberPatientsFactory CreateSurgeonGroupNumberPatientsFactory()
        {
            ISurgeonGroupNumberPatientsFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberPatientsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITEBSFactory CreateTEBSFactory()
        {
            ITEBSFactory factory = null;

            try
            {
                factory = new TEBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITotalFinancialContributionFactory CreateTotalFinancialContributionFactory()
        {
            ITotalFinancialContributionFactory factory = null;

            try
            {
                factory = new TotalFinancialContributionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITotalTimeFactory CreateTotalTimeFactory()
        {
            ITotalTimeFactory factory = null;

            try
            {
                factory = new TotalTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IUnderutilizationFactory CreateUnderutilizationFactory()
        {
            IUnderutilizationFactory factory = null;

            try
            {
                factory = new UnderutilizationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IUnutilizedTimeFactory CreateUnutilizedTimeFactory()
        {
            IUnutilizedTimeFactory factory = null;

            try
            {
                factory = new UnutilizedTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IUtilizedTimeFactory CreateUtilizedTimeFactory()
        {
            IUtilizedTimeFactory factory = null;

            try
            {
                factory = new UtilizedTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances.IVarianceFactory CreateVariancewFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances.IVarianceFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Results.TP.WardBedOccupancyVariances.VarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementVariances.IVarianceFactory CreateVariancewdFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementVariances.IVarianceFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Results.TP.WardDayBedRequirementVariances.VarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWardNumberAssignedOperatingRoomsFactory CreateWardNumberAssignedOperatingRoomsFactory()
        {
            IWardNumberAssignedOperatingRoomsFactory factory = null;

            try
            {
                factory = new WardNumberAssignedOperatingRoomsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWardNumberAssignedActiveDaysFactory CreateWardNumberAssignedActiveDaysFactory()
        {
            IWardNumberAssignedActiveDaysFactory factory = null;

            try
            {
                factory = new WardNumberAssignedActiveDaysFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds.IδPlusFactory CreateδPluswFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds.IδPlusFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Results.TP.WardSpareBeds.δPlusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations.IδPlusFactory CreateδPluswdFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations.IδPlusFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Results.TP.WardDayBedAvailabilityDeviations.δPlusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}