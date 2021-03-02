namespace Visitor
{
    /// <summary>
    /// The ConcreteElement class, which implements all operations defined by the Element.
    /// </summary>
    public class Employee : IElement
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Annual salary.
        /// </summary>
        public double AnnualSalary { get; set; }

        /// <summary>
        /// Paid time off days.
        /// </summary>
        public int PaidTimeOffDays { get; set; }

        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        /// <summary>
        /// Note that we're calling 'VisitConcreteElement', which matches the current class name.
        /// This way we let the visitor know the class of the component it works with.
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
