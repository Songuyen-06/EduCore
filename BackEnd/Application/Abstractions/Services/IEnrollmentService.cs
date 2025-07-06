using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Abstractions.Services
{
    public interface IEnrollmentService
    {
        public Task AddEnrollment(EnrollmentDTO e);
        public  Task<List<EnrollmentDetailDTO>> GetListEnrollment();
        //public Task<List<RevenueDTO>> GetMonthlyRevenueByInstructorId(int revenueSharePercentage, int instructorId, int year);
        //public Task<List<RevenueDTO>> GetMonthlyRevenueBySoldedCourses(int revenueSharePercentage, int year);

    }
}
