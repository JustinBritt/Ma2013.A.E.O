﻿namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using System;

    using Hl7.Fhir.Model;

    public interface IsIndexElement : IComparable<IsIndexElement>
    {
        /// <summary>
        /// Gets the surgeon group.
        /// </summary>
        Organization Value { get; }
    }
}