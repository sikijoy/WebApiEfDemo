using Microsoft.EntityFrameworkCore;

namespace webApiEfDemo.Entitys
{

    public class EfDemoContext:DbContext
    {
        public  string ApplicationName = String.Format(@"server=127.0.0.1;database=TestDb;uid=sa;pwd=123456");
        public DbSet<User> Users { get; set; }
        public EfDemoContext(DbContextOptions options ): base( options )
        {

        }

        public EfDemoContext()
        {

        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ApplicationName); 
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //base.OnModelCreating(modelBuilder);
        }
    }
}
  