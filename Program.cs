using ContosoPizza.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Register services (Dependency Injection container)
builder.Services.AddControllers();
builder.Services.AddSingleton<IPizzaService, PizzaService>();

var app = builder.Build();

// 2. Configure the HTTP request pipeline
app.MapControllers();

// listening on all interface
app.Urls.Add("http://0.0.0.0:80");

app.Run();
