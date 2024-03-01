using OnlineSurvey.Domain.Entities;

namespace OnlineSurvey.Infrastructure.Repositories.Interfaces
{
    public interface IAnswerRepository
    {
        Task<Answer> GetAsync(long id);
    }
}