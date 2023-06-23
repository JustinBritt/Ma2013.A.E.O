﻿namespace Ma2013.A.E.O.Classes.Comparers
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Comparers;

    internal sealed class OrganizationComparer : IOrganizationComparer
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OrganizationComparer()
        {
        }

        public int Compare(
            Organization x,
            Organization y)
        {
            return String.CompareOrdinal(
                x.Id,
                y.Id);
        }
    }
}