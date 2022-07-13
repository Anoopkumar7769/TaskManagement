using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using TaskManagement.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System;

namespace TaskManagement.Controllers
{
    public class RecordController : Controller
    {

        private readonly ApplicationDbContext _db;
       // private readonly IEmailSender _emailSender;
        //public RecordController(ApplicationDbContext db,IEmailSender emailSender, Task1 job)
        public RecordController(ApplicationDbContext db)
        {
            _db = db;
          //  _emailSender = emailSender;
           
        }

        [HttpGet]
        public async Task<IActionResult> GetData(RecordsViewModel obj,int id)
        {
                id= (int)HttpContext.Session.GetInt32("id");
                string email = HttpContext.Session.GetString("Email");
                //string a = getData();
                //id = (int)TempData["idx"];    
                IEnumerable<RecordsViewModel> objList = _db.Records.Where
                    (x => x.reg_id == id).Select(c => new RecordsViewModel()
                    {
                        reg_id = c.reg_id,
                        color = c.color,
                        title = c.title,
                        description = c.description,
                        dateTime = c.dateTime,
                        rec_id = c.rec_id
                    });
            return View(objList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(RecordsViewModel obj,int id)
        {
            //user = _db.Register.FirstOrDefault(u => u.id == reg);
            
            if(id==0)
            {
                id = (int)HttpContext.Session.GetInt32("id");
                string email = HttpContext.Session.GetString("Email");
                TempData["email"] = email;
                obj.reg_id = id;
                _db.Add(obj);
                //await _emailSender.SendEmailAsync(email, "Task Created", $"Your task is to {obj.title}");
                _db.SaveChanges();
                return RedirectToAction("GetData", "Record");
            }
           return View(obj);
        }

        // GET-Update
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Records.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View("Create",obj);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(RecordsViewModel obj,int id,int rec_id)
        {
            if (ModelState.IsValid)
            {
                id = (int)HttpContext.Session.GetInt32("id");
                obj.reg_id = id;
                obj.rec_id = rec_id;
                _db.Records.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("GetData", "Record");
            }
            return View(obj);
        }

        // GET-Delete
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var obj = _db.Records.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(obj);
        //}

        // POST-Delete

       
        public IActionResult Delete(RecordsViewModel obj, int id, int rec_id)
        {
            obj.reg_id = (int)HttpContext.Session.GetInt32("id");
            obj.rec_id = id;
            var objList = _db.Records.Find(obj.rec_id);
            _db.Records.Remove(objList);
            _db.SaveChanges();
            return RedirectToAction("GetData", "Record");
        }

    }
}
