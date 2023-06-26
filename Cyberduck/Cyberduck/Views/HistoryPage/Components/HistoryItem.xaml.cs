using System;
using System.Collections.Generic;
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
        this.InitializeComponent();
    }

    public string CurrentDateTime => DateTime.Now.ToString("dd.MM.yyyy HH:mm");
}
