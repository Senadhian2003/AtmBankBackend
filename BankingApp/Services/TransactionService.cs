using BankingApp.Exceptions;
using BankingApp.Models;
using BankingApp.Models.DTO;
using BankingApp.Repositories.Interface;

namespace BankingApp.Services
{
    public class TransactionService
    {
        
        private readonly IRepository<long, Card> _cardRepository;
        private readonly IRepository<int, Account> _accountRepository;
        private readonly IRepository<int, Transaction> _transactionRepository;
        private readonly IRepository<int, Atm> _atmRepository;

        public TransactionService(IRepository<int, Atm> atmRepository, IRepository<long, Card> cardRepository, IRepository<int, Account> accountRepository, IRepository<int, Transaction> transactionRepository) {
            
            _cardRepository = cardRepository;
            _accountRepository = accountRepository;
            _transactionRepository = transactionRepository;
            _atmRepository = atmRepository;

            
        }


        public async Task<string> Withdraw(WithdrawDTO dto )
        {

            Card card = await _cardRepository.GetByKey(dto.CardNumber);

            if (card != null) {
                
                if(card.PIN!=dto.PIN)
                {
                    throw new UnauthorizedUserException("Invalid card number or PIN");
                }

                Account account = await _accountRepository.GetByKey(card.AccountId);

                

                if(account.CurrentAmount < dto.Amount)
                {
                    throw new InsufficientFundsException("You have less amount in your account than withdraw request");
                }

                account.CurrentAmount-= dto.Amount;

                await _accountRepository.Update(account);

                return "Successful Withdraw";


                
            }

            return "Unsuccessful";


        }



    }
}
