using CleanArchitecture.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearArchitecture.Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Employee>>
    {
    }
}
