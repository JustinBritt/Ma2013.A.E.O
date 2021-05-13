namespace Ma2013.A.E.O.Classes.ConstraintElements.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;

    internal sealed class Constraints3ConstraintElement : IConstraints3ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Ipa pa,
            IA A,
            IP P,
            ISPx x,
            ISPy y)
        {
            Expression LHS = Expression.Sum(
                pa.Value
                .Where(
                    i => 
                    P.IsThereElementAt(
                        wIndexElement,
                        i.pIndexElement) 
                    &&
                    A.IsThereElementAt(
                        i.pIndexElement,
                        dIndexElement,
                        i.aIndexElement))
                .Select(
                   i => x.Value[i.pIndexElement, i.aIndexElement]));

            Expression RHS = y.Value[wIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}