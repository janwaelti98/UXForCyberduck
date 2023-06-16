using Cyberduck.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class BonjourPage : Page
{
    public BonjourViewModel ViewModel
    {
        get;
    }

    public BonjourPage()
    {
        ViewModel = App.GetService<BonjourViewModel>();
        InitializeComponent();
    }
}
