using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cariso_LabExam.Models;
namespace Cariso_LabExam.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1,username="Admin",password="Admin1234"},
                new UserModel{id=2,username="mjcariso3",password="mj123"},

            };

            return users;
        }
        public ActionResult Verify(UserModel user)
        {
            var put = PutValue();

            var usern = put.Where(a => a.username.Equals(user.username));

            var passw = usern.Where(p => p.password.Equals(user.password));

            if (passw.Count() == 1)
            {
                ViewBag.message = "Login Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }
        }
    }
}