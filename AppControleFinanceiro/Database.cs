using AppControleFinanceiro.Repositories;
using LiteDB;

namespace AppControleFinanceiro
{
    internal static class Database
    {

        public static MauiAppBuilder RegisterDataBase(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<LiteDatabase>(
                options =>
                {
                    return new LiteDatabase($"Filename={AppSettings.DatabasePath};Connection=Shared");
                });
            mauiAppBuilder.Services.AddTransient<ITransactionRepository, TransactionRepository>();
            return mauiAppBuilder;
        }
    }
}