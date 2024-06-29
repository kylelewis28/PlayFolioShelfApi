using Microsoft.EntityFrameworkCore;
using PlayFolioShelf.Data;
using PlayFolioShelf.Services; 
using PlayFolioShelf.Models;
using PlayFolioShelf.Services.Services;
using PlayFolioShelf.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PlayFolioShelfContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IMaturityService, MaturityService>(); 
builder.Services.AddScoped<IUserReviewService, UserReviewService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
