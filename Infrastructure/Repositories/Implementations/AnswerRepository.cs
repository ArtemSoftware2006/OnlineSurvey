using Microsoft.EntityFrameworkCore;
using OnlineSurvey.Domain.Entities;
using OnlineSurvey.Infrastructure.Repositories.Interfaces;

namespace OnlineSurvey.Infrastructure.Repositories.Implementations
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly SurveyDbContext _context;

        public AnswerRepository(SurveyDbContext context)
        {   
            _context = context;
        }

        public async Task<Answer> GetAsync(long id)
        {
            return await _context.Answers.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}