using System.ComponentModel;

namespace Testing.DAL.Entityes
{
    public class Answers : Questions
    {
        [DisplayName("Правельный =1")]
        public int Correct { get; private set; }

        [DisplayName("Ответы")]
        public string? Answer { get; private set; }
    }
}
