using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_UsingMvc.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName cant be empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName cant be empty")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Role cant be empty")]

        public string Roles { get; set; }
        [Required(ErrorMessage = "Password cant be empty")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password cant be empty")]
        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
