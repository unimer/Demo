using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class NoteModel
    {
        [Display(Name = "Note Title")]
        [Required(ErrorMessage = "You have to put title for your note")]
        public string Title { get; set; }

        [Display(Name = "Note")]
        [Required(ErrorMessage = "It would be ok to put note text")]
        public string Text { get; set; }
    }
}