using EduCore.BackEnd.Application.DTOs;

namespace EduCore.Web.Services
{
    public interface IAIService
    {
        public Task<double> EvaluateAnswer();

    }
}
