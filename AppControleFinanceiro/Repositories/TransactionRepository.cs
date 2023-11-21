using AppControleFinanceiro.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase database;
        private readonly string collectionName = "Transactions";

        TransactionRepository(LiteDatabase liteDatabase)
        {
            database = liteDatabase;
        }

        public List<TransactionModel> GetAllTransactions()
        {
             return database
                    .GetCollection<TransactionModel>(collectionName)
                    .Query()
                    .OrderByDescending(x => x.Date)
                    .ToList();
        }

        public void Add(TransactionModel transaction)
        {
            var collection = database.GetCollection<TransactionModel>(collectionName);
            collection.Insert(transaction);
            collection.EnsureIndex(x => x.Date);
        }

        public void Update(TransactionModel transaction)
        {
            var collection = database.GetCollection<TransactionModel>(collectionName);
            collection.Update(transaction);
        }

        public void Delete(TransactionModel transaction)
        {
            var collection = database.GetCollection<TransactionModel>(collectionName);
            collection.Delete(transaction.Id);
        }

    }
}
