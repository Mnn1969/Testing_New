using System.ComponentModel;

namespace Testing.DAL.Entityes
{
    public class Questions : Subject
    {
        public ICollection<Answers>? Answers { get; set; }

        [DisplayName("? по теме")]
        public new string? QuestionsSubject { get; private set; }

        [DisplayName("Вопрос")]
        public string? Question { get;  private set; }
    }
}
