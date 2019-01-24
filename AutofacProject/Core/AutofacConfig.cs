using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using AutofacProject.Models;
using AutofacProject.Services;

namespace AutofacProject.Core
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // регистрируем споставление типов
            builder.Register(c => new ApplicationDbContext())
                .AsSelf().InstancePerDependency();

            builder.RegisterType<Repository>().As<IRepository>().InstancePerRequest();

            //builder.RegisterType<ApplicationUserStore>().As<IUserStore<AppUser>>().InstancePerRequest();
            //builder.RegisterType<AppUserManager>().AsSelf().InstancePerRequest();
            //builder.RegisterType<AppRoleManager>().AsSelf().InstancePerRequest();
            //builder.RegisterType<AppSignInManager>().AsSelf().InstancePerRequest();
            //builder.Register<IAuthenticationManager>(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            //builder.Register<IDataProtectionProvider>(c => _app.GetDataProtectionProvider()).InstancePerRequest();
            //builder.RegisterType<AccountProvider>().AsSelf().InstancePerRequest();



            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}