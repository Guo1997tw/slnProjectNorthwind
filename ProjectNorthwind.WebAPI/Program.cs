using ProjectNorthwind.Repository.Helper;
using ProjectNorthwind.Repository.Interface;
using ProjectNorthwind.Repository.Repository;
using ProjectNorthwind.Service.Interface;
using ProjectNorthwind.Service.Services;
using ProjectNorthwind.Service.Mapping;
using ProjectNorthwind.WebAPI.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add Dependency Injection
builder.Services.AddScoped<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerServices, CustomerServices>();

// Add AutoMapper
builder.Services.AddAutoMapper(x =>
{
    x.AddProfile<ServiceProfile>();
    x.AddProfile<WebAPIProfile>();
});

// Add services to the container.
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