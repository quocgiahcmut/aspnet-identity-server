using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ShopApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAuthentication("Bearer")
    .AddIdentityServerAuthentication("Bearer", options =>
    {
        options.Authority = "https://localhost:5443";
        options.ApiName = "BookApi";
    });

builder.Services.AddDbContext<ApplicationDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("PcConnection")));

builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
