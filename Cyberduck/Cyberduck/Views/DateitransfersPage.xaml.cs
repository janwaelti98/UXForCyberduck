using Cyberduck.ViewModels;
using Microsoft.UI.Xaml;
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



    private ToggleMenuFlyoutItem selectedConnectionMenuItem;
    private ToggleMenuFlyoutItem selectedBandwidthMenuItem;

    //TODO: fix "automatic" selection
    private void ConnectionMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleMenuFlyoutItem selectedItem)
        {
            if (selectedConnectionMenuItem != null)
            {
                selectedConnectionMenuItem.IsChecked = false;
            }

            selectedItem.IsChecked = true;
            selectedConnectionMenuItem = selectedItem;

            selectedConnectionMenuItemText.Text = selectedItem.Text; // Update text in UI
        }
    }

    //TODO: fix "automatic" selection
    private void BandwithMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleMenuFlyoutItem selectedItem)
        {
            if (selectedBandwidthMenuItem != null)
            {
                selectedBandwidthMenuItem.IsChecked = false;
            }

            selectedItem.IsChecked = true;
            selectedBandwidthMenuItem = selectedItem;

            selectedBandwidthMenuItemText.Text = selectedItem.Text; // Update text in UI
        }
    }
}