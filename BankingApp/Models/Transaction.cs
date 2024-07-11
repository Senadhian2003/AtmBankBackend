using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class Transaction
    {

        public int Id { get; set; }

        public int CardNumber { get; set; }
        [ForeignKey(nameof(CardNumber))]
        public Card? Card { get; set; }


        public int AccountId { get; set; }
        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }

        public string TransactionType { get; set; }

        public double TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }

    }
}
