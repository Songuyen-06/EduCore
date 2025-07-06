
using EduCore.BackEnd.Domain.Entities;
﻿using System;

namespace EduCore.BackEnd.Domain.Contracts
{
    public  interface ICertificateRepositoty:IGenericRepository<Certificate>
    {
        public Task<IEnumerable<Certificate>> GetListCertificate();
    }
}
