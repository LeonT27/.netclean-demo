using Clean.Domain.Entities;
using System.Data.Entity;

namespace Clean.Application.Interfaces.Persistence
{
    public interface IModel
    {
        DbSet<Category> Category { get; set; }
        DbSet<Task> Task { get; set; }

        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        int SaveChanges();
    }
}
