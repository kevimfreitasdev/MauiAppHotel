namespace MauiAppHotel.Views;

public partial class dev : ContentPage
{
	public dev()
	{
        InitializeComponent();
	}


    private async void Button_Clicked(object sender, EventArgs e) => App.Current.MainPage = new ContratacaoHospedagem();
}