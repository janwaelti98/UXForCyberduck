using System;
using Cyberduck.Core.Models;
using Microsoft.UI.Xaml.Data;

namespace Cyberduck.Helpers;

public class StateToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is DatatransferState state)
        {
            return state == DatatransferState.InProgress ? Microsoft.UI.Xaml.Visibility.Visible : Microsoft.UI.Xaml.Visibility.Collapsed;
        }
        return Microsoft.UI.Xaml.Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotSupportedException();
    }
}