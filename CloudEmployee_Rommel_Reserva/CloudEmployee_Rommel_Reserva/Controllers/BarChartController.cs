using CloudEmployee_Rommel_Reserva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudEmployee_Rommel_Reserva.Controllers
{
    public class BarChartController : Controller
    {
        //
        // GET: /BarChart/
        public ActionResult BarChart()
        {
            return View(BarChartModel.ChartData.GetData());
        }
	}
}