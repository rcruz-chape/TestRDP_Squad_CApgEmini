using TestRDP.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TestRDP.Context

{
    public class RequestInformationContext : DbContext
    {
        public RequestInformationContext(DbContextOptions<RequestInformationContext> options)
             : base(options)
        { }
        public DbSet<RequestInformation> Responses { get; set; } = null;
    }
}
