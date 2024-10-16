using System.ComponentModel;
using Testing.DAL.Entityes.Base;

namespace Testing.DAL.Entityes
{
    public class Questions
    {
        private ICollection<Answers>? Answers { get; set; }

        
        public int Id { get; private set; }

        public int SubjectId { get; private set; }


        [DisplayName("? по теме")]
        public string? QuestionsSubject { get; private set; }

        [DisplayName("Вопрос")]
        public string? Question { get; private set; }
    }
}
