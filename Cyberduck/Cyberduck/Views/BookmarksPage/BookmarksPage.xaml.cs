using Cyberduck.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class LesezeichenPage : Page
{
    public BookmarksViewModel ViewModel
    {
        get;
    }

    public LesezeichenPage()
    {
        ViewModel = App.GetService<BookmarksViewModel>();
        InitializeComponent();

        DataContext = new BookmarksViewModel();
    }
}