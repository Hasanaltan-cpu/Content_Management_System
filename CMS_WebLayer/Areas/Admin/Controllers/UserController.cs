using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cms_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CMS_WebLayer.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager) => _userManager = userManager;

        public IActionResult Index() => View(_userManager.Users);
    }
}
