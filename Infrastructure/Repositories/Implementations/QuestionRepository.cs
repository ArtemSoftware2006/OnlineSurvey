using Microsoft.EntityFrameworkCore;
using OnlineSurvey.Domain.Entities;
using OnlineSurvey.Infrastructure.Repositories.Interfaces;

namespace OnlineSurvey.Infrastructure.Repositories.Implementations
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly SurveyDbContext _context;
        public QuestionRepository(SurveyDbContext context)
        {
            _context = context;
        }
        public async Task<Question> GetAsync(long id)
        {
            return await _context.Questions
                .Include(x => x.Answers)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}