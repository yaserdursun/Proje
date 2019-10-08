using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepareAnExam.Web.DB.Tables
{
    public class Exam
    {
        public Exam()
        {
            Questions = new List<Question>();


        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Created { get; set; }
        public bool Deleted { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
