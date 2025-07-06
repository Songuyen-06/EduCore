using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Application.Abstractions.Services;

namespace EduCore.BackEnd.Application.Services
{
    public class CompletionStatusService : ICompletionStatusService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;


        public CompletionStatusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CompletionStatusDTO>> GetAllCompletionStatus()
        {
            return _mapper.Map<List<CompletionStatusDTO>>(await _unitOfWork.CompletionStatusRepository.GetAll());
        }
    }
}
