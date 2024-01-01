using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Models.Responses.UpdateResponses
{
    public class UpdateCatalogItemResponse<T>
    {
        public CatalogGetItemDto Item { get; set; } = null!;
    }
}
