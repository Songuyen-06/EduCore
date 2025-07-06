using EduCore.BackEnd.Application.DTOs;

﻿

namespace EduCore.Web.Services
{
    public interface ICertificateService
    {
        public Task<List<CertificateDTO>> GetCertificates();
        public Task<int> GetNumberCertificates();

    }
}
