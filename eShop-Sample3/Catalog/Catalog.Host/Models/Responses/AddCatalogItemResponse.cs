namespace Catalog.Host.Models.Response;

public class AddCatalogItemResponse<T>
{
    public T Id { get; set; } = default(T)!;
}