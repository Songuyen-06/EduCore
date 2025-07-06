using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Persistence;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories

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
