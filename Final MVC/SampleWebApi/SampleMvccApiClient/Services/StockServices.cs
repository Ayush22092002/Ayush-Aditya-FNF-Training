using SampleMvccApiClient.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace SampleMvccApiClient.Services
{

    public interface IStockServices
    {
        void AddNewStock(Stock stock);
        void DeleteStock(int id);
        Stock GetStockById(int id);
        List<Stock> GtAllStocks();
        void UpdateStock(Stock stock);
    }

    public class StockServices : IStockServices
    {
        private readonly HttpClient httpClient;

        public StockServices(HttpClient client)
        {
            httpClient = client;
        }
        public List<Stock> GtAllStocks()
        {
            List<Stock>? stocks = new List<Stock>();
            //Http client is a .Net class  

            var data = httpClient.GetStreamAsync("Stocks").Result;
            if (data != null)
            {
                stocks = JsonSerializer.DeserializeAsync<List<Stock>>(data, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }).Result;
            }
            return stocks;

        }

        public Stock GetStockById(int id)
        {
            var stock = new Stock();
            using (var response = httpClient.GetStreamAsync($"Stocks/{id}"))
            {
                var data = response.Result;
                stock = JsonSerializer.DeserializeAsync<Stock>(data, new JsonSerializerOptions
                { PropertyNameCaseInsensitive = true }).Result;
            }
            return stock;
        }

        public void AddNewStock(Stock stock)
        {
            var json = JsonSerializer.Serialize(stock);

            var content = new StringContent(json,Encoding.UTF8,"application/json");

            var responseMessage=httpClient.PostAsync("Stocks",content).Result;

            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
        }


        public void UpdateStock(Stock stock)
        {

            try
            {
                var jsonContent = JsonSerializer.Serialize(stock);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var res = httpClient.PutAsync("Stocks", content).Result;
                Console.WriteLine(res.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteStock(int id)
        {

            var res = httpClient.DeleteAsync($"Stocks/{id}").Result;
            var deletedec = JsonSerializer.Deserialize<Stock>
                (res.Content.ReadAsStringAsync().Result, new JsonSerializerOptions
                { PropertyNameCaseInsensitive = true });

            if (deletedec != null)
            {
                Console.WriteLine($"{deletedec.StockName} is removed Successfully");

            }

        }
    }
}



