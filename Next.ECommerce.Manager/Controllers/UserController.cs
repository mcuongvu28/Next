
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Next.ECommerce.Application.Users.Commands;
using Next.ECommerce.Persistence;

namespace Next.ECommerce.Manager.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
