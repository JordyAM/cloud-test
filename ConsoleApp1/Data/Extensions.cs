using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerInfo.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<CustomerContext>();
                context.Database.EnsureCreated();
                DbSetInitializer.Initialize.AsNoTracking().ToList()(context);
            }
        }
    }
}
