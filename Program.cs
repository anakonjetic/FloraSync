using FloraSync.Repository;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<FloraSyncContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FloraSyncConnection"),
            opt => opt.MigrationsAssembly("FloraSync")));

builder.Services.AddSingleton<IWebHostEnvironment>(builder.Environment);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SupportNonNullableReferenceTypes(); // ako koristiš nullable anotacije
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

string localIP = LocalIPAddress();

app.Urls.Add("http://" + localIP + ":5072");
app.Urls.Add("https://" + localIP + ":7072");

app.Run();


static string LocalIPAddress()
{
    using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
    {
        socket.Connect("8.8.8.8", 65530);
        IPEndPoint? endPoint = socket.LocalEndPoint as IPEndPoint;
        if (endPoint != null)
        {
            return endPoint.Address.ToString();
        }
        else
        {
            return "127.0.0.1";
        }
    }
}