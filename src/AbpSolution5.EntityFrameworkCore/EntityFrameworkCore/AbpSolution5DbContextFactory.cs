using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpSolution5.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpSolution5DbContextFactory : IDesignTimeDbContextFactory<AbpSolution5DbContext>
{
    public AbpSolution5DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpSolution5EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpSolution5DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpSolution5DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpSolution5.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
