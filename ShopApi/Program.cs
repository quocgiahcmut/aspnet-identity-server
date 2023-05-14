using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ShopApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var cs = builder.Configuration.GetConnectionString("DefaultConnectionString");

builder.Services.AddDbContext<ApplicationDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

//builder.Services.AddDataAccess(builder.Configuration);

builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

app.MapControllers();

app.Run();
