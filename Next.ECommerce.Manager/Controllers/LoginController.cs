using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Next.ECommerce.Persistence;

namespace Next.ECommerce.Manager.Controllers
{
    public class LoginController : Controller
    {
        //private ECommerceDbContext _context;

        //public LoginController(ECommerceDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            //var a = _context.Users.First();
            return PartialView();
        }
    }
}