using BlogProject;
using BlogProject.Data;
using BlogProject.Data.Assets;
using BlogProject.Data.Assets.VideoInfoAdapter;
using BlogProject.Endpoints;


using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

var ConnString = builder.Configuration.GetConnectionString("VideoInfo");

builder.Services.AddDbContext<VideoInfoContext>(options => {
    options.UseMySQL(ConnString);
});

builder.Services.AddScoped<VideoInfoDbProxy>();
builder.Services.AddScoped<IVideoInfoDb,VideoInfoYoutube>();
builder.Services.AddScoped<YoutubeClient>();
builder.Services.AddScoped<VideoDataAdaptee>();
builder.Services.AddScoped<VideoDataAdapter>();
builder.Services.AddScoped<IPhotoService,StockPhotoService>();
builder.Services.AddScoped<IPhotoAdapter,PhotoAdapter>();
builder.Services.AddScoped<Photoadaptee>();

var app = builder.Build();

app.MapEndpoints();

app.MigrateDb();

app.Run();

