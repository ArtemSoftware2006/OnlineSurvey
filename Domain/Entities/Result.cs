namespace OnlineSurvey.Domain.Entities
{
    public class Result
    {
        public long Id { get; set; }
        public long InterviewId { get; set; }
        public long QuestionId { get; set; }
        public long AnswerId { get; set; }

        public Interview Interview { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
    }
}