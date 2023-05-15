using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApi.Services;

namespace ShopApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var books = await _bookService.GetListAsycn();

        return Ok(books);
    }
}
