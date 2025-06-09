var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();

builder.Services.AddMediatR(config =>
    config.RegisterServicesFromAssemblyContaining<Program>()
);

builder.Services.AddMarten(config =>
    config.Connection(builder.Configuration.GetConnectionString("Database")!)
);

var app = builder.Build();

app.MapCarter();

app.Run();
