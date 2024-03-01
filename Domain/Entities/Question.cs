namespace OnlineSurvey.Domain.Entities
{
    public class Question
    {
        public long Id { get; set; }
        public long SurveyId { get; set; }
        public string Text { get; set; }
        //TODO добавить enum
        public string Type { get; set; }

        public Survey Survey { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Result> Results { get; set; }
    }
}