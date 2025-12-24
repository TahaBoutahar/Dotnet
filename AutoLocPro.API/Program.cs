var builder = WebApplication.CreateBuilder(args);

// 🔹 Controllers
builder.Services.AddControllers();

// 🔹 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 CORS (FRONTEND CONNECTION FIX)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// 🔹 Swagger always ON (dev-friendly)
app.UseSwagger();
app.UseSwaggerUI();

// 🔹 HTTPS redirection
app.UseHttpsRedirection();

// 🔹 CORS MUST be before MapControllers
app.UseCors("AllowFrontend");

// 🔹 Controllers
app.MapControllers();

app.Run();
