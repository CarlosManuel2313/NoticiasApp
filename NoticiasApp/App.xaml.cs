using NoticiasApp.ViewModels;
using Microsoft.Maui.Controls;

namespace NoticiasApp;

public partial class App : Application
{
    public static NoticiasViewModel NoticiasVM { get; private set; } = new NoticiasViewModel();

    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
