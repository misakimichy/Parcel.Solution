using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShippingParcel.Models;

namespace ShippingParcel.Controllers
{
    public class ParcelController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> myParcel = Parcel.GetAllParcels();
            return View(myParcel);
        }

        [HttpGet("/parcels/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/parcels")]
        public ActionResult Create(double width, double length, double height, double weight)
        {
            Parcel myParcel = new Parcel(width, length, height, weight);
            return RedirectToAction("Index");
        }
    }
}