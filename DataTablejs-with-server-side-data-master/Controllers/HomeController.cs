using DataTablejs_with_server_side_data_master.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTablejs_with_server_side_data_master.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetGridData()
        {
            string mode = Convert.ToString(Request.Form["mode"]);
            ColumnConfig columnConfig = new ColumnConfig(mode);
            return columnConfig.gridParams.GetData();
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
    }
}