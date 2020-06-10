using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListMVC.Models
{
    public class ToDo
    {
        public int Id{ get; set; }
        public string Description { get; set; }
        public bool isDone { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}