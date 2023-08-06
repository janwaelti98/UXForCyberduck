using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberduck.Core.Models;
public class Datatransfer
{
    public DatatransferTyp Typ
    {
        get;
        set;
    }

    public string FileName
    {
        get;
        set;
    }

    public string ModificationDate
    {
        get;
        set;
    }

    public string Size
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
