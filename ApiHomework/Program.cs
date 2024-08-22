using ApiHomeworkDAL;
using ApiHomeworkDAL.Interfaces;
using ApiHomeworkDAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BookDbContext>();

builder.Services.AddTransient<IBookRepo, BookRepo>();
builder.Services.AddTransient<IAuthorRepo, AuthorRepo>();
builder.Services.AddTransient<IGenreRepo, GenreRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
