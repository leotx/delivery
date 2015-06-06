using System.Collections.Generic;

namespace Delivery.Infrastructure.Entities
{
    public class Group : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}