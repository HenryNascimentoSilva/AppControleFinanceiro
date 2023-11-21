namespace AppControleFinanceiro.Views;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		InitializeComponent();
	}

	private void GoToAdd(object sender, EventArgs args)
	{
		App.Current.MainPage = new TransactionAdd();
	}
}