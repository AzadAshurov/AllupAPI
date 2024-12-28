using AllupAPI.Domain.Entities.Base;

namespace AllupAPI.Domain.Entities
{
    public class Color : BaseNameableEntity
    {
        public ICollection<ProductColor> ProductColors { get; set; }
    }
}
