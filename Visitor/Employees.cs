using System;
using System.Collections.Generic;

namespace Visitor
{
    /// <summary>
    /// The Object Structure class, which is a collection of ConcreteElements.
    /// This could be implemented using another pattern such as Composite.
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// Collection of employees.
        /// </summary>
        private readonly List<Employee> _employees = new List<Employee>();

        /// <summary>
        /// Add employee.
        /// </summary>
        /// <param name="employee"> Added employee. </param>
        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        /// <summary>
        /// Remove employee.
        /// </summary>
        /// <param name="employee"> Removed employee. </param>
        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        /// <summary>
        /// The accept operation directs a call to the appropriate operation in the visitor object.
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            foreach (IElement employee in _employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}