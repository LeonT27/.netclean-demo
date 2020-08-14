using Clean.Domain.Common;
using System.Collections.Generic;

namespace Clean.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Category()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
