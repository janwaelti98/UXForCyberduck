﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberduck.Core.Models;
public class HistoryItem
{
    public string Icon
    {
        get;
        set;
    }

    public string ConnectionName
    {
        get;
        set;
    }
    public string ConnectionAdress
    {
        get;
        set;
    }
    public string Username
    {
        get;
        set;
    }

    public List<Tag> Tags
    {
        get;
        set;
    }
    public string ModificationDate
    {
        get;
        set;
    }

    public string Type
    {
        get;
        set;
    }
}
