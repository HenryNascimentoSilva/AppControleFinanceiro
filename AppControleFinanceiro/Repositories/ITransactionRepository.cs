using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Repositories
{
    public interface ITransactionRepository
    {
        void Add(TransactionModel transaction);
        void Delete(TransactionModel transaction);
        List<TransactionModel> GetAllTransactions();
        void Update(TransactionModel transaction);
    }
}