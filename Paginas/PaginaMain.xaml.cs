using Microsoft.Maui.Controls;
using Proyecto2.Modelos;
using System;
using System.Linq;
using System.Windows.Input;

namespace Proyecto2.Paginas
{
    public partial class PaginaMain : FlyoutPage
    {
        // Comando para mostrar el men� flotante
        public ICommand ShowMenuCommand { get; private set; }

        public PaginaMain()
        {
            InitializeComponent();

            // Asignar el comando
            ShowMenuCommand = new Command(ShowMenu);

            // Establecer el contexto de datos para la p�gina
            this.BindingContext = this;

            // Aseg�rate de que `menuVL` est� correctamente inicializado y no es null
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

        // M�todo para mostrar el men� flotante
        private void ShowMenu()
        {
            // Mostrar el men� flotante
            IsPresented = true;
        }
    }
}
