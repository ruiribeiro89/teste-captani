using SorteiosBFF.Application.Services;
using SorteiosBFF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

#region Services Container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Dependency Injection Services
builder.Services.AddScoped<SorteioService>();
builder.Services.AddInfrastructure();
#endregion

var app = builder.Build();

#region HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();