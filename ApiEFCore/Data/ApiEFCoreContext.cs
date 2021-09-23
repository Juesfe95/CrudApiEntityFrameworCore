using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiEFCore.Models;

namespace ApiEFCore.Data
{
    public class ApiEFCoreContext : DbContext
    {
        public ApiEFCoreContext (DbContextOptions<ApiEFCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ApiEFCore.Models.Book> Book { get; set; }
    }
}
