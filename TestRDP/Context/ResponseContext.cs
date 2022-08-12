using TestRDP.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TestRDP.Context
{
    public class ResponseContext : DbContext
    {
        public ResponseContext(DbContextOptions<ResponseContext> options) 
             : base(options)
        { }
        public DbSet<Response> Responses { get; set; } = null;

    }
}
