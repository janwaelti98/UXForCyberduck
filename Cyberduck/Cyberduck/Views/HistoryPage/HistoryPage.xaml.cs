using System.Collections.ObjectModel;
using Cyberduck.ViewModels;
using Cyberduck.Views.HistoryPage.Components;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class VerlaufPage : Page
{
    public HistoryViewModel ViewModel
    {
        get;
    }

    public VerlaufPage()
    {
        ViewModel = App.GetService<HistoryViewModel>();
        InitializeComponent();

        DataContext = new HistoryViewModel();
    }

}
