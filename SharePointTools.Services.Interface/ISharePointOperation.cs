using System.Collections.Generic;
using SharePointTools.Domain;

namespace SharePointTools.Services.Interface
{
    public interface ISharePointOperation
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(string condition);
    }
}
