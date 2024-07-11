﻿using BankingApp.Models;
using BankingApp.Repositories.Interface;
using BankingApp.Exceptions;

namespace BankingApp.Repositories
{
    public class CardRepository : IRepository<int, Card>
    {

        private readonly LibraryManagementContext _context;
        public CardRepository(LibraryManagementContext context)
        {
            _context = context;
        }
        public async Task<Card> Add(Card item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Card> DeleteByKey(int key)
        {
            var card = await GetByKey(key);
            if (card != null)
            {
                _context.Remove(card);
                await _context.SaveChangesAsync(true);
                return card;
            }
            throw new ElementNotFoundException("Card");
        }

        public async Task<Card> GetByKey(int key)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(u => u.CardNumber == key);

            if (card != null)
            {
                return card;
            }

            throw new ElementNotFoundException("Card");
        }

        public async Task<IEnumerable<Card>> GetAll()
        {
            var cards = await _context.Cards.ToListAsync();

            if (cards.Any())
            {
                return cards;
            }

            throw new EmptyListException("Card");

        }

        public async Task<Card> Update(Card item)
        {
            var card = await GetByKey(item.CardNumber);
            if (card != null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync(true);
                return card;
            }
            throw new ElementNotFoundException("Card");
        }

    }
}
