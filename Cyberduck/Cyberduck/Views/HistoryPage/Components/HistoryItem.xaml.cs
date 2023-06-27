using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace Cyberduck.Views.HistoryPage.Components;
public sealed partial class HistoryItem : UserControl
{
    public HistoryItem()
    {
        InitializeComponent();
    }

    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register("Icon", typeof(string), typeof(HistoryItem), new PropertyMetadata(null));

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public string CurrentDateTime => DateTime.Now.ToString("dd.MM.yyyy HH:mm");

}



public class IconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var iconString = value as string;

        if (!string.IsNullOrEmpty(iconString))
        {
            if (iconString.StartsWith("&#x"))
            {
                var iconCode = iconString.Replace("&#x", string.Empty);
                var iconValue = ushort.Parse(iconCode, NumberStyles.HexNumber);
                return char.ConvertFromUtf32(iconValue);
            }
        }

        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}