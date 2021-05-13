namespace Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;

    public interface ILB
    {
        ImmutableList<ILBParameterElement> Value { get; }

        int GetElementAtAsint(
            IpIndexElement pIndexElement);
    }
}