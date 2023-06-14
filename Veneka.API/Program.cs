using CommunityProject.Repository;
using CommunityProject.Repository.Implementations;
using CommunityProject.Repository.Interfaces;
using CommunityProject.Services.Implementations;
using CommunityProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register your services and dependencies

builder.Services.AddScoped<ICommunityProjectService, CommunityProjectService>();
builder.Services.AddScoped<ISponsorshipPlanService, SponsorshipPlanService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddScoped<ICommunityProjectRepository, CommunityProjectRepository>();
builder.Services.AddScoped<ISponsorshipPlanRepository, SponsorshipPlanRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CommunityProjectConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Seed the database with initial data

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    DataSeeder.SeedData(dbContext);
}

app.MapControllers();

app.Run();
