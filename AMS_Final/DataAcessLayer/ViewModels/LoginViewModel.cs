using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DataAcessLayer.ViewModels
{
    public class LoginViewModel
    {
        public int RoleId { get; set; }
        [Required(ErrorMessage ="Please enter UserCode")]
        public string UserCode { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
        //public int RoleId { get; set; }
            
            
    }
}