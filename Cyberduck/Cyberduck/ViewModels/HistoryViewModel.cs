using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Cyberduck.Core.Models;

namespace Cyberduck.ViewModels;

public partial class HistoryViewModel : ObservableRecipient
{
    public ObservableCollection<HistoryItem> HistoryItems
    {
        get; set;
    }

    public HistoryViewModel()
    {
        HistoryItems = new ObservableCollection<HistoryItem>
        {
            new HistoryItem { Icon = "E700", Name = "Test"},
            new HistoryItem { Icon = "E707", Name = "Test3"}
        };
    }
}
