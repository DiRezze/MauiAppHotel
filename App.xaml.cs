using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                descricao = "Suíte Super Luxo",
                diariaAdulto = 110.0,
                diariaCrianca = 55.0
            },
            new Quarto()
            {
                descricao = "Suíte Luxo",
                diariaAdulto = 80.0,
                diariaCrianca = 40.0
            },
            new Quarto()
            {
                descricao = "Suíte Single",
                diariaAdulto = 50,
                diariaCrianca = 25
            },
            new Quarto()
            {
                descricao = "Suíte Crise",
                diariaAdulto = 25,
                diariaCrianca = 12.5
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 600;
            window.Width = 400;

            return window;
        }

    }
}
