using Microsoft.EntityFrameworkCore;

namespace Forms.Data;

public class FormsDb(
    DbContextOptions<FormsDb> options
    ) : DbContext(options)
{
    public DbSet<Guild> Guilds { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Form> Forms { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<Response> Responses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbOptions)
    {
        dbOptions.UseNpgsql(options =>
        {

        });
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.UseIdentityByDefaultColumns();

    }
}
