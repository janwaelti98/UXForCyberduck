using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using Cyberduck.Core.Models;

namespace Cyberduck.Helpers;


public class DatatransferTemplateSelector : DataTemplateSelector
{
    public DataTemplate? DatatransferTemplate
    {
        get; set;
    }
    public DataTemplate? DatatransferGroupTemplate
    {
        get; set;
    }

    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
    {
        if (item is Datatransfer)
        {
            return DatatransferTemplate ?? base.SelectTemplateCore(item, container);
        }
        else if (item is DatatransferGroup)
        {
            return DatatransferGroupTemplate ?? base.SelectTemplateCore(item, container);
        }

        return base.SelectTemplateCore(item, container);
    }
}