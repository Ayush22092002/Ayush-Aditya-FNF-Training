using Microsoft.AspNetCore.Mvc;
using SampleMvccApiClient.Models;
using SampleMvccApiClient.Services;
using System.Diagnostics;

namespace SampleMvccApiClient.Controllers
{
    public class HomeController : Controller
    {

        private readonly IStockServices stockServices;

        public HomeController(IStockServices service) 
        {

            stockServices = service;
         }
        public IActionResult Index()
        {
            var res= stockServices.GtAllStocks();
            return View(res);
        }
        public IActionResult Details(int id)
        {
            var model = stockServices.GetStockById(id);
            return View(model);

        }

        [HttpPost]
        public IActionResult Details(Stock postedData)
        {
            try
            {
                stockServices.UpdateStock(postedData);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(postedData);
            }
        }

        public IActionResult AddNew() => View(new Stock());

        [HttpPost]
        public IActionResult AddNew(Stock posteddata)
        {
            try
            {
                stockServices.AddNewStock(posteddata);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Delete(int id)
        {
            stockServices.DeleteStock(id);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
