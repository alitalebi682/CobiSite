using Microsoft.EntityFrameworkCore.Diagnostics;

namespace cobiWebSite.DAL.FrameWork;

public class AddAuditFieldInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        SetShadowProperties(eventData);

        return base.SavingChanges(eventData, result);
    }

    private static void SetShadowProperties(DbContextEventData eventData)
    {
        var changeTracker = eventData.Context.ChangeTracker;
        var addedEntities = changeTracker.Entries().Where(c => c.State == Microsoft.EntityFrameworkCore.EntityState.Added);
        var modifiedEntities = changeTracker.Entries().Where(c => c.State == Microsoft.EntityFrameworkCore.EntityState.Modified);
        var DeleteEntities = changeTracker.Entries().Where(c => c.State == Microsoft.EntityFrameworkCore.EntityState.Deleted);

        DateTime now = DateTime.Now;
        foreach (var item in addedEntities)
        {
            item.Property("CreatingBy").CurrentValue = "1";
            item.Property("UpdateBy").CurrentValue = "1";
            item.Property("CreatingDate").CurrentValue = now;
            item.Property("UpdateDate").CurrentValue = now;
        }


        foreach (var item in modifiedEntities)
        {
            item.Property("UpdateBy").CurrentValue = "1";
            item.Property("UpdateDate").CurrentValue = now;
        }


        foreach (var item in DeleteEntities)
        {
            item.Property("CreatingBy").CurrentValue = now.ToString("yyyy/MM/dd");
            item.Property("UpdateBy").CurrentValue = now.ToString("yyyy/MM/dd");
            item.Property("CreatingDate").CurrentValue = now;
            item.Property("UpdateDate").CurrentValue = now;
        }
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        SetShadowProperties(eventData);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}