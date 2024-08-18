using Microsoft.EntityFrameworkCore;
using EstudiantesWebApp.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

try
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ExamenFinalPrograV")));
}
catch (Exception ex)
{
    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
    throw new Exception("No se pudo establecer la conexión con la base de datos. Revisa la configuración.");
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
