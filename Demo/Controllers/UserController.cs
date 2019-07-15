using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }


    
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(UserModel model)
        {
            if (model.UserName == "root" && model.Password == "root")
            {
                
               

                return RedirectToAction("ListNotes");
            }
           
            return View();
        }

        
        public ActionResult ListNotes()
        {
            List<NoteModel> notes = new List<NoteModel>();

            notes.Add(new NoteModel
            {
                Title = "Note 1",
                Text = "Note Text 1"
            });


            return View(notes);
        }
    }
}