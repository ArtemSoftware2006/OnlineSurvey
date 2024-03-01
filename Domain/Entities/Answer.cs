namespace OnlineSurvey.Domain.Entities
{
    public class Answer
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }

        public Question Question { get; set; }
        public List<Result> Results { get; set; }
    }
}