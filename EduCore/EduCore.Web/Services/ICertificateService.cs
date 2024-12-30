using EduCore.Domain;
using EduCore.Domain.DTOs;

namespace EduCore.Web.Services
{
    public interface ICertificateService
    {
        public Task<List<CertificateDTO>> GetCertificates();
        public Task<int> GetNumberCertificates();

    }
}
