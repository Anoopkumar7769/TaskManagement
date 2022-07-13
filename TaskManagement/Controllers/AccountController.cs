using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System.Linq;
using System.Web;
using TaskManagement.Data;
using TaskManagement.Models.ViewModels;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace TaskManagement.Controllers
{
    public class AccountController : Controller
    {

        private readonly ApplicationDbContext _db;
       //public const string SessionKeyid = "_id";

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(obj);

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
         
            if (ModelState.IsValid)
            {
                var data = _db.Register.Where(s => s.Email.Equals(obj.Email) && s.Password.Equals(obj.Password)).ToList();
                
                if (data.Count() > 0)
                {
                    TempData["idx"] = data[0].id;

                    HttpContext.Session.SetString("id", data[0].id.ToString());
                    HttpContext.Session.SetInt32("id", data[0].id);
                    HttpContext.Session.SetString("Email", data[0].Email);
                    //string email = "";
                    string script = string.Format("sessionStorage.id='{0}';", data[0].id);
                    TempData["id"] = data[0].id;
                    //HttpContext.Session.SetInt32(SessionKeyid, data[0].id);
                    // session.SetString(key, JsonSerializer.Serialize(data[0].id));
                    int id = (int)HttpContext.Session.GetInt32("id");
                    ViewBag.id = data[0].id;
                    var value = HttpContext.Session.GetString("id");
                    var objList = _db.Records.Where
                    (x => x.reg_id == id);
                    string email = HttpContext.Session.GetString("Email");

                    //Global_Function.AddMailData(objList, id, email);

                    //object mailData = _db.Records.Where(s => s.reg_id == data[0].id).ToList();
                    //TempData["mailData"] = mailData;
                    //HttpContext.Session.SetString("value", value);

                    return RedirectToAction("GetData", "Record");
                }
                else
                {
                    string msg = "";
                    msg = "UserName or password is wrong";
                    TempData["ErrorMessage"] = msg;
                    ViewBag.message = "UserName or password is wrong";
                    return RedirectToAction("Login");
                }
            }
            return View(obj);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
