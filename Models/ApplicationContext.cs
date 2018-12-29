using Microsoft.EntityFrameworkCore;


namespace Dodos.UI.Models
{
    public class ApplicationContext : DbContext
    {


    }
    public class MyBloggingContext : ApplicationContext
    {
        public MyBloggingContext(DbContextOptions options) { }
        public DbSet<LoginModel> tblAppUser { get; set; }

        public static string cn { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(cn);

            base.OnConfiguring(optionsBuilder);
        }
    }

    public class MyBackupBloggingContext : ApplicationContext
    {
        public MyBackupBloggingContext(DbContextOptions options) { }
        public DbSet<Common_ConnectionModel> tblProductDB { get; set; }
        public DbSet<CountriesModel> tblCountries { get; set; }
        public DbSet<CitiesModel> tblCities { get; set; }

        public DbSet<StatesModel> tblStates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = @"server=192.168.1.100; database=Dodos_reloaded_2; uid=dodos_users; pwd=Welcome2018;";
            optionsBuilder.UseSqlServer(cn);

            base.OnConfiguring(optionsBuilder);
        }
    }

}
