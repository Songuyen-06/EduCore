using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Contracts
{
    public interface IInstructorRepository : IGenericRepository<User>
    {
        public IQueryable<User> GetListInstructor();
    }
}
