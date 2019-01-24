using AutofacProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacProject.Services
{
    public interface IRepository
    {
        List<ApplicationUser> GetAllUsers();

    }
}