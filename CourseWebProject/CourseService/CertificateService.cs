using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public class CertificateService : ICertificateService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;


        public CertificateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CertificateDTO>> GetListCertificate()
        {
            return _mapper.Map<IEnumerable<CertificateDTO>>(await _unitOfWork.CertificateRepositoty.GetAll());
        }
    }
}
