using Clean.Application.Interfaces.Persistence;
using Clean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infrastructure.Persistence
{
    public class Model : DbContext, IModel
    {
        public Model() : base("name=Gasola") {}

        public DbSet<Category> Category { get; set; }
        public DbSet<Domain.Entities.Task> Task { get; set; }
    }
}
