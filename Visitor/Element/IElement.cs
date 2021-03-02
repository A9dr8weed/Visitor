namespace Visitor
{
    /// <summary>
    /// The Element interface. All this does is define an Accept operation,
    /// which needs to be implemented by any class that can be visited.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// An 'accept' method that should take the base visitor interface as an argument.
        /// </summary>
        /// <param name="visitor"> Base visitor. </param>
        void Accept(IVisitor visitor);
    }
}