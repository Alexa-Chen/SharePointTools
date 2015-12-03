using System.Collections.Generic;
using SharePointTools.Services;

namespace SharePointTools.IServices
{
    public interface ISharePointOperation
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(string condition);
    }
}
