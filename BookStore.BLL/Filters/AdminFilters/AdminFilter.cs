using BookStore.DAL.Models;

namespace BookStore.BLL.Filters.AdminFilters;

public class AdminFilter : BaseFilter<Admin>
{
    public string Email { get; set; }
    public string UserName { get; set; }
    public override IQueryable<Admin> CreateQuery(IQueryable<Admin> query)
    {
        if (Query != null)
        {
            return Query;
        }

        if (!string.IsNullOrWhiteSpace(Email))
        {
            query = query.Where(x => x.Email.ToLower().Contains(Email.ToLower()));
        }

        if (!string.IsNullOrWhiteSpace(UserName))
        {
            query = query.Where(x => x.UserName.ToLower().Contains(UserName.ToLower()));
        }

        if (IsDeleted.HasValue)
        {
            query = query.Where(x => x.IsDeleted == IsDeleted);
        }

        return query.OrderByDescending(x => x.Id);
    }
}