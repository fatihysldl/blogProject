using businessLayer.abstracts;
using businessLayer.concrete;
using dataAccessLayer.abstracts;
using dataAccessLayer.concrete;
using dataAccessLayer.entityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<context>();

builder.Services.AddScoped<IAuthorDal, efAuthorDal>();
builder.Services.AddScoped<IAuthorService, authorManager>();

builder.Services.AddScoped<IPostDal, efPostDal>();
builder.Services.AddScoped<IPostService, postManager>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
