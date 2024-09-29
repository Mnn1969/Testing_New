using System.ComponentModel;
using Testing.DAL.Entityes.Base;

namespace Testing.DAL.Entityes
{
    public class Subject : NamedEntity
    {
        public ICollection<Questions>? Questions { get; set; }

        [DisplayName("Тема")]
        public string? SubjectName { get; set; }

        [DisplayName("Вопросов по теме")]
        public int QuestionsSubject { get; set; }

        [DisplayName("Доп. вопросы")]
        public int AdditionalQuestions { get; set; }

        [DisplayName("Время")]
        public int TimeTesting { get; set; }

    }
}
