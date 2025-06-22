using NoticiasApp.Models;
using NoticiasApp.ViewModels;

namespace NoticiasApp.Views;

public partial class TodasPage : ContentPage
{
    private NoticiasViewModel ViewModel => (NoticiasViewModel)BindingContext;


    public TodasPage()
    {
        InitializeComponent();
        BindingContext = App.NoticiasVM;
    }

    private async void OnFavoritoClicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.BindingContext is Noticia noticia)
        {
            var vm = (NoticiasViewModel)BindingContext;
            vm.AgregarAFavoritas(noticia);

            var originalColor = btn.BackgroundColor;
            btn.BackgroundColor = Colors.Red;
            await Task.Delay(500);
            btn.BackgroundColor = originalColor;

            btn.Text = "Agregado";
            btn.IsEnabled = false;
        }
    }
}