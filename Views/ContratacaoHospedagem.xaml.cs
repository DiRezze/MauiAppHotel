namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadeApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadeApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadeApp.lista_quartos;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync( new HospedagemContratada() );
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync( new Sobre() );
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

}