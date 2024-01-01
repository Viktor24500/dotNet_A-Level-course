using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Models.Responses.UpdateResponses
{
    public class UpdateCatalogTypeResponse<T>
    {
        public CatalogTypeDto Type { get; set; } = null!;
    }
}
