using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAcessLayer.ViewModels
{
    public class UserViewModel
    {
       
        public long Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MaxLength(25,ErrorMessage ="Maximum length exceeded")]
        public string Name { get; set; }

        public string Title { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MaxLength(8, ErrorMessage = "Maximum length exceeded")]
        public string Password { get; set; }
        public string Profession { get; set; }
        [Required(ErrorMessage = "User Code is required")]
        [MaxLength(10, ErrorMessage = "Maximum length exceeded")]
        [Display(Name ="User Code")]
        public string UserCode { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Please enter valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please select the user role")]
        public int UserRoleId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        
    }
}