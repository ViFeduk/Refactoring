namespace Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount salaryAccount = new SalaryAccount
            {
                Balance = 2000
            };
            Calculator.CalculatorInstance(salaryAccount);
            Console.WriteLine($"Salary Account: Balance = {salaryAccount.Balance}, Interest = {salaryAccount.Interest}");

            IAccount simpleAccount = new SimpleAccount
            {
                Balance = 2000
            };
            Calculator.CalculatorInstance(simpleAccount);
            Console.WriteLine($"Regular Account: Balance = {simpleAccount.Balance}, Interest = {simpleAccount.Interest}");
        }
    }
}
