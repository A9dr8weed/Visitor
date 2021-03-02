namespace Visitor
{
    /// <summary>
    /// The Visitor interface, which declares a Visit operation for each ConcreteVisitor to implement.
    /// </summary>
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}