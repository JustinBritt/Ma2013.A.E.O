﻿namespace Ma2013.A.E.O.Classes.Contexts.SP
{
    using System;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.Models.SP;

    internal sealed class SPOutputContext : ISPOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISPModel SPModel,
            Solution solution)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // TotalFinancialContribution
            this.TotalFinancialContribution = calculationsAbstractFactory.CreateTotalFinancialContributionCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateTotalFinancialContributionFactory(),
                SPModel.pa,
                SPModel.r,
                SPModel.x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // x(p, a)
            this.PatientGroupActiveDayNumberPatientAssignments = SPModel.x.GetElementsAt(
                resultElementsAbstractFactory.CreateSPxResultElementFactory(),
                resultsAbstractFactory.CreateSPxFactory(),
                SPModel.pa)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                SPModel.a,
                SPModel.p);

            // y(w)
            this.WardNumberBedAssignments = SPModel.y.GetElementsAt(
                resultElementsAbstractFactory.CreateSPyResultElementFactory(),
                resultsAbstractFactory.CreateSPyFactory(),
                SPModel.w)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // z(s, a)
            this.SurgeonGroupActiveDayNumberBlockAssignments = SPModel.z.GetElementsAt(
                resultElementsAbstractFactory.CreateSPzResultElementFactory(),
                resultsAbstractFactory.CreateSPzFactory(),
                SPModel.sa)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                SPModel.a,
                SPModel.s);
        }

        public INullableValue<decimal> BestBound { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public INullableValue<decimal> TotalFinancialContribution { get; }

        public RedBlackTree<INullableValue<int>, RedBlackTree<FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        public RedBlackTree<Organization, INullableValue<int>> WardNumberBedAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<int>>> SurgeonGroupActiveDayNumberBlockAssignments { get; }
    }
}