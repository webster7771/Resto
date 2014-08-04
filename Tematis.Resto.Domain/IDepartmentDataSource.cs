using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tematis.Resto.Domain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Department> Departments { get; }
        IQueryable<Employee> Employees { get; }
    }
}