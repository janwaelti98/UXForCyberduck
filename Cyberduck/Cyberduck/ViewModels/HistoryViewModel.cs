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
        // Demo Items to show in UI
        HistoryItems = new ObservableCollection<HistoryItem>
        {
            new HistoryItem
            {
                Icon = "E700",
                ConnectionName = "Legacy",
                ConnectionAdress = "ftp://ftp.example.com",
                Username = "johndoe",
                ModificationDate = "25.03.2023 11:49",
                Tags = new List<Tag>
                    {
                       new Tag { Tagname = "Example Tag 1", Color = "#c95c2e" },
                       new Tag { Tagname = "Example Tag 2", Color = "#306fb8" }
                    }
            },
            new HistoryItem
            {
                Icon = "E707",
                ConnectionName = "OneDrive - privat",
                ConnectionAdress = "onedrive.live.com/privat",
                Username = "johndoe@hotmail.com",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Tags = new List<Tag>
                    {
                       new Tag { Tagname = "Privat", Color = "#82aa45" },
                    }
            }
        };
    }
}
