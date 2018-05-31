using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcLesson.Models
{
    public class GuestResponse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите своё имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Введите номер кабинета")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Выберите приоритет")]
        public bool? Priority { get; set; }

        [Required(ErrorMessage = "Выберите IT-отдел")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Введите описание проблемы")]
        public string BodyEmail { get; set; }

        

    }
}