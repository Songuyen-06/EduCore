using AutoMapper;
using CourseDomain;
using CourseDomain.Contracts;
using CourseDomain.DTOs;
using Microsoft.EntityFrameworkCore;
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
        public async Task<UserDTO> GetUserById(int userId)
        {
            var user = await _unitOfWork.UserRepository.GetById(userId);
            return _mapper.Map<UserDTO>(user);
        }
        public async Task UpdateUserPartial(int userId, UserDTO userDto)
        {
            var user = await _unitOfWork.UserRepository.GetById(userId);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!string.IsNullOrEmpty(userDto.FullName) && userDto.FullName != "string")
            {
                user.FullName = userDto.FullName;
            }
            if (!string.IsNullOrEmpty(userDto.Email) && userDto.Email != "string")
            {
                user.Email = userDto.Email;
            }
            if (!string.IsNullOrEmpty(userDto.Phone) && userDto.Phone != "string")
            {
                user.Phone = userDto.Phone;
            }
            if (!string.IsNullOrEmpty(userDto.Password) && userDto.Password != "string")
            {
                user.Password = userDto.Password;
            }
            if (!string.IsNullOrEmpty(userDto.Bio) && userDto.Bio != "string")
            {
                user.Bio = userDto.Bio;
            }
            if (!string.IsNullOrEmpty(userDto.UrlImage) && userDto.UrlImage != "string")
            {
                user.UrlImage = userDto.UrlImage;
            }
            if (userDto.RoleId != 0)
            {
                user.RoleId = userDto.RoleId;
            }
            await _unitOfWork.UserRepository.UpdateUser(user);
            await _unitOfWork.Commit();
        }
        public async Task AddUser(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _unitOfWork.UserRepository.Add(user);
            await _unitOfWork.Commit();
        }
        public async Task DeleteUser(int userId)
        {
            var user = await _unitOfWork.UserRepository.GetById(userId);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            try
            {
                _unitOfWork.UserRepository.Remove(user);
                await _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<int> GetTotalUserCount()
        {
            return await _unitOfWork.UserRepository.CountAsync();
        }
    }
}
