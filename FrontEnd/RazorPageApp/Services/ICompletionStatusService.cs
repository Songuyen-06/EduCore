using EduCore.BackEnd.Application.DTOs;

namespace EduCore.Web.Services
{
    public interface ICompletionStatusService
    {
        public Task<List<CompletionStatusDTO>> GetCompletionStatusListByStudentId(int stdId);
    }
}
