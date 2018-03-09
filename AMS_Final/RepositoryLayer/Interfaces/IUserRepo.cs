using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAcessLayer.Models;


namespace RepositoryLayer.Interfaces
{
    public interface IUserRepo
    {
        User_Test GetUser(string userCode);
        User_Test ValidateUser(String userCode, string password);
        List<User_Test> GetUsers();
        List<UserRole> GetRoles();

        bool AddUser(User_Test objUser);
        User_Test GetUser(int id);

        bool DeleteUser(int id);

    }
}