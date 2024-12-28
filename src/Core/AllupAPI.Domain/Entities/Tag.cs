using AllupAPI.Domain.Entities.Base;

namespace AllupAPI.Domain.Entities
{
    public class Tag : BaseNameableEntity
    {
        public ICollection<ProductTag> ProductTags { get; set; }

    }
}
