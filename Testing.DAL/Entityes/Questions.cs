using System.ComponentModel;

namespace Testing.DAL.Entityes
{
    public class Questions
    {
        public ICollection<Answers> Answers { get; } = new List<Answers>();

        public int Id { get; set; }

        [DisplayName("? по теме")] 
        public bool QuestionsSubject { get; set; }

        [DisplayName("Вопрос")] 
        public string? Question { get; set; }

        public Subject? Subject { get; set; }
    }
}
