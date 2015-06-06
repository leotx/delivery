using System.Collections.Generic;

namespace Delivery.Infrastructure.Entities
{
    public class Item : Entity
    {
        public virtual string Name { get; set; }
        public virtual IList<SubItem> SubItens { get; set; }
        public virtual ItemType ItemType { get; set; }
    }
}