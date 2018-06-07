using System.ComponentModel.DataAnnotations;


namespace MvcLesson.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введите имя пользователя")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        public string AdminPassword { get; set; }
    }
}