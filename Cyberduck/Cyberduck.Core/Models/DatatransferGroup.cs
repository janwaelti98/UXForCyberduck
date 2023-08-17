using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberduck.Core.Models;
public class DatatransferGroup
{
    public List<Datatransfer> Items
    {
        get;
        set; 
    }

    public DatatransferState State
    {
        get;
        set;
    }

    public string StateAsText
    {
        get;
        set;
    }

    public int? Progress
    {
        get;
        set;
    }
}