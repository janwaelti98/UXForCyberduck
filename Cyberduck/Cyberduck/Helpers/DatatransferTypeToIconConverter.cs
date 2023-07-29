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
        if (value is DatatransferTyp type)
        {
            switch (type)
            {
                case DatatransferTyp.Download:
                    return "\uE896"; // Use the appropriate Unicode value for the download icon
                case DatatransferTyp.Upload:
                    return "\uE898"; // Use the appropriate Unicode value for the upload icon
                                     // Add more cases for other DatatransferTyp values if needed
            }
        }

        return DependencyProperty.UnsetValue; // Default value if no match found
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
