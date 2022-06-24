namespace BlazorCRUDapp.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Employee 1"
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Employee 2"
            }
         };

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
