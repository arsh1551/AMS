using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using ServiceLayer.Interfaces;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Repositories;
//using ServiceLayer.Services;

namespace TestUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IUserService, UserService>();
            //container.RegisterType<IUserRepo,UserRepository>();
            container.RegisterType<IAssociateRepo, AssociateRepository>();
            container.RegisterType<IAssociateService, AssociateService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}