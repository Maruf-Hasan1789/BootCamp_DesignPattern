using BlogProject.Data;
using BlogProject.Data.Assets;
using BlogProject.Endpoints;


using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

var ConnString = builder.Configuration.GetConnectionString("VideoInfo");

builder.Services.AddDbContext<VideoInfoContext>(options => {
    options.UseMySQL(ConnString);
});
builder.Services.AddScoped<VideoInfoDbReal>();

var app = builder.Build();

app.MapEndpoints();

app.MigrateDb();

app.Run();

