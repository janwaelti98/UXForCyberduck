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
    Dictionary<string, bool> bandwidths = new Dictionary<string, bool>();


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

        bandwidths["Unlimitierte Bandbreite"] = true;
        bandwidths["5 KB/s"] = false;
        bandwidths["10 KB/s"] = false;
        bandwidths["20 KB/s"] = false;
        bandwidths["50 KB/s"] = false;
        bandwidths["100 KB/s"] = false;
        bandwidths["150 KB/s"] = false;
        bandwidths["200 KB/s"] = false;
        bandwidths["500 KB/s"] = false;
        bandwidths["1 MB/s"] = false;
        bandwidths["2 MB/s"] = false;
        bandwidths["5 MB/s"] = false;
        bandwidths["10 MB/s"] = false;
        bandwidths["15 MB/s"] = false;
        bandwidths["20 MB/s"] = false;
        bandwidths["50 MB/s"] = false;
        bandwidths["100 MB/s"] = false;

        UpdateConnectionsMenu();
        UpdateBandwidthsMenu();
    }


    private void ConnectionMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleMenuFlyoutItem)
        {
            UpdateConnections(sender, e);
            UpdateConnectionsMenu();
        }
    }

    public void UpdateConnectionsMenu()
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

    public void UpdateConnections(object sender, RoutedEventArgs e)
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

    private void BandwithMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleMenuFlyoutItem)
        {
            UpdateBandwidths(sender, e);
            UpdateBandwidthsMenu();
        }
    }

    public void UpdateBandwidthsMenu()
    {
        var i = 0;
        foreach (Object item in bandwidthMenuFlyoutSubItem.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                toggleItem.IsChecked = bandwidths.ElementAt(i).Value;
                i++;
            }
        }

        i = 0;
        foreach (Object item in bandwithMenuFlyout.Items)
        {
            if (item is ToggleMenuFlyoutItem)
            {
                ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)item;
                toggleItem.IsChecked = bandwidths.ElementAt(i).Value;
                i++;
            }
        }
    }

    public void UpdateBandwidths(object sender, RoutedEventArgs e)
    {
        // set all values to false
        bandwidths = bandwidths.ToDictionary(c => c.Key, c => false);

        if (sender is ToggleMenuFlyoutItem)
        {
            ToggleMenuFlyoutItem toggleItem = (ToggleMenuFlyoutItem)sender;
            bandwidths[toggleItem.Text] = true;
            selectedBandwidthMenuItemText.Text = toggleItem.Text;
        }
    }

}