using AutoMapper;
using Fligth.Data;
using Fligth.Models;
using Fligth.Web.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace Fligth.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly FligthManagerContext _context;
        private readonly IMapper _mapper;

        public UsersController(FligthManagerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserInputViewModel obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Password.Length < 6 || obj.Password.Length > 16)
                {
                    ModelState.AddModelError("password", "password should be between 6 and 16 characters");
                    return View(obj);
                }

                var user = _mapper.Map<User>(obj);
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return View(obj);
        }
    }
}
