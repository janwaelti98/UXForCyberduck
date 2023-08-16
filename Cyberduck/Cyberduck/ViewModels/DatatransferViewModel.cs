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
                Type = DatatransferTyp.Upload,
                FileName = "Ferien_2023",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Size = "2.3 GB",
                State = DatatransferState.InProgress,
                StateAsText = "Hochladen...",
                Progress = 46
            },
            new Datatransfer
            {
                Type = DatatransferTyp.Download,
                FileName = "Bilder",
                ModificationDate = "27.07.2023 18:59",
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
                        Type = DatatransferTyp.Download,
                        FileName = "exampleFile.txt",
                        ModificationDate = "24.07.2023 17:43",
                        Size = "37 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Type = DatatransferTyp.Download,
                        FileName = "exampleFile2.txt",
                        ModificationDate = "24.07.2023 17:43",
                        Size = "12 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Type = DatatransferTyp.Download,
                        FileName = "exampleFile3.txt",
                        ModificationDate = "24.07.2023 17:43",
                        Size = "15 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                }
            },
            new Datatransfer
            {
                Type = DatatransferTyp.Upload,
                FileName = "Ferien_2021",
                ModificationDate = "18.06.2023 15:30",
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
                        Type = DatatransferTyp.Download,
                        FileName = "Portugal_2022_01.jpg",
                        ModificationDate = "21.05.2023 09:23",
                        Size = "15 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Type = DatatransferTyp.Download,
                        FileName = "Portugal_2022_02.jpg",
                        ModificationDate = "21.05.2023 09:23",
                        Size = "14 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Type = DatatransferTyp.Download,
                        FileName = "Portugal_2022_03.jpg",
                        ModificationDate = "21.05.2023 09:23",
                        Size = "12 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Type = DatatransferTyp.Download,
                        FileName = "Portugal_2022_04.jpg",
                        ModificationDate = "21.05.2023 09:22",
                        Size = "10 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                    new Datatransfer
                    {
                        Type = DatatransferTyp.Download,
                        FileName = "Portugal_2022_05.jpg",
                        ModificationDate = "21.05.2023 09:22",
                        Size = "13 KiB",
                        State = DatatransferState.Success,
                        StateAsText = "Herunterladen fertig"
                    },
                }
            }
        };
    }
}