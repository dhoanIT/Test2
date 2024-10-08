using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;

namespace vd.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        //public string Index()
        //{
        //    return "Đây là phương thức mặc định của 1 controller bất kì";
        //}
        //public string ChaoMung(string ten, int id=1)
        //{
        //    return ("Xin Chào " + ten + ".ID: " + id);
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}