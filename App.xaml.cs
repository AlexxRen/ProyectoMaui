using Proyecto2.Paginas;

namespace Proyecto2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Login());
    }
}
