using BigMamma_InGroup.model;
using BigMamma_InGroup.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IPizzaRepository>(new PizzaRepositoryJson());
builder.Services.AddSingleton<SandwichRepository>(new SandwichRepository(true));
builder.Services.AddSingleton<DrinkRepository>(new DrinkRepository(true));
builder.Services.AddSingleton<UserRepository>(new UserRepository());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
