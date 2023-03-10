using AutoMapper;
using Fligth.Data;
using Fligth.Models;
using Fligth.Web.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace Fligth.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly FligthConext _context;
        private readonly IMapper _mapper;

        public UsersController(FligthConext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Create(UserInputViewModel obj)
        {
            // TODO: Fix the RedirectToAction When there is not user created

            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(obj);
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
