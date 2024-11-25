using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ambev.DeveloperEvaluation.ORM;

public static class InitMigration
{
    public static void RunMigration<T>(IApplicationBuilder app) where T : DefaultContext
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            using (var context = serviceScope.ServiceProvider.GetService<DefaultContext>())
            {
                context.Database.Migrate();
            }
        }
    }
}
