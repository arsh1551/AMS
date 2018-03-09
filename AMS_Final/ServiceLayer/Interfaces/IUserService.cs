using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.ViewModels;

namespace ServiceLayer.Interfaces
{
   public interface IUserService
    {
        UserViewModel GetUser(string userCode);
        UserViewModel GetUser(int id);
       List<UserViewModel> GetUsers();
        List<UserRoleViewModel> GetRoles();

        bool AddUser(UserViewModel objUserViewModel);
        bool DeleteUser(int id);

        UserViewModel ValidateUser(String userCode, string password);

    }
}
