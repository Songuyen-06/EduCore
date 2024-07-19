using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using CourseDomain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddCourse(PartialCourseDTO cDTO)
        {
            try
            {
                var c = _mapper.Map<Course>(cDTO);

                if (!await _unitOfWork.SubCategoryRepository.IsExistingSubCategory(cDTO.SubCategoryId) && cDTO.SubCategoryId != null)
                {
                    var newSubCategory = new SubCategory { Name = $"SubCategory{cDTO.SubCategoryId}" };
                    _unitOfWork.SubCategoryRepository.Add(newSubCategory);
                    c.SubCategory = newSubCategory;
                }

                if (!await _unitOfWork.UserRepository.IsExistingUser(cDTO.InstructorId) && cDTO.InstructorId != null)
                {
                    var newInstructor = new User { Email = $"user{cDTO.InstructorId}@gmail.com", Password = "123" };
                    _unitOfWork.UserRepository.Add(newInstructor);
                    c.Instructor = newInstructor;
                }

                _unitOfWork.CourseRepository.Add(c);
                await _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception("Failed to add course.", ex);
            }
        }

        public async Task UpdateCourse(PartialCourseDTO cDTO, int courseId)
        {

            try
            {
                if (await _unitOfWork.CourseRepository.IsExistingCourse(courseId))
                {

                    var c = _mapper.Map<Course>(cDTO);
                    c.CourseId = courseId;

                    if (!await _unitOfWork.SubCategoryRepository.IsExistingSubCategory(cDTO.SubCategoryId) && cDTO.SubCategoryId != null)
                    {
                        var newSubCategory = new SubCategory { Name = $"SubCategory{cDTO.SubCategoryId}" };
                        _unitOfWork.SubCategoryRepository.Add(newSubCategory);
                        c.SubCategory = newSubCategory;
                    }

                    if (!await _unitOfWork.UserRepository.IsExistingUser(cDTO.InstructorId) && cDTO.InstructorId != null)
                    {
                        var newInstructor = new User { Email = $"user{cDTO.InstructorId}@gmail.com", Password = "123" };
                        _unitOfWork.UserRepository.Add(newInstructor);
                        c.Instructor = newInstructor;
                    }                
                    _unitOfWork.CourseRepository.Update(c);
                    await _unitOfWork.Commit();
                }
            }

            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception("Failed to update course.", ex);
            }

        }

        public async Task DeleteCourse(Course course)
        {
            _unitOfWork.CourseRepository.Remove(course);
            await _unitOfWork.Commit();
        }
        public async Task<List<CourseDTO>> GetListCourseByCategoryId(int cateId)
        {
            return _mapper.Map<List<CourseDTO>>(await _unitOfWork.CourseRepository.GetListCourseByCategoryId(cateId));
        }
        public async Task<List<CourseDTO>> GetListCourseBySubCategoryId(int subCateId)
        {
            return _mapper.Map<List<CourseDTO>>(await _unitOfWork.CourseRepository.GetListCourseBySubCategoryId(subCateId));
        }
        public async Task<CourseDTO> GetCourseByCourseId(int courseId)
        {
            return _mapper.Map<CourseDTO>(await _unitOfWork.CourseRepository.GetCourseByCourseId(courseId));
        }

        public async Task<List<CourseDTO>> GetListCourseByStudentId(int stdId, bool isInCart)
        {
            return _mapper.Map<List<CourseDTO>>(await _unitOfWork.CourseRepository.GetListCourseByStudentId(stdId, isInCart));
        }


        public async Task<List<CourseDTO>> GetListCourse()
        {
            return _mapper.Map<List<CourseDTO>>(await _unitOfWork.CourseRepository.GetListCourseByInclude().ToListAsync());
        }





        public async Task AddStudentCourse(StudentCourseDTO scDTO)
        {
            var sc = _mapper.Map<StudentCourse>(scDTO);
            if (await _unitOfWork.StudentCourseRepository.Get(sc => sc.UserId == scDTO.UserId && sc.CourseId == scDTO.CourseId) == null)
            {
                _unitOfWork.StudentCourseRepository.Add(sc);
                await _unitOfWork.Commit();

            }
        }

      

        public async Task<List<CourseDTO>> GetTopSellingCourses()
        {
            return _mapper.Map<List<CourseDTO>>( await _unitOfWork.CourseRepository.GetTopSellingCourses().ToListAsync());
        }
        public async Task<List<CourseDTO>> GetTopSellingCoursesByCateId(int cateId)
        {
            return _mapper.Map<List<CourseDTO>>(await _unitOfWork.CourseRepository.GetListCourseByCategoryId(cateId));
        }

       
    }
}
