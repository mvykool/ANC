using ANC.Models;
using Microsoft.EntityFrameworkCore;

namespace ANC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)    
    {    
    }

    //connection to DB and create table
    public DbSet<Category> Categories { get; set; }
}
