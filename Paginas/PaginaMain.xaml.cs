using Microsoft.Maui.Controls;
using Proyecto2.Modelos;
using System;
using System.Linq;
using System.Windows.Input;

namespace Proyecto2.Paginas
{
    public partial class PaginaMain : FlyoutPage
    {
        // Comando para mostrar el menú flotante
        public ICommand ShowMenuCommand { get; private set; }

        public PaginaMain()
        {
            InitializeComponent();

            // Asignar el comando
            ShowMenuCommand = new Command(ShowMenu);

            // Establecer el contexto de datos para la página
            this.BindingContext = this;

            // Asegúrate de que `menuVL` está correctamente inicializado y no es null
            if (menuVL != null)
            {
                menuVL.collectionView.SelectionChanged += (sender, e) =>
                {
                    if (e.CurrentSelection.FirstOrDefault() is MenuflotanteItems selectedItem)
                    {
                        if (selectedItem.TargertType != null)
                        {
                            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedItem.TargertType));
                            IsPresented = false;
                        }
                    }
                };
            }
        }

        // Método para mostrar el menú flotante
        private void ShowMenu()
        {
            // Mostrar el menú flotante
            IsPresented = true;
        }
    }
}
