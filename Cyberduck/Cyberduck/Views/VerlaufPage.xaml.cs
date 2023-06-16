using Cyberduck.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class VerlaufPage : Page
{
    public VerlaufViewModel ViewModel
    {
        get;
    }

    public VerlaufPage()
    {
        ViewModel = App.GetService<VerlaufViewModel>();
        InitializeComponent();
    }
}
