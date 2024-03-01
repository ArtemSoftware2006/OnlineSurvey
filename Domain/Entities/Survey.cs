namespace OnlineSurvey.Domain.Entities
{
    public class Survey
    {
        public long Id { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Question> Questions { get; set; }
        public List<Interview> Interviews { get; set; }
    }
}