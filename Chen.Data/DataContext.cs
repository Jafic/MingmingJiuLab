using Chen.Data.Entity;
using Microsoft.EntityFrameworkCore;
namespace Chen.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //数据种子
            modelBuilder.Entity<User>().HasData(new User { LoginName = "Jacfic", Password = "111111" });
            base.OnModelCreating(modelBuilder);
        }
    }
}
