using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Data
{
    //繼承DbContext類，以便擁有資料庫連接和操作資料庫的功能 : DbContext
    //然後對著MVCDemoDbContext按右鍵 建立建構函式(options)
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        //打prop按兩下tab有快截鍵建立屬性
        //先在其他地方建立好Employee類別
        //Employees會是table name
        public DbSet<Employee> Employees { get; set; }
    }
}
