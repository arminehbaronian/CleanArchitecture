using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        //custom operations here
        Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname);
    }
}
