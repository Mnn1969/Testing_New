using System.ComponentModel;
using Testing.DAL.Entityes.Base;

namespace Testing.DAL.Entityes
{
    public class Answers
    {
        public int Id { get; private set; }

        [DisplayName("Правельный =1")]
        public int Correct { get; private set; }
    }
}
