using System.ComponentModel;
using Testing.DAL.Entityes.Base;

namespace Testing.DAL.Entityes
{
    public class Subject : NamedEntity
    {
        public ICollection<Questions>? Questions { get; private set; }

        [DisplayName("Тема")]
        public string? SubjectName { get; private set; }

        [DisplayName("Вопросов по теме")]
        public int QuestionsSubject { get; private set; }

        [DisplayName("Доп. вопросы")]
        public int AdditionalQuestions { get; private set; }

        [DisplayName("Время")]
        public int TimeTesting { get; private set; }

    }
}
