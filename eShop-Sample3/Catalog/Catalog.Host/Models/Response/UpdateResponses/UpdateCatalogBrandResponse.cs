using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Models.Responses.UpdateResponses
{
    public class UpdateCatalogBrandResponse<T>
    {
        public CatalogBrandDto Brand { get; set; } = null!;
    }
}
