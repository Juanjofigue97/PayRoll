using PayRollLibrary.Data;
using PayRollLibrary.Databases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IAgencyRepository, SqlAgencyRepository>();
builder.Services.AddTransient<IEmployeeRepository, SqlEmployeeRepository>();
builder.Services.AddTransient<IPaymentRepository, SqlPaymentRepository>();

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
