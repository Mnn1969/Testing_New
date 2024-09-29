using System.ComponentModel;

namespace Testing.DAL.Entityes
{
    public class Questions : Subject
    {
        public ICollection<Answers> Answers { get; set; }

        [DisplayName("? по теме")]
        public string? QuestionsSubject { get; set; }

        [DisplayName("Вопрос")]
        public string? Question { get; set; }
    }
}
