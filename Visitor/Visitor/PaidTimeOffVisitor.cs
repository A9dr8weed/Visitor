using System;

namespace Visitor
{
    public class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;

            employee.PaidTimeOffDays += 3;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.PaidTimeOffDays}");
        }
    }
}