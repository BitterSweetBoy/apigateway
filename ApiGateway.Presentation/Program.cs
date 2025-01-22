using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using eCommerce.SharedLibrary.DependecyInjection;
using Microsoft.AspNetCore.Authentication;
using ApiGateway.Presentation.Middleware;
using Ocelot.Middleware;
var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange:true);
JWTAuthenticacionScheme.AddAuthenticacionScheme(builder.Services, builder.Configuration);
builder.Services.AddOcelot().AddCacheManager(x => x.WithDictionaryHandle());
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });


});
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors();
app.UseMiddleware<AddSignatureToRequest>();
app.UseOcelot().Wait();

//app.UseAuthorization();
//app.MapControllers();

app.Run();
