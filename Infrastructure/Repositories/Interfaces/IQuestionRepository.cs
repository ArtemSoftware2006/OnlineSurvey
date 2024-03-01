using OnlineSurvey.Domain.Entities;

namespace OnlineSurvey.Infrastructure.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        Task<Question> GetAsync(long id);
    }
}