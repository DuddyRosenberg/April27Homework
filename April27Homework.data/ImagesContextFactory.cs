using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace April27Homework.data
{
    public class ImagesContextFactory : IDesignTimeDbContextFactory<ImagesContext>
    {
        public ImagesContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}April27Homework.web"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();


            return new ImagesContext(config.GetConnectionString("ConnectionString"));
        }
    }
}
