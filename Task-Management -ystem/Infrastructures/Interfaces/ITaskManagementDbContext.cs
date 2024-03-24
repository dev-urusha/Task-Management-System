using Microsoft.EntityFrameworkCore;
using Task_Management__ystem.Domain;

namespace Task_Management__ystem.Infrastructures.Interfaces
{
    public interface ITaskManagementDbContext
    {
        public DbSet<User> Users { get; }
        public DbSet<Role> Roles { get; }
        public DbSet<Assignment> Assignments { get; }
        public DbSet<Status> Statuses { get; }

    }
}
