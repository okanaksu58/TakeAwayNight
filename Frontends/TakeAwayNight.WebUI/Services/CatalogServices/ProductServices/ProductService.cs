using Newtonsoft.Json;
using TakeAwayNight.WebUI.Dtos.CatalogDtos;

namespace TakeAwayNight.WebUI.Services.CatalogServices.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:8001/api/product");
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
            var values=JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return values;
        }
    }
}
