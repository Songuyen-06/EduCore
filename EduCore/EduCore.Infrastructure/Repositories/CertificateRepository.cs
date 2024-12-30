using EduCore.Domain;
using EduCore.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Repositories
{
    internal class CertificateRepository : GenericRepository<Certificate>, ICertificateRepositoty
    {
        public CertificateRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<Certificate>> GetListCertificate()
        {
            throw new NotImplementedException();
        }
    }
}
