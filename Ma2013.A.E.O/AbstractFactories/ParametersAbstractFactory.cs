namespace Ma2013.A.E.O.AbstractFactories
{
    using System;
 
    using log4net;

    using Ma2013.A.E.O.Factories.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Factories.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Factories.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Factories.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Factories.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.Factories.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Factories.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Factories.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.Factories.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Factories.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Factories.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Factories.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Factories.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardPatientGroupActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IAFactory CreateAFactory()
        {
            IAFactory factory = null;

            try
            {
                factory = new AFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBEDSFactory CreateBEDSFactory()
        {
            IBEDSFactory factory = null;

            try
            {
                factory = new BEDSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBLOCKSFactory CreateBLOCKSFactory()
        {
            IBLOCKSFactory factory = null;

            try
            {
                factory = new BLOCKSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IdurFactory CreatedurFactory()
        {
            IdurFactory factory = null;

            try
            {
                factory = new durFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILENGTHFactory CreateLENGTHFactory()
        {
            ILENGTHFactory factory = null;

            try
            {
                factory = new LENGTHFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILengthFactory CreateLengthFactory()
        {
            ILengthFactory factory = null;

            try
            {
                factory = new LengthFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILBFactory CreateLBFactory()
        {
            ILBFactory factory = null;

            try
            {
                factory = new LBFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IORdayFactory CreateORdayFactory()
        {
            IORdayFactory factory = null;

            try
            {
                factory = new ORdayFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups.IPFactory CreatePsFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups.IPFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Parameters.Common.SurgeonGroupSubsetPatientGroups.PFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups.IPFactory CreatePwFactory()
        {
            Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups.IPFactory factory = null;

            try
            {
                factory = new Ma2013.A.E.O.Factories.Parameters.Common.WardSubsetPatientGroups.PFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IprobFactory CreateprobFactory()
        {
            IprobFactory factory = null;

            try
            {
                factory = new probFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrFactory CreaterFactory()
        {
            IrFactory factory = null;

            try
            {
                factory = new rFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITHRFactory CreateTHRFactory()
        {
            ITHRFactory factory = null;

            try
            {
                factory = new THRFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUBFactory CreateUBFactory()
        {
            IUBFactory factory = null;

            try
            {
                factory = new UBFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWFactory CreateWFactory()
        {
            IWFactory factory = null;

            try
            {
                factory = new WFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IwpaFactory CreatewpaFactory()
        {
            IwpaFactory factory = null;

            try
            {
                factory = new wpaFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IαFactory CreateαFactory()
        {
            IαFactory factory = null;

            try
            {
                factory = new αFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IβFactory CreateβFactory()
        {
            IβFactory factory = null;

            try
            {
                factory = new βFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IγFactory CreateγFactory()
        {
            IγFactory factory = null;

            try
            {
                factory = new γFactory();
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