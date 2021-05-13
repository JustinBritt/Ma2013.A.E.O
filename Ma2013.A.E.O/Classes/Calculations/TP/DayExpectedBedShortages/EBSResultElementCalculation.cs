namespace Ma2013.A.E.O.Classes.Calculations.TP.DayExpectedBedShortages
{
    using System;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;

    internal sealed class EBSResultElementCalculation : IEBSResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementCalculation()
        {
        }

        public IEBSResultElement Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IdIndexElement dIndexElement,
            Iw w,
            IBEDS BEDS,
            Iμ μ,
            IVariance Variance)
        {
            int BEDS_d = BEDS.Value.Value.Value;

            double ExpectedValue_d = w.Value
                .Select(y => (double)μ.GetElementAtAsdecimal(
                    y,
                    dIndexElement))
                .Sum();

            double Variance_d = w.Value
                .Select(y => (double)Variance.GetElementAtAsdecimal(
                    y,
                    dIndexElement))
                .Sum();

            double lowerBound = BEDS_d + 0.5;

            double upperBound = double.PositiveInfinity;

            double value =
                0.5
                *
                (BEDS_d - ExpectedValue_d)
                *
                (MathNet.Numerics.SpecialFunctions.Erf(
                    (lowerBound - ExpectedValue_d)
                    *
                    Math.Pow(Math.Sqrt(2 * Variance_d), -1))
                -
                MathNet.Numerics.SpecialFunctions.Erf(
                    (upperBound - ExpectedValue_d)
                    *
                    Math.Pow(Math.Sqrt(2 * Variance_d), -1)))
                +
                Math.Sqrt(Variance_d)
                *
                Math.Pow(Math.Sqrt(2 * Math.PI), -1)
                *
                (Math.Exp(
                    -Math.Pow(lowerBound - ExpectedValue_d, 2)
                    *
                    Math.Pow(2 * Variance_d, -1))
                -
                Math.Exp(
                    -Math.Pow(upperBound - ExpectedValue_d, 2)
                    *
                    Math.Pow(2 * Variance_d, -1)));

            return EBSResultElementFactory.Create(
                dIndexElement,
                (decimal)value);
        }
    }
}