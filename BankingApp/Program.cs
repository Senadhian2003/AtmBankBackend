using BankingApp.Contexts;
using BankingApp.Models;
using BankingApp.Repositories;
using BankingApp.Repositories.Interface;
using BankingApp.Services;
using BankingApp.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace BankingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Repositories
            builder.Services.AddScoped<IRepository<int, User>, UserRepository>();
            builder.Services.AddScoped<IRepository<int, Transaction>, TransactionRepository>();
            builder.Services.AddScoped<IRepository<long, Card>, CardRepository>();
            builder.Services.AddScoped<IRepository<int, Atm>, AtmRepository>();
            builder.Services.AddScoped<IRepository<long, Account>, AccountRepository>();
            #endregion

            #region Services
            builder.Services.AddScoped<ITransactionService, TransactionService>();
            #endregion

            #region Context
            builder.Services.AddDbContext<AtmContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"))
                );
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
