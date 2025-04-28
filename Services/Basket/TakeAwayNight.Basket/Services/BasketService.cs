using System.Text.Json;
using TakeAwayNight.Basket.Dtos;
using TakeAwayNight.Basket.Settings;

namespace TakeAwayNight.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task DeleteBasket(string UserId)
        {
            await _redisService.GetDb().KeyDeleteAsync(UserId);
        }

        public async Task<BasketTotalDto> GetBasket(string UserId)
        {
            var basket=await _redisService.GetDb().StringGetAsync(UserId);
            return JsonSerializer.Deserialize<BasketTotalDto>(basket);
        }

        public async Task SaveBasket(BasketTotalDto basket)
        {
            await _redisService.GetDb().StringSetAsync(basket.UserId, JsonSerializer.Serialize(basket));
        }
    }
}
