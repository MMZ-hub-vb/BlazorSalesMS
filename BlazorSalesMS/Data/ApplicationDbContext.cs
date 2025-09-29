using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorSalesMS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Recepit> recepits { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Distributor> distributors { get; set; }
        public DbSet<Order> order { get; set; }
    }
     
 }
