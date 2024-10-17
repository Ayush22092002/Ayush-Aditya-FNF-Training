using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApi.Data;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockMarketController : ControllerBase
    {
        private readonly FnFTrainingContext _context;
        public StockMarketController(FnFTrainingContext context)
        {
            _context = context;
        }
        
        
        [HttpGet]
        [Route("Stocks")]
        public List<StockTable> AllStocks()
        {
            var result = _context.StockTables.ToList();
            return result;
        }

        [HttpGet]
        [Route("Stocks/{id}")]
        public  StockTable GetById(int id)
        {
            var found = _context.StockTables.FirstOrDefault(s=>s.StockId==id);
            if (found == null)
            {
                throw new Exception("Not Found");

            }
            return found;
        }

        [HttpPut]//Update the Stocks
        [Route("Stocks")]
        public StockTable PutStocks(StockTable data) 
        {
            var found = _context.StockTables.FirstOrDefault(s=>s.StockId==data.StockId);
            if (found == null)
            {
                throw new Exception("Not Found");
            }
            found.StockName=data.StockName;
            found.StockDescription=data.StockDescription;
            found.UnitPrice=data.UnitPrice;
            _context.SaveChanges();
            return found;
        }//Update the Stocks

        [HttpDelete]
        [Route("Stocks/{id}")]
        public StockTable Deletestock(int id)
        {
            var found = _context.StockTables.FirstOrDefault(s => s.StockId == id);
            if (found == null)
            {
                throw new Exception("Not found");
            }
            _context.StockTables.Remove(found);
            _context.SaveChanges();
            return found;
        }

        [HttpPost]
        [Route("Stocks")]
        public ObjectResult AddStock(StockTable stock)
        {
            _context.StockTables.Add(stock);
            _context.SaveChanges();
            return Ok("Added Successfully");
        }
        
    }
}
