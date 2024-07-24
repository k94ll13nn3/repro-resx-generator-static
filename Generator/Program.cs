using Generator;
using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization();

var app = builder.Build();

app.MapGet("/", (IStringLocalizer<SharedResources> stringLocalizer) => stringLocalizer[nameof(SharedResources.HelloWorld)]);

app.Run();