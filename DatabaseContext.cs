using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;

namespace c_sharp_asp_net_server;

[Table("Object")]
public class Object
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}

public class DatabaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=localhost; Database=sqlserver; User Id=SA; Password=YourStrong@Passw0rd; TrustServerCertificate=true;");
    }

    public DbSet<Object> Objects { get; set; }
}
