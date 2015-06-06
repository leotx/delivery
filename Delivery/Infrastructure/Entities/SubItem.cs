namespace Delivery.Infrastructure.Entities
{
    public class SubItem : Entity
    {
        public virtual string Name { get; set; }
        public virtual decimal? Value { get; set; }
    }
}