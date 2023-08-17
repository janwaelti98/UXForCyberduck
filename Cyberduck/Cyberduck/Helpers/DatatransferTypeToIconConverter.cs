using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberduck.Core.Models;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml;

namespace Cyberduck.Helpers;

public class DatatransferTypeToIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is Datatransfer datatransfer)
        {
            return GetIconForDatatransferType(datatransfer.Type);
        }
        else if (value is DatatransferGroup datatransferGroup)
        {
            if (datatransferGroup.Items != null && datatransferGroup.Items.Any())
            {
                return GetIconForDatatransferType(datatransferGroup.Items.First().Type);
            }
        }

        return DependencyProperty.UnsetValue;
    }

    private string GetIconForDatatransferType(DatatransferTyp type)
    {
        switch (type)
        {
            case DatatransferTyp.Download:
                return "\uE896";
            case DatatransferTyp.Upload:
                return "\uE898";
            default:
                return null;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
