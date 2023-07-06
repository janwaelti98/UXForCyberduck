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
                Size = "8 KiB",
                State = DatatransferState.Success
            },
            new Datatransfer
            {
                Typ = DatatransferTyp.Download,
                FileName = "Bilder",
                ModificationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                Size = "8 KiB",
                State = DatatransferState.Success
            }
        };
    }
}
