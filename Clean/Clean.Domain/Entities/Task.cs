using Clean.Domain.Common;

namespace Clean.Domain.Entities
{
    public class Task : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }

        public virtual Category Category { get; set; }
    }
}
