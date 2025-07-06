using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Abstractions.Services
{
    public interface ICertificateService
    {
        public Task<IEnumerable<CertificateDTO>> GetListCertificate();

    }
}
