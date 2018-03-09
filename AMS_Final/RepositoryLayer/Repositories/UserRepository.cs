using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.Models;
using RepositoryLayer.Interfaces;

namespace RepositoryLayer.Repositories
{
  public class UserRepository:IUserRepo
    {
        #region Initialize
        UnityOfWork uow = null;
        DMS2DataContext DataContext;
        public UserRepository()
        {
            if (uow == null)
            {
                DataContext = new DMS2DataContext();


                uow = new UnityOfWork(DataContext);
            }
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                this.uow.Dispose();
                this.DataContext.Database.Connection.Close();
                this.DataContext.Dispose();
            }
            // free native resources
        }
#endregion

       // private DMS2DataContext db = new DMS2DataContext();
        public List<User_Test> GetUsers()
        {
            //List<User_Test> userList = db.User_Test.ToList();
            try
            {
                List<User_Test> userList = uow.Repository<User_Test>().GetAll().ToList();
                return userList;
            }
            catch
            {
                throw;

            }
            
        }
       public List<UserRole> GetRoles()
        {
            try
            {
                List<UserRole> roleList = uow.Repository<UserRole>().GetAll().ToList();
                return roleList;
            }
            catch
            {
                throw;

            }

        }

        public bool AddUser(User_Test objUser)
        {
            try
            {
                if (objUser.Id == 0)
                {
                    objUser.CreatedDate = DateTime.Now;
                    uow.Repository<User_Test>().Add(objUser);
                    uow.SaveChanges();
                }
                else
                {
                    User_Test objDbuser = uow.Repository<User_Test>().Get(x => x.Id == objUser.Id);
                    //objDbuser.Name = objUser.Name;

                    objDbuser.Name = objUser.Name;
                       objDbuser.Title = objUser.Title;
                        objDbuser.Profession = objUser.Profession;
                       objDbuser.UserCode = objUser.UserCode;
                       objDbuser.UserRoleId = objUser.UserRoleId;
                       objDbuser.Email = objUser.Email;
                       objDbuser.Password = objUser.Password;
                       objDbuser.ModifiedDate = DateTime.Now;

                    
                    //uow.SetModifiedState<User_Test>(objDbuser);
                    uow.SaveChanges();


                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }


        }

        public User_Test GetUser(String userCode)
        {

            User_Test user = uow.Repository<User_Test>().Get(x => x.UserCode == userCode && x.IsActive == true && x.IsDeleted == false);
            return user;
        }

        public User_Test ValidateUser(String userCode, string password)
        {

            User_Test user = uow.Repository<User_Test>().Get(x => x.UserCode == userCode && x.Password == password && x.IsActive == true && x.IsDeleted == false);
            return user;
        }



        public User_Test GetUser(int id)
        {

            User_Test user = uow.Repository<User_Test>().Get(x => x.Id == id);
            return user;
        }

        public bool DeleteUser(int id)
        {
            try
            {
                User_Test objUser = GetUser(id);
                if (objUser != null)
                {
                    uow.Repository<User_Test>().Delete(objUser);
                    uow.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                throw;
            }
            
        }
    }
}
