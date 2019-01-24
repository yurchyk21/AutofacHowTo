using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutofacProject.Models;

namespace AutofacProject.Services
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<ApplicationUser> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}