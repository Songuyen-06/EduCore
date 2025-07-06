using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Application.Abstractions.Services;

namespace EduCore.BackEnd.Application.Services
{
    public class SectionService : ISectionService
    {
        public SectionService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper=mapper;

        }

        public IUnitOfWork _unitOfWork { get; set; }
        public IMapper _mapper { get; set; }

        public async Task<List<SectionDTO>> GetListSectionByCourseId(int courseId)
        {
            var sections = await _unitOfWork.SectionRepository.GetListSectionByCourseId(courseId);
            return _mapper.Map<List<SectionDTO>>(sections);
        }
       
    }
}
