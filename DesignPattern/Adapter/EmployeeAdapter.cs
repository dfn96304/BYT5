// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employeesList = new();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                // error handling?
                int ID = Convert.ToInt32(employeesArray[i, 0]);
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                decimal salary = Convert.ToDecimal(employeesArray[i, 3]);

                employeesList.Add(new Employee(ID, name, designation, salary));
            }
            thirdPartyBillingSystem.ProcessSalary(employeesList);
        }
    }
}
