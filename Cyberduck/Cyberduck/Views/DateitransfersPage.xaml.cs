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

        UpdateMenuFlyoutSubItem();
    }


    private ToggleMenuFlyoutItem selectedBandwidthMenuItem;

    private void ConnectionMenuItem_Click(object sender, RoutedEventArgs e)
    {
        // Check if sender is ToggleMenuFlyoutItem
        if (sender is ToggleMenuFlyoutItem)
        {
            UncheckAllToggleMenuFlyoutItems();

            // Set the clicked item to checked after the reset
            ToggleMenuFlyoutItem item = (ToggleMenuFlyoutItem)sender;
            item.IsChecked = true;

            UpdateMenuFlyoutSubItem();
        }
    }

    public void UpdateMenuFlyoutSubItem()
    {
        foreach (Object item in ConnectionMenuFlyoutSubItem.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                if(toggleItem.IsChecked)
                {
                    selectedConnectionMenuItemText.Text = toggleItem.Text;
                }
            }
        }

        foreach (Object item in connectionMenuFlyout.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                if (toggleItem.IsChecked)
                {
                    selectedConnectionMenuItemText.Text = toggleItem.Text;
                }
            }
        }
    }

    public void UncheckAllToggleMenuFlyoutItems()
    {
        foreach(Object item in ConnectionMenuFlyoutSubItem.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                toggleItem.IsChecked = false;
            }
        }

        foreach(Object item in connectionMenuFlyout.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                toggleItem.IsChecked = false;
            }
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