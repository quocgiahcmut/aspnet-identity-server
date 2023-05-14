using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ShopApi.Models;

namespace ShopApi.Services;

public class BookService : IBookService
{
    private readonly ApplicationDbContext _context;

    public BookService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<BookModel>> GetListAsycn()
    {
        var books = await (from book in _context.Books
                           select new BookModel
                           {
                               Id = book.Id,
                               Name = book.Name,
                               ReleaseDate = book.ReleaseDate,
                               Description = book.Description
                           }).ToListAsync();

        return books;
    }
}
