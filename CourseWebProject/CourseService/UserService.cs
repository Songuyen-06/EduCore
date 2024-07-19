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
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<UserDTO>> GetListUser()
        {
            var users = await _unitOfWork.UserRepository.GetAll();
            return _mapper.Map<List<UserDTO>>(users);
        }
    }
}
