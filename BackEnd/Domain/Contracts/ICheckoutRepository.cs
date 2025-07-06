
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Contracts
{
    public interface ICheckoutRepository : IGenericRepository<StudentCheckout>
    {
        public IQueryable<StudentCheckout > GetListCheckoutByInclude();

    }
}
