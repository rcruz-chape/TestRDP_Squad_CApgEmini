using Microsoft.EntityFrameworkCore;
using TestRDP.Context;
using TestRDP.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<RequestInformationContext>(opt => opt.UseInMemoryDatabase("RequestInformationList"));
builder.Services.AddDbContext<ResponseContext>(opt => opt.UseInMemoryDatabase("ResponseList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();