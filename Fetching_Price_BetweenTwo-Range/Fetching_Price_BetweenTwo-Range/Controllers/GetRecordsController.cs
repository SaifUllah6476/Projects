using Fetching_Price_BetweenTwo_Range.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fetching_Price_BetweenTwo_Range.Controllers
{
    public class GetRecordsController : Controller
    {
        fetching_records_with_priceEntities db = new fetching_records_with_priceEntities();
        // GET: GetRecords
        public ActionResult Index()
        {
            return View(db.tbl_product.ToList());
        }
        [HttpPost]
        public ActionResult Index(int start, int end)
        {
            return View(db.GetFunctionPro(start,end));

                   }

 

    }
}