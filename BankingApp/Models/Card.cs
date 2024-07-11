using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class Card
    {

        [Key]
        public int CardNumber { get; set; }

        public string BankName { get; set; }

        public int AccountId { get; set; }
        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }

        public string PIN { get; set; }

        public DateTime Expiry { get; set; }

    }
}
