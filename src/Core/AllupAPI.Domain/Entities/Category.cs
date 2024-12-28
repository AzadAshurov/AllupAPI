using AllupAPI.Domain.Entities.Base;

namespace AllupAPI.Domain.Entities
{
    public class Category : BaseNameableEntity
    {
        //Relation
        public ICollection<Product> Products { get; set; }
    }
}
