using Module4_ModuleHW.Entity;

namespace Module4_ModuleHW.Interface
{
    public interface IRepositoryOrderItem
    {
        Task CreateOrderItemAsync(User orderItem);
        Task UpdateOrderItemAsync(User orderItem);
        Task DeleteOrderItemAsync(User orderItemId);

        Task<User> GetOrderItemAsync(User orderItemId);
    }
}
