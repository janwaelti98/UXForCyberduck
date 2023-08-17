using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using Cyberduck.Core.Models;

namespace Cyberduck.Helpers;
public class BookmarkTemplateSelector : DataTemplateSelector
{
    public DataTemplate? BookmarkTemplate
    {
        get; set;
    }
    public DataTemplate? BookmarkGroupTemplate
    {
        get; set;
    }

    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
    {
        if (item is Bookmark)
        {
            return BookmarkTemplate ?? base.SelectTemplateCore(item, container);
        }
        else if (item is BookmarkGroup)
        {
            return BookmarkGroupTemplate ?? base.SelectTemplateCore(item, container);
        }

        return base.SelectTemplateCore(item, container);
    }

}
