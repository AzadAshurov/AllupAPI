using AllupAPI.Domain.Entities.Base;

namespace AllupAPI.Domain.Entities
{
    public class Size : BaseNameableEntity
    {
        public ICollection<ProductSize> ProductSizes { get; set; }
    }
}
