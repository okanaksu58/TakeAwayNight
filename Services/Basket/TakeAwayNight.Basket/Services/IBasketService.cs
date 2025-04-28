using TakeAwayNight.Basket.Dtos;

namespace TakeAwayNight.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket(string UserId);
        Task SaveBasket(BasketTotalDto basket);
        Task DeleteBasket(string UserId);
    }
}
