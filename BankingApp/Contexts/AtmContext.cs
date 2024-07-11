using BankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Contexts
{
    public class AtmContext : DbContext
    {
        public AtmContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Card> Cards { get; set; }

    }

}
