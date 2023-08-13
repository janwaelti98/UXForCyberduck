using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Cyberduck.Core.Models;

namespace Cyberduck.ViewModels;

public partial class BookmarksViewModel : ObservableRecipient
{
    public ObservableCollection<object> BookmarkObjects
    {
        get; set;
    }

    public BookmarksViewModel()
    {
        // Demo Items to show in UI
        BookmarkObjects = new ObservableCollection<object>
        {
            new Bookmark
            {
                Icon = "E700",
                ConnectionName = "Legacy",
                ConnectionAdress = "ftp://ftp.example.com",
                Username = "johndoe",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Tags = new List<Tag>
                {
                    new Tag { Tagname = "Arbeit", Color = "#fcba03" },
                    new Tag { Tagname = "Example Tag 1", Color = "#c95c2e" },
                    new Tag { Tagname = "Example Tag 2", Color = "#306fb8" }
                },
                Type = "Verbindung"
            },
            new Bookmark
            {
                Icon = "E707",
                ConnectionName = "OneDrive - privat",
                ConnectionAdress = "onedrive.live.com/privat",
                Username = "johndoe@hotmail.com",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Tags = new List<Tag>
                {
                    new Tag { Tagname = "Privat", Color = "#82aa45" },
                    new Tag { Tagname = "Example Tag 1", Color = "#c95c2e" }
                },
                Type = "Verbindung"
            },
            new BookmarkGroup
            {
                Name ="Eine Lesezeichen-Gruppe",
                Items = new List<Bookmark>
                {
                    new Bookmark
                    {
                        Icon = "E707",
                        ConnectionName = "OneDrive - privat",
                        ConnectionAdress = "onedrive.live.com/privat",
                        Username = "johndoe@hotmail.com",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Tags = new List<Tag>
                        {
                            new Tag { Tagname = "Privat", Color = "#c95c2e" },
                        },
                        Type = "Verbindung"
                    },
                    new Bookmark
                    {
                        Icon = "E707",
                        ConnectionName = "Geschäftsbericht_2021",
                        ConnectionAdress = "s3.amazonaws.com/mybucket/2021",
                        Username = "johndoe@aws.com",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Tags = new List<Tag>
                        {
                            new Tag { Tagname = "Arbeit", Color = "#fcba03" },
                        },
                        Type = "Verbindung"
                    },
                    new Bookmark
                    {
                        Icon = "E707",
                        ConnectionName = "Legacy",
                        ConnectionAdress = "ftp://ftp.example.com/legacy",
                        Username = "johndoe",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Type = "Verbindung"
                    },
                },
                Tags = new List<Tag>
                {
                     new Tag { Tagname = "Privat", Color = "#c95c2e" },
                     new Tag { Tagname = "Arbeit", Color = "#fcba03" },
                }
            },
        };
    }
}