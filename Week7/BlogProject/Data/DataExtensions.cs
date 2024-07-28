using Microsoft.EntityFrameworkCore;

namespace BlogProject.Data;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<VideoInfoContext>();
        dbContext.Database.Migrate();
    }
}
