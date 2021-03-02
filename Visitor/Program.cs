namespace Visitor
{
    public static class Program
    {
        private static void Main()
        {
            Employees employee = new Employees();
            employee.Attach(new LineCook());
            employee.Attach(new HeadChef());
            employee.Attach(new GeneralManager());

            employee.Accept(new IncomeVisitor());
            employee.Accept(new PaidTimeOffVisitor());
        }
    }
}