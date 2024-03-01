using OnlineSurvey.Domain.Entities;

namespace OnlineSurvey.Infrastructure.Repositories.Interfaces
{
    public interface IResultRepository 
    {
        Task CreateAsync(Result result);
    }
}