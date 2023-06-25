using System.Diagnostics;
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

    // stores values for connection flyoutMenu
    Dictionary<string, bool> connections = new Dictionary<string, bool>();

    public DateitransfersPage()
    {
        ViewModel = App.GetService<DateitransfersViewModel>();
        InitializeComponent();


        // initializes default values
        connections["Automatisch"] = true;
        connections["1 Verbindung"] = false;
        connections["2 Verbindungen"] = false;
        connections["3 Verbindungen"] = false;
        connections["4 Verbindungen"] = false;
        connections["5 Verbindungen"] = false;
        connections["10 Verbindungen"] = false;
        connections["15 Verbindungen"] = false;
        connections["20 Verbindungen"] = false;

        UpdateMenuFlyoutSubItem();
    }


    private ToggleMenuFlyoutItem selectedBandwidthMenuItem;

    private void ConnectionMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleMenuFlyoutItem)
        {
            UpdateDictionary(sender, e);
            UpdateMenuFlyoutSubItem();
        }
    }

    public void UpdateMenuFlyoutSubItem()
    {
        var i = 0;
        foreach (Object item in connectionMenuFlyoutSubItem.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                toggleItem.IsChecked = connections.ElementAt(i).Value;
                i++;  
            }
        }

         i = 0;
        foreach (Object item in connectionMenuFlyout.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                toggleItem.IsChecked = connections.ElementAt(i).Value;
                i++;
            }
        }
    }

    public void UpdateDictionary(object sender, RoutedEventArgs e)
    {
        // set all values to false
        connections = connections.ToDictionary(c => c.Key, c => false);

        if (sender is ToggleMenuFlyoutItem)
        {
            ToggleMenuFlyoutItem toggleItem  = (ToggleMenuFlyoutItem)sender;
            connections[toggleItem.Text] = true;
            selectedConnectionMenuItemText.Text = toggleItem.Text;
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