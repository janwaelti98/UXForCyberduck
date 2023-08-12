using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Cyberduck.Core.Models;

namespace Cyberduck.ViewModels;

public partial class DatatransferViewModel : ObservableRecipient
{

    public ObservableCollection<object> DatatransferObjects
    {
        get; set;
    }

    public DatatransferViewModel()
    {
        // Demo Items to show in UI
        DatatransferObjects = new ObservableCollection<object>
        {
            new Datatransfer
            {
                Typ = DatatransferTyp.Upload,
                FileName = "Ferien_2021",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Size = "2.3 GB",
                State = DatatransferState.InProgress,
                StateAsText = "Hochladen...",
                Progress = 46
            },
            new Datatransfer
            {
                Typ = DatatransferTyp.Download,
                FileName = "Bilder",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Size = "80 MB",
                State = DatatransferState.Critical,
                StateAsText = "Herunterladen fehlgeschlagen"
            },
            new DatatransferGroup
            {
                Items = new List<Datatransfer>
                {
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "exampleFile.txt",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "37 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "exampleFile2.txt",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "12 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "exampleFile3.txt",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "15 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                }
            },
            new Datatransfer
            {
                Typ = DatatransferTyp.Upload,
                FileName = "Ferien_2023",
                ModificationDate = new DateTime(2022, 07, 31, 15, 30, 0).ToString("dd.MM.yyyy HH:mm"),
                Size = "1.5 GB",
                State = DatatransferState.Success,
                StateAsText = "Hochladen fertig"
            },
            new DatatransferGroup
            {
                Items = new List<Datatransfer>
                {
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "Grouped Item 1",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "42 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "Grouped Item 2",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "22 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                }
            }
        };
    }
}