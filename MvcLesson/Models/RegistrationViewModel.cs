using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcLesson.Models
{
    public class RegistrationViewModel
    {
        public int? UserId { get; set; }

        [Required(ErrorMessage = "Введите имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Некорректный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "Повторите пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string UserConfirmPassword { get; set; }

        [Required(ErrorMessage = "Выберите IT-отдел")]
        public string DepartmentId { get; set; }
    }
}