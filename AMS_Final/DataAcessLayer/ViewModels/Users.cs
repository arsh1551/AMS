using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAcessLayer.Models;

namespace DataAcessLayer.ViewModels
{
    public class Users
    {
        public UserViewModel user { get; set; }
         
       public List<UserViewModel> userList { get; set; }
        public List<UserRoleViewModel> UserRoles { get; set; }


    }
}