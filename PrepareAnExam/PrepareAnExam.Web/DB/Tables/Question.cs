namespace PrepareAnExam.Web.DB.Tables
{
    public class Question
    {

        public int Id { get; set; }
        public string Detail { get; set; }

        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Answer { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
