using Cyberduck.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class NewConnectionDialogContent : Page
{
    public NewConnectionDialogContentViewModel ViewModel
    {
        get;
    }

    public NewConnectionDialogContent()
    {
        ViewModel = App.GetService<NewConnectionDialogContentViewModel>();
        InitializeComponent();

        DataContext = new NewConnectionDialogContentViewModel();
    }
}
