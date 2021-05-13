namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    public interface IConstraints4ConstraintElementFactory
    {
        IConstraints4ConstraintElement Create(
            IaIndexElement aIndexElement,
            Is s,
            IBLOCKS BLOCKS,
            ISPz z);
    }
}