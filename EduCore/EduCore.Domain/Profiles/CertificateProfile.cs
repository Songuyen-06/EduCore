using AutoMapper;
using EduCore.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Profiles
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<Certificate, CertificateDTO>()
                .ForMember(dest => dest.CertificateId, opt => opt.MapFrom(opt => opt.CertificateId))
                             .ForMember(dest => dest.Title, opt => opt.MapFrom(opt => opt.Title))
                          .ForMember(dest => dest.Description, opt => opt.MapFrom(opt => opt.Description))
                             .ForMember(dest => dest.IssuedBy, opt => opt.MapFrom(opt => opt.IssuedBy))
                          .ForMember(dest => dest.CertificateUrl, opt => opt.MapFrom(opt => opt.CertificateUrl))

                          .ReverseMap();

            CreateMap<Certificate, CertificateDetailDTO>()
                .IncludeBase<Certificate, CertificateDTO>()
               .ForMember(dest => dest.CompletionDate, opt => opt.MapFrom(opt => opt.StudentCertificates.FirstOrDefault(st=>st.CertificateId==opt.CertificateId).CompletionDate))
               .ForMember(dest => dest.CompletionTime, opt => opt.MapFrom(opt => opt.StudentCertificates.FirstOrDefault(st => st.CertificateId == opt.CertificateId).CompletionTime))
                      .ReverseMap();
        }
    }
}
