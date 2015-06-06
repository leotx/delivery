using System.Collections.Generic;

namespace Delivery.Infrastructure.Entities
{
    public class Product : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Value { get; set; }
        public virtual int Quantity { get; set; }
        public virtual string Note { get; set; }
        public virtual IList<Item> Items { get; set; }
    }
}