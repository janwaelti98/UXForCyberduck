using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberduck.Core.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace Cyberduck.Helpers;
public class DatatransferStateToIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is DatatransferState state)
        {
            switch (state)
            {
                case DatatransferState.Success:
                    return Application.Current.Resources["SuccessIconInfoBadgeStyle"];
                case DatatransferState.InProgress:
                    return Application.Current.Resources["AttentionIconInfoBadgeStyle"];
                case DatatransferState.Critical:
                    return Application.Current.Resources["CriticalIconInfoBadgeStyle"];
            }
        }

        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
