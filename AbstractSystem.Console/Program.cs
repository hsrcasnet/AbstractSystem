namespace AbstractSystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessManager = new BusinessManager();
            var salaryPaidYtd = businessManager.GetSalaryPaidYtd();

            System.Console.WriteLine($"Salary paid (YTD): {salaryPaidYtd}");
        }
    }
}
