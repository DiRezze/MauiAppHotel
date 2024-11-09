namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadeApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadeApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadeApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;

        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);


        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);

        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

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

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime dataSelecionada = e.NewDate;

        dtpck_checkout.MinimumDate = dataSelecionada.AddDays(1);
        dtpck_checkout.MaximumDate = dataSelecionada.AddMonths(6);
    }

}