using Microsoft.Maui.Controls;
using System;

namespace Proyecto2.Paginas
{
    public partial class MenuFlotante : ContentPage
    {
        public MenuFlotante()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PopToRootAsync();
        }
    }
}
