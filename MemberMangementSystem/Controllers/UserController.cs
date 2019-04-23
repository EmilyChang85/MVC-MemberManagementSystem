using MemberMangementSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberMangementSystem.Models;

namespace MemberMangementSystem.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();
        // GET: User
        public ActionResult Index()
        {
            List<MemberMangementSystem.Models.User> UserList = new List<MemberMangementSystem.Models.User>();
            UserList = userService.GetAllUser();
            return View(UserList);
        }
        public ActionResult editUser(int Id)
        {
            User user = userService.findUser(Id);
            return PartialView("editUser", user);
        }

        [HttpPost]
        public ActionResult UpdateUser(User data)
        {

            userService.updateUserData(data);
            return RedirectToAction("Index");
        }


        public ActionResult deleteUser(int Id)
        {
            userService.deleteUser(Id);
            return RedirectToAction("Index");
        }

        public ActionResult createUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createUser(User data)
        {
            userService.createUser(data);
            return RedirectToAction("Index");
        }
        
    }
}