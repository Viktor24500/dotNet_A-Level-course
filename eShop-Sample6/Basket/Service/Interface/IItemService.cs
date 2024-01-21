using Basket.Models;

namespace Basket.Service.Interface
{
    public interface IItemService
    {
        List<Item> Get();
        int Add(Item item);
    }
}
