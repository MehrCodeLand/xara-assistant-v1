using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xara_assistant_v1.Models.Entithies;

namespace xara_assistant_v1.Db;

public class MyDb : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=.;Database=xara-assistant-v1;Integrated Security=true");
    }
    public DbSet<User> Users { get; set; }
}
