using AutoMapper;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Abstractions.Services
{
    public  class InstructorService:IInstructorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InstructorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InstructorDetailDTO> GetInstructorDetailById(int instructorId)
        {
            return _mapper.Map<InstructorDetailDTO>(await _unitOfWork.InstructorRepository.GetInstructorDetailById(instructorId));
        }

        public async Task<IEnumerable<InstructorDTO>> GetListInstructor()
        {
            return _mapper.Map<IEnumerable<InstructorDTO>>(await _unitOfWork.InstructorRepository.GetListInstructor().ToListAsync());
        }
      

    }
}
