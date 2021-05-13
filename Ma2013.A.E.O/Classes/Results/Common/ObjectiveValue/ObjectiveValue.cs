﻿namespace Ma2013.A.E.O.Classes.Results.Common.ObjectiveValue
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Results.Common.ObjectiveValue;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ObjectiveValue : IObjectiveValue
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveValue(
            decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; }

        public INullableValue<decimal> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return nullableValueFactory.Create<decimal>(
                this.Value);
        }
    }
}