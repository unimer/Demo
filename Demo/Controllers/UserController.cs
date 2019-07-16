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


        public ActionResult AddNewNote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewNote(NoteModel model)
        {
            // Calculation module
            try
            {
                NoteModel newNote = new NoteModel();

                newNote.Text = model.Text;
                newNote.Title = model.Title;

                ViewBag.Notification = "Note Added Successfully!";
                ViewBag.Type = "alert-success";

            }
            catch
            {
                ViewBag.Notification = "Failded to add Note!";
                ViewBag.Type = "alert-danger";
            }

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


            // Adding Dummy Data
            for(int i=1; i<=10; i++)
            {
                notes.Add(new NoteModel
                {
                    Title = "Note" + i + "Title",
                    Text = "Note" + i +  "Text"
                });
            }
            
            return View(notes);
        }
    }
}