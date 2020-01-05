using Krish.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Krish.Controllers
{
    public class UserController : Controller
    {

        public ApplicationDbContext _context;
        public UserController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Detail(string id)
        {
            if (!User.IsInRole("Admin"))
            {
                id = User.Identity.GetUserName();
                var list = _context.Numbers.Where(x => x.Employee == id).ToList();
                return View(list);
            }
            else
            {
                var list = _context.Numbers.ToList();
                return View(list);
            }



        }


        //Validate From Model Number Picking
        public JsonResult IsExist(string WNumber, int? Id)
        {
            var validateName = _context.Numbers.FirstOrDefault
                                (x => x.WNumber == WNumber && x.Id != Id);
            if (validateName != null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Winner()
        {
            var list = _context.Draws.ToList();
            return View(list);
        }

        public ActionResult GenerateRandom()
        {
            Random rd = new Random();
            ViewBag.Ran = rd.Next(1000, 9999);
            return View("CreateWinning");

        }
        public ActionResult CreateWinning()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Number number)
        {
            

            try
            {
                if (ModelState.IsValid)
                {

                    var id = User.Identity.GetUserName();
                    var li = _context.Numbers.Where(x => x.Employee == id).ToList();
                    var lee = _context.Numbers.ToList();
                    ViewBag.count = li.Count();
                    int qty = li.Count() + 1;
                    int allqty = lee.Count() + 1;

                    number.DrawId = 13;
                    number.Employee = User.Identity.GetUserName();
                    number.Qty = qty;
                    number.AllQty = allqty;
                    _context.Numbers.Add(number);
                    _context.SaveChanges();
                    return RedirectToAction("Detail");

                }
                else
                {
                    return RedirectToAction("Detail");
                }


            }
            catch (Exception)
            {
                return Content("error");
            }
        }
        public ActionResult NewOne()
        {
            return Content("Hello Content");
        }
    } 
}



    
