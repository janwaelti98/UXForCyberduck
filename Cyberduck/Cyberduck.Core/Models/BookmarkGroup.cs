using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberduck.Core.Models;
public class BookmarkGroup
{
    public string Name
    {
        get;
        set;
    }

    public List<Bookmark> Items
    {
        get;
        set;
    }

    public List<Tag> Tags
    {
        get;
        set;
    }
}