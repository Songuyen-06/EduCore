
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class CompletionStatusRepository : GenericRepository<CompletionStatus>, ICompletionStatusRepository
    {
        public CompletionStatusRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }

        
    }
}
