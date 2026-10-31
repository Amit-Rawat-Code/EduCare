using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCare.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult QuickLinksDashBoard()
        {
            return View();
        }
        public ActionResult AdminQuickLinksDashBoard()
        {
            return View();
        }

        //public ActionResult SidebarLink()
        //{
        //    return View();
        //}        
    }
}