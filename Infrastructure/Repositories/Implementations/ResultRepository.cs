using OnlineSurvey.Domain.Entities;
using OnlineSurvey.Infrastructure.Repositories.Interfaces;

namespace OnlineSurvey.Infrastructure.Repositories.Implementations
{
    public class ResultRepository : IResultRepository
    {
        private readonly SurveyDbContext _context;

        public ResultRepository(SurveyDbContext context) 
        {
            _context = context;
        }
        public async Task CreateAsync(Result result)
        {
            await _context.AddAsync(result);
        }
        public async Task SaveChangesAsync() 
        {
            await _context.SaveChangesAsync();
        } 
    }
}