using ShopApi.Models;

namespace ShopApi.Services;

public interface IBookService
{
    Task<List<BookModel>> GetListAsycn();
}
