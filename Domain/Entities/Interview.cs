namespace OnlineSurvey.Domain.Entities
{
    public class Interview
    {
        public long Id { get; set; }
        public long SurveyId { get; set; }
        public string ParticipantName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Survey Survey { get; set; }
        public List<Result> Results { get; set; }
    }
}