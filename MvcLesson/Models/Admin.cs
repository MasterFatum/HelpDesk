using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLesson.Models
{
    public class Admin
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string DepartmentId { get; set; }
    }
}