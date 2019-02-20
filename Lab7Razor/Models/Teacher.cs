using System.ComponentModel.DataAnnotations;

namespace Lab7Razor.Models
{
    public class Teacher
    {
        [Required(ErrorMessage = "Введите имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Введите предмет")]
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}