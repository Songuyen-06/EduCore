using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Contracts
{
    public  interface ICertificateRepositoty:IGenericRepository<Certificate>
    {
        public Task<IEnumerable<Certificate>> GetListCertificate();
    }
}
