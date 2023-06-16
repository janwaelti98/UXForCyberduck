using Cyberduck.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class LesezeichenPage : Page
{
    public LesezeichenViewModel ViewModel
    {
        get;
    }

    public LesezeichenPage()
    {
        ViewModel = App.GetService<LesezeichenViewModel>();
        InitializeComponent();
    }
}
