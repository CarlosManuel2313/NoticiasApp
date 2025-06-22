using NoticiasApp.Models;
using NoticiasApp.ViewModels;

namespace NoticiasApp.Views;

public partial class UltimasPage : ContentPage
{
    private NoticiasViewModel ViewModel => (NoticiasViewModel)BindingContext;

    public UltimasPage()
    {
        InitializeComponent();
        BindingContext = App.NoticiasVM;
    }

    private void OnFavoritoClicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.BindingContext is Noticia noticia)
        {
            ViewModel.AgregarAFavoritas(noticia);
        }
    }
}
