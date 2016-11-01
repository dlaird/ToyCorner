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
    public class TypeController : Controller
    {
        // GET: Type
        public ActionResult Index()
        {
            return View(DataSets.getTypeList());
        }

        // GET: Type/Details/5
        public ActionResult Details(int ID)
        {
            return View(DataSets.getItemList(ID));
        }
    }
}
