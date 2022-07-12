using cobiWebSite.DAL.CobiDbContext;
using cobiWebSite.DAL.FrameWork;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using CobiWebSite.BLL.News.Commands;

using CobiWebSite.Model.News;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<CobiWebSiteDbContext>(c => c.UseSqlServer("Server=. ;Initial Catalog=CobiWebSite;Trusted_Connection=True;Integrated Security=True").
AddInterceptors(new AddAuditFieldInterceptor()));

builder.Services.AddMediatR(typeof(CreateNewsHandler).GetTypeInfo().Assembly);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
