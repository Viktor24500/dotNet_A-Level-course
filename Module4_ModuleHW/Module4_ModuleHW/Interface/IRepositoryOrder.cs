using Module4_ModuleHW.Entity;

namespace Module4_ModuleHW.Interface
{
    public interface IRepositoryOrder
    {
        Task CreateOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(Order orderId);

        Task<Order> GetOrderAsync(Order orderId);
    }
}
