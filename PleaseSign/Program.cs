using PleaseSign.Extensions;
using PleaseSign.Options;
var builder = WebApplication.CreateBuilder(args);

var pleaseSignOptions = builder.Configuration.GetSection("PleaseSign");
builder.Services.Configure<PleaseSignOptions>(pleaseSignOptions);
builder.Services.AddPleaseSignHttpClient(pleaseSignOptions);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
