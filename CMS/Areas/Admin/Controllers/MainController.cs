using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Areas.Admin.Models;

namespace CMS.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        // GET: Admin/Main

        public ActionResult Index()
        {
            //进入后台
            return View();
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult DoLogin(Models.admin admin)
        {
            //List<Models.admin> adminList = new Models.adminDAL().admin.ToList();
            adminDAL adminDal = new adminDAL();

            List<admin> list = adminDal.admin
                .Where<admin>(a => a.UserName == admin.UserName && a.PassWord == admin.PassWord).ToList();

            if (list.Count > 0)
            {
                //登陆成功
                return RedirectToAction("Index", "Home",new {area=""});
            }
            else
            {
                //登陆失败
                return View("Login");
            }
        }
    }
}