using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;
using RepositoryLayer.Interfaces;
using DataAcessLayer.ViewModels;
using DataAcessLayer.Models;


namespace ServiceLayer.Services
{
    
   public class UserService:IUserService
    {
        public IUserRepo _userRepo = null;
        public UserService(IUserRepo objUserRepo)
        {
            _userRepo = objUserRepo;

        }

        List<UserViewModel> IUserService.GetUsers()
        {
            try
            {
                var listUserViewModel = _userRepo.GetUsers().Select(x => new UserViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Password = x.Password,
                    Title = x.Title,
                    Profession = x.Profession,
                    Email = x.Email,
                    CreatedDate=x.CreatedDate,
                    UserCode=x.UserCode
                    

                }).ToList();

                return listUserViewModel;
            }
            catch
            {
                throw;
            }


        }
     public List<UserRoleViewModel> GetRoles()
        {
            try
            {
                var listUserRoleViewModel = _userRepo.GetRoles().Select(x => new UserRoleViewModel
                {
                    RoleId = x.RoleId,
                    RoleName = x.RoleName

                }).ToList();

                return listUserRoleViewModel;
            }
            catch
            {
                throw;
            }

        }

        public bool AddUser(UserViewModel objUserViewModel)
        {
            User_Test objUser = new User_Test
            {
                Id = objUserViewModel.Id,
                Name = objUserViewModel.Name,
                Title = objUserViewModel.Title,
                Password = objUserViewModel.Password,
                Profession = objUserViewModel.Profession,
                UserCode = objUserViewModel.UserCode,
                UserRoleId = objUserViewModel.UserRoleId,
                Email = objUserViewModel.Email,
               // CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted=false   
           
            };

          return  _userRepo.AddUser(objUser);

        }

        public UserViewModel GetUser(string userCode)
        {
          User_Test objUser= _userRepo.GetUser(userCode);
            if (objUser!=null)
            {
                UserViewModel objUserViewModel = new UserViewModel
                {

                    Id = objUser.Id,
                    Name = objUser.Name,
                    Password = objUser.Password,
                    Title = objUser.Title,
                    Profession = objUser.Profession,
                    Email = objUser.Email,
                    CreatedDate = objUser.CreatedDate,
                    UserCode = objUser.UserCode,
                    UserRoleId = objUser.UserRoleId.Value
                };
                return objUserViewModel;
            }
            else
            {
                return null;
            }
           
        }

     public UserViewModel GetUser(int id)
        {
            User_Test objUser = _userRepo.GetUser(id);
            if (objUser != null)
            {
                UserViewModel objUserViewModel = new UserViewModel
                {

                    Id = objUser.Id,
                    Name = objUser.Name,
                    Password = objUser.Password,
                    Title = objUser.Title,
                    Profession = objUser.Profession,
                    Email = objUser.Email,
                    CreatedDate = objUser.CreatedDate,
                    UserCode = objUser.UserCode,
                    UserRoleId = objUser.UserRoleId.Value
                };
                return objUserViewModel;
            }
            else
            {
                return null;
            }


        }

      public bool DeleteUser(int id)
        {

           var result=_userRepo.DeleteUser(id);
            return result;
        }

       public UserViewModel ValidateUser(String userCode, string password)
        {
           User_Test objUser=_userRepo.ValidateUser(userCode,password);
            if (objUser != null)
            {
                UserViewModel objUserViewModel = new UserViewModel
                {
                    Id = objUser.Id,
                    Name = objUser.Name,
                    Password = objUser.Password,
                    Title = objUser.Title,
                    Profession = objUser.Profession,
                    Email = objUser.Email,
                    CreatedDate = objUser.CreatedDate,
                    UserCode = objUser.UserCode,
                    UserRoleId = objUser.UserRoleId.Value
                  
                };
                return objUserViewModel;
            }
            else
            {
                return null;
            }

        }

    }
}
