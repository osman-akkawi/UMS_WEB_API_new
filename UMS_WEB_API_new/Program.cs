using UMS_WEB_API_new.Extention;
using UMS_WEB_API_new.Filters;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddController();
builder.Services.addDb(builder.Configuration);
builder.Services.AddAutoMapperConfig();
builder.Services.AddRepositoty();
builder.Services.AddService();

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
