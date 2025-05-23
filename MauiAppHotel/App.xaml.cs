
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo", 
                valorDiariaAdulto = 110.0,
                valorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                valorDiariaAdulto = 80.0,
                valorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                valorDiariaAdulto = 25,
                valorDiariaCrianca = 12.5
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                valorDiariaAdulto = 110.0,
                valorDiariaCrianca = 55.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Views.ContratacaoHospedagem());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;
            
            return window;
        }

    }
}