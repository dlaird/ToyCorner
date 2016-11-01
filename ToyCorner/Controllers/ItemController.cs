using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyCorner.Code;
using ToyCorner.Models;

namespace ToyCorner.Controllers
{
    public class ItemController : Controller
    {
        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            return View(DataSets.getItem(id));
        }
    }
}
