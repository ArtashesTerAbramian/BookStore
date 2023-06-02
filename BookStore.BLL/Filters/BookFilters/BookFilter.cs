using BookStore.DAL.Models;

namespace BookStore.BLL.Filters.BookFilters;

public class BookFilter : BaseFilter<Book>
{
    public string? Name { get; set; }
    public int? AuthorId { get; set; }
    public int? CategoryId { get; set; }
    public override IQueryable<Book> CreateQuery(IQueryable<Book> query)
    {
        if (Query != null)
        {
            return Query;
        }

        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(x => x.Name.ToLower().Contains(Name.ToLower()));
        }

        if (AuthorId > 0)
        {
            query = query.Where(x => x.AuthorId == AuthorId);
        }

        if (CategoryId > 0)
        {
            query = query.Where(x => x.CategoryId == CategoryId);
        }

        return query.OrderByDescending(x => x.Id);
    }
}