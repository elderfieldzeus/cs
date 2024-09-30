using api.Data;
using api.Interfaces;
using api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers(); // ADDED MANUALLY
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddNewtonsoftJson(options => {
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
}); // ADDED MANUALLY

builder.Services.AddDbContext<ApplicationDBContext> (options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); // ADDED MANUALLY
});

builder.Services.AddScoped<IStockRepository, StockRepository>(); // ADDED MANUALLY
builder.Services.AddScoped<ICommentRepository, CommentRepository>(); // ADDED MANUALLY

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers(); // ADDED MANUALLY

app.Run();

