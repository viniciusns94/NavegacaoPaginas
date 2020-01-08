using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavegacaoPaginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageExemplo : ContentPage
    {
        public PageExemplo()
        {
            InitializeComponent();
        }

        private async void ButtonPageExemploClickedAsync(object sender, EventArgs e)
        {
            // await Navigation.PopToRootAsync(); //desempilha todas as paginas menos a página raíz
            await Navigation.PopAsync();
        }
    }
}