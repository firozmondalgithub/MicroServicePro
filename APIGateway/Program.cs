

using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();
var app = builder.Build();
app.UseOcelot().Wait();
app.MapControllers();

//app.MapGet("/", () => "Hello World!");
//await app.UseOcelot();

app.Run();



//using Ocelot.DependencyInjection;
//using Ocelot.Middleware;
//var builder = WebApplication.CreateBuilder(args);
//// Add services to the container.
//builder.Services.AddCors(options => {
//    options.AddPolicy("CORSPolicy", builder => builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials().SetIsOriginAllowed((hosts) => true));
//});
//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

//builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
//builder.Services.AddOcelot(builder.Configuration);
//var app = builder.Build();
//// Configure the HTTP request pipeline.

//app.UseCors("CORSPolicy");
//app.UseHttpsRedirection();
//app.UseAuthorization();
//app.MapControllers();
//await app.UseOcelot();
//app.Run();
