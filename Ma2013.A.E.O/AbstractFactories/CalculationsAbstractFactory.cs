namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Calculations.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Factories.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Factories.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Factories.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Factories.Calculations.TP.NumberPatients;
    using Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Factories.Calculations.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.Factories.Calculations.TP.TotalTime;
    using Ma2013.A.E.O.Factories.Calculations.TP.Underutilization;
    using Ma2013.A.E.O.Factories.Calculations.TP.UnutilizedTime;
    using Ma2013.A.E.O.Factories.Calculations.TP.UtilizedTime;
    using Ma2013.A.E.O.Factories.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Factories.Calculations.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.Underutilization;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedActiveDays;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public IDayBedRequirementMeansCalculationFactory CreateDayBedRequirementMeansCalculationFactory()
        {
            IDayBedRequirementMeansCalculationFactory factory = null;

            try
            {
                factory = new DayBedRequirementMeansCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDayBedRequirementMeansResultElementCalculationFactory CreateDayBedRequirementMeansResultElementCalculationFactory()
        {
            IDayBedRequirementMeansResultElementCalculationFactory factory = null;

            try
            {
                factory = new DayBedRequirementMeansResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDayBedRequirementVariancesCalculationFactory CreateDayBedRequirementVariancesCalculationFactory()
        {
            IDayBedRequirementVariancesCalculationFactory factory = null;

            try
            {
                factory = new DayBedRequirementVariancesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDayBedRequirementVariancesResultElementCalculationFactory CreateDayBedRequirementVariancesResultElementCalculationFactory()
        {
            IDayBedRequirementVariancesResultElementCalculationFactory factory = null;

            try
            {
                factory = new DayBedRequirementVariancesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IEBSCalculationFactory CreateEBSCalculationFactory()
        {
            IEBSCalculationFactory factory = null;

            try
            {
                factory = new EBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory()
        {
            IEBSResultElementCalculationFactory factory = null;

            try
            {
                factory = new EBSResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INumberPatientsCalculationFactory CreateNumberPatientsCalculationFactory()
        {
            INumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new NumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonGroupNumberAssignedOperatingRoomsCalculationFactory()
        {
            ISurgeonGroupNumberAssignedOperatingRoomsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedOperatingRoomsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedActiveDaysCalculationFactory CreateSurgeonGroupNumberAssignedActiveDaysCalculationFactory()
        {
            ISurgeonGroupNumberAssignedActiveDaysCalculationFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedActiveDaysCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory CreateSurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory()
        {
            ISurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonGroupNumberPatientsCalculationFactory CreateSurgeonGroupNumberPatientsCalculationFactory()
        {
            ISurgeonGroupNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonGroupNumberPatientsResultElementCalculationFactory CreateSurgeonGroupNumberPatientsResultElementCalculationFactory()
        {
            ISurgeonGroupNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonGroupNumberPatientsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITEBSCalculationFactory CreateTEBSCalculationFactory()
        {
            ITEBSCalculationFactory factory = null;

            try
            {
                factory = new TEBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITotalFinancialContributionCalculationFactory CreateTotalFinancialContributionCalculationFactory()
        {
            ITotalFinancialContributionCalculationFactory factory = null;

            try
            {
                factory = new TotalFinancialContributionCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITotalTimeCalculationFactory CreateTotalTimeCalculationFactory()
        {
            ITotalTimeCalculationFactory factory = null;

            try
            {
                factory = new TotalTimeCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUnderutilizationCalculationFactory CreateUnderutilizationCalculationFactory()
        {
            IUnderutilizationCalculationFactory factory = null;

            try
            {
                factory = new UnderutilizationCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUnutilizedTimeCalculationFactory CreateUnutilizedTimeCalculationFactory()
        {
            IUnutilizedTimeCalculationFactory factory = null;

            try
            {
                factory = new UnutilizedTimeCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUtilizedTimeCalculationFactory CreateUtilizedTimeCalculationFactory()
        {
            IUtilizedTimeCalculationFactory factory = null;

            try
            {
                factory = new UtilizedTimeCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWardNumberAssignedOperatingRoomsCalculationFactory CreateWardNumberAssignedOperatingRoomsCalculationFactory()
        {
            IWardNumberAssignedOperatingRoomsCalculationFactory factory = null;

            try
            {
                factory = new WardNumberAssignedOperatingRoomsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWardNumberAssignedOperatingRoomsResultElementCalculationFactory CreateWardNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
            IWardNumberAssignedOperatingRoomsResultElementCalculationFactory factory = null;

            try
            {
                factory = new WardNumberAssignedOperatingRoomsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWardNumberAssignedActiveDaysCalculationFactory CreateWardNumberAssignedActiveDaysCalculationFactory()
        {
            IWardNumberAssignedActiveDaysCalculationFactory factory = null;

            try
            {
                factory = new WardNumberAssignedActiveDaysCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWardNumberAssignedActiveDaysResultElementCalculationFactory CreateWardNumberAssignedActiveDaysResultElementCalculationFactory()
        {
            IWardNumberAssignedActiveDaysResultElementCalculationFactory factory = null;

            try
            {
                factory = new WardNumberAssignedActiveDaysResultElementCalculationFactory();
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