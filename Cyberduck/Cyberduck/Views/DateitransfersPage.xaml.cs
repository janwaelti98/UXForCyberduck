using Cyberduck.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class DateitransfersPage : Page
{
    public DateitransfersViewModel ViewModel
    {
        get;
    }

    public DateitransfersPage()
    {
        ViewModel = App.GetService<DateitransfersViewModel>();
        InitializeComponent();
    }
}
