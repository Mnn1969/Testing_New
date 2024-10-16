using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testing.DAL.Entityes
{
    public class Subject 
    {
        public ICollection<Questions> Questions { get; } = new List<Questions>();

        public int Id { get; set; }

        [DisplayName("Тема")]
        [Required]
        public  string? SubjectName { get; set; }

        [DisplayName("Вопросов по теме")]
        public int QuestionsSubject { get; set; }

        [DisplayName("Доп. вопросы")]
        public int AdditionalQuestions { get; set; }

        [DisplayName("Время")]
        public int TimeTesting { get; set; }

    }
}
