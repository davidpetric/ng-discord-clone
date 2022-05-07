using System.Reflection;
using System.Text.Json.Serialization;

using Application;
using Domain;
using Infrastucture;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

/*
 Use https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows
 for more info.
 
    Will throw if no user secret found.
    use either the Visual Studio: Manage User Secrets from context menu or the comand line tools
    you need to set the following key ConnectionString:DiscordDbClone
 */
builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), optional: false);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Custom registrations in different projects
builder.Services.RegisterApplicationModule();
builder.Services.RegisterInfrastuctureModule();
builder.Services.RegisterDomainModule();

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
