namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Factories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Factories.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Factories.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Factories.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Factories.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Factories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Factories.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Factories.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.WardObjectiveFunctionWeights;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IAParameterElementFactory CreateAParameterElementFactory()
        {
            IAParameterElementFactory factory = null;

            try
            {
                factory = new AParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IdurParameterElementFactory CreatedurParameterElementFactory()
        {
            IdurParameterElementFactory factory = null;

            try
            {
                factory = new durParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ILengthParameterElementFactory CreateLengthParameterElementFactory()
        {
            ILengthParameterElementFactory factory = null;

            try
            {
                factory = new LengthParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ILBParameterElementFactory CreateLBParameterElementFactory()
        {
            ILBParameterElementFactory factory = null;

            try
            {
                factory = new LBParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IORdayParameterElementFactory CreateORdayParameterElementFactory()
        {
            IORdayParameterElementFactory factory = null;

            try
            {
                factory = new ORdayParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups.IPParameterElementFactory CreatePsParameterElementFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups.IPParameterElementFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups.PParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups.IPParameterElementFactory CreatePwParameterElementFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups.IPParameterElementFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.ParameterElements.Common.WardSubsetPatientGroups.PParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IprobParameterElementFactory CreateprobParameterElementFactory()
        {
            IprobParameterElementFactory factory = null;

            try
            {
                factory = new probParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrParameterElementFactory CreaterParameterElementFactory()
        {
            IrParameterElementFactory factory = null;

            try
            {
                factory = new rParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITHRParameterElementFactory CreateTHRParameterElementFactory()
        {
            ITHRParameterElementFactory factory = null;

            try
            {
                factory = new THRParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IUBParameterElementFactory CreateUBParameterElementFactory()
        {
            IUBParameterElementFactory factory = null;

            try
            {
                factory = new UBParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWParameterElementFactory CreateWParameterElementFactory()
        {
            IWParameterElementFactory factory = null;

            try
            {
                factory = new WParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IαParameterElementFactory CreateαParameterElementFactory()
        {
            IαParameterElementFactory factory = null;

            try
            {
                factory = new αParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IβParameterElementFactory CreateβParameterElementFactory()
        {
            IβParameterElementFactory factory = null;

            try
            {
                factory = new βParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IγParameterElementFactory CreateγParameterElementFactory()
        {
            IγParameterElementFactory factory = null;

            try
            {
                factory = new γParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}