using Microsoft.Maui.Controls;

namespace Proyecto2.Paginas
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = inputEmai.Text;
            string password = inputPsw.Text;

            if (email == "teste" && password == "1234")
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PaginaMain());
            }
            else
            {
                await DisplayAlert("Error", "Email o contraseña incorrectos", "OK");
            }
        }
    }
}
