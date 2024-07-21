using CourseDomain;
using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ICertificateService
    {
        public Task<List<CertificateDTO>> GetCertificates();
        public Task<int> GetNumberCertificates();

    }
}
