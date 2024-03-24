using Microsoft.EntityFrameworkCore;
using Task_Management__ystem.Domain;
using Task_Management__ystem.Infrastructures.Interfaces;

namespace Task_Management__ystem.Infrastructures
{
    public class TaskManagementDbContext : DbContext, ITaskManagementDbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options): base(options)
        {
            //Database.Migrate();
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Assignment> Assignments => Set<Assignment>();
        public DbSet<Status> Statuses => Set<Status>();

    }
}
