using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Testing.DAL.Entityes
{
    public class Answers
    {
        [Required]
        public Questions? Questions { get; set; }

        public int Id { get; set; }

        [DisplayName("Правельный = True")]
        [Required]
        public bool  Correct { get; set; }
        
        [DisplayName("Ответы")]
        [Required]
        public string? Answer { get; set; }


    }
}
