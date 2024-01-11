using RasuliEEndpointsD3.Services.Guessing;
using RasuliEEndpointsD3.Services.MagicBall;
using RasuliEEndpointsD3.Services.Restauraunt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGuessingService, GuessingService>();
builder.Services.AddScoped<IRestaurauntPicker, RestaurauntPicker>();
builder.Services.AddScoped<IMagicBallService, MagicBallService>();

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
