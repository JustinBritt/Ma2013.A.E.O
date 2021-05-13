﻿namespace Ma2013.A.E.O.Classes.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;

    internal sealed class SPxResultElement : ISPxResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxResultElement(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            int value)
        {
            this.pIndexElement = pIndexElement;

            this.aIndexElement = aIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public IaIndexElement aIndexElement { get; }

        public int Value { get; }
    }
}