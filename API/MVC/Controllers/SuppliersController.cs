using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Net.Http;

namespace MVC.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: Suppliers
        public ActionResult Index()
        {
            IEnumerable<MVCSupplierModel> suppliersList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Suppliers").Result;

            suppliersList = response.Content.ReadAsAsync<IEnumerable<MVCSupplierModel>>().Result;
            return View(suppliersList);
        }
    }
}