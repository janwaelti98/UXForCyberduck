﻿using Cyberduck.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace Cyberduck.Views;

public sealed partial class DateitransfersPage : Page
{
    public DatatransferViewModel ViewModel
    {
        get;
    }

    public DateitransfersPage()
    {
        ViewModel = App.GetService<DatatransferViewModel>();
        InitializeComponent();

        DataContext = new DatatransferViewModel();
    }
}