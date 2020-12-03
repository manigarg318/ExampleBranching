using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppExerciseOnbranching.Models;

namespace WebAppExerciseOnbranching.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<Emp> list = new List<Emp>
            {
                new Emp {Eid=1,Ename="Sarthak",EDesgination="Software Engineer",EDoj=DateTime.Parse("12/03/1998")},
                new Emp {Eid=2,Ename="Sarthak1",EDesgination="Software Engineer1",EDoj=DateTime.Parse("12/03/1999")},
                new Emp {Eid=3,Ename="Sarthak2",EDesgination="Software Engineer2",EDoj=DateTime.Parse("12/03/1996")},
                new Emp {Eid=4,Ename="Sarthak3",EDesgination="Software Engineer3",EDoj=DateTime.Parse("12/03/1995")}

            };

            return View(list);
        }
    }
}