using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcLesson.Models
{
    public class HelpDeskRequest
    {
        public Guid HelpDeskId { get; set; }

        [Required(ErrorMessage = "Введите своё имя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный Email")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Введите номер телефона")]
        public string UserPhone { get; set; }

        [Required(ErrorMessage = "Введите номер кабинета")]
        public string UserLocation { get; set; }

        [Required(ErrorMessage = "Выберите приоритет заявки")]
        public bool? Priority { get; set; }

        [Required(ErrorMessage = "Выберите IT-отдел")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Введите описание проблемы")]
        public string BodyEmail { get; set; }

        

    }
}