using Application;
using Infrastructure;
using PublicApi.Middleware;
using PublicApi.Filters;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddControllers();


    // Exception Filter Attribute:
    // builder.Services.AddControllers(options =>
    // {
    //     options.Filters.Add<ErrorHandlingFilterAttribute>();
    // });

    builder.Services.AddEndpointsApiExplorer(); // configuring Swagger/OpenAPI: https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddSwaggerGen();
}


var app = builder.Build();
{
    // Startup Configs
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // Exception Middleware:
    // app.UseMiddleware<ErrorHandlingMiddleware>();

    // Exception Endpoint:
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
