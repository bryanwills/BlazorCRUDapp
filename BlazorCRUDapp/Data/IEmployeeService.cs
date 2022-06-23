using System.Collections.Generic;

namespace BlazorCRUDapp.Data
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();

    }
}
