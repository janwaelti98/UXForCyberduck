using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Cyberduck.Core.Models;

namespace Cyberduck.ViewModels;

public partial class DatatransferViewModel : ObservableRecipient
{

    public ObservableCollection<Datatransfer> Datatransfers
    {
        get; set;
    }

    public ObservableCollection<DatatransferGroup> DatatransferGroups
    {
        get; set; 
    }


    public DatatransferViewModel()
    {
        // Demo Items to show in UI
        Datatransfers = new ObservableCollection<Datatransfer>
        {
            new Datatransfer
            {
                Typ = DatatransferTyp.Download,
                FileName = "Bilder",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Size = "80 MB",
                State = DatatransferState.Success,
                StateAsText = "Herunterladen fertig..."
            },
            new Datatransfer
            {
                Typ = DatatransferTyp.Upload,
                FileName = "Ferien_2023",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Size = "1.5 GB",
                State = DatatransferState.Success,
                StateAsText = "Hochladen fertig..."
            }
        };

        DatatransferGroups = new ObservableCollection<DatatransferGroup>
        {
            new DatatransferGroup
            {
                Items = new List<Datatransfer>
                {
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "Grouped Item 1",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "10 KiB",
                        State = DatatransferState.Success
                    },
                    new Datatransfer
                    {
                        Typ = DatatransferTyp.Download,
                        FileName = "Grouped Item 2",
                        ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                        Size = "12 KiB",
                        State = DatatransferState.Success
                    },
                }
            }
        };
    }
}
