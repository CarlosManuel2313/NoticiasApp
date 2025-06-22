using NoticiasApp.ViewModels;

namespace NoticiasApp.Views;

public partial class FavoritasPage : ContentPage
{
    public FavoritasPage()
    {
        InitializeComponent();
        BindingContext = App.NoticiasVM;
    }
}
