using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace AngularJsTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Angularjs() { return View(); }

        public void GetList(my m)
        {
            list.Add(m);
        }
        public static List<my> list = new List<my>();
        public ActionResult AngularjsGetList()
        {
            my m = new my();
            m.id = 123;
            m.name = "23232323";
            m.age = 32;
            m.yz = 12;
            GetList(m);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Add(my m)
        {
            GetList(m);
            return Content("<script>alert('添加成功');parent.location='/Home/Angularjs';</script>");
        }
        public void Edit(int id)
        {
            ViewBag.id= id;
            //return View();
        }
        public ActionResult Edit_Data(int id)
        {
            return Json(list.FirstOrDefault(m => m.id == id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Del(int id)
        {
            var tt = list.FirstOrDefault(m => m.id == id);
           list.Remove(tt);
            //list.SaveChanges();
            return Content("T");
        }
    }
    public partial class my
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> yz { get; set; }
    }
}