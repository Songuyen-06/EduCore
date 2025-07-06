using EduCore.BackEnd.Application.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Abstractions.Services
{
    public  interface IInstructorService
    {
        public Task<IEnumerable<InstructorDTO>> GetListInstructor();
        public Task<InstructorDetailDTO> GetInstructorDetailById(int instructorId);

    }
}
