using System;

namespace Visitor
{
    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;

            employee.AnnualSalary *= 1.10;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.AnnualSalary}");
        }
    }
}