﻿using Cyberduck.Contracts.Services;
using Cyberduck.Helpers;
using Cyberduck.Services;
using Cyberduck.ViewModels;
using Cyberduck.Views.Dialogs;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;

using Windows.System;

namespace Cyberduck.Views;

public sealed partial class ShellPage : Page
{
    public ShellViewModel ViewModel
    {
        get;
    }

    public ShellPage(ShellViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();

        ViewModel.NavigationService.Frame = NavigationFrame;
        ViewModel.NavigationViewService.Initialize(NavigationViewControl);

        // A custom title bar is required for full window theme and Mica support.
        // https://docs.microsoft.com/windows/apps/develop/title-bar?tabs=winui3#full-customization
        App.MainWindow.ExtendsContentIntoTitleBar = true;
        App.MainWindow.SetTitleBar(AppTitleBar);
        App.MainWindow.Activated += MainWindow_Activated;
        AppTitleBarText.Text = "AppDisplayName".GetLocalized();
    }

    private void OnLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TitleBarHelper.UpdateTitleBar(RequestedTheme);

        KeyboardAccelerators.Add(BuildKeyboardAccelerator(VirtualKey.Left, VirtualKeyModifiers.Menu));
        KeyboardAccelerators.Add(BuildKeyboardAccelerator(VirtualKey.GoBack));
    }

    private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
    {
        var resource = args.WindowActivationState == WindowActivationState.Deactivated ? "WindowCaptionForegroundDisabled" : "WindowCaptionForeground";

        AppTitleBarText.Foreground = (SolidColorBrush)App.Current.Resources[resource];
        App.AppTitlebar = AppTitleBarText as UIElement;
    }

    private void NavigationViewControl_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
    {
        AppTitleBar.Margin = new Thickness()
        {
            Left = sender.CompactPaneLength * (sender.DisplayMode == NavigationViewDisplayMode.Minimal ? 2 : 1),
            Top = AppTitleBar.Margin.Top,
            Right = AppTitleBar.Margin.Right,
            Bottom = AppTitleBar.Margin.Bottom
        };
    }


    private static KeyboardAccelerator BuildKeyboardAccelerator(VirtualKey key, VirtualKeyModifiers? modifiers = null)
    {
        var keyboardAccelerator = new KeyboardAccelerator() { Key = key };

        if (modifiers.HasValue)
        {
            keyboardAccelerator.Modifiers = modifiers.Value;
        }

        keyboardAccelerator.Invoked += OnKeyboardAcceleratorInvoked;

        return keyboardAccelerator;
    }

    private static void OnKeyboardAcceleratorInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        var navigationService = App.GetService<INavigationService>();

        var result = navigationService.GoBack();

        args.Handled = result;
    }

    private async void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.SelectedItem is NavigationViewItem selectedNavItem)
        {
            if (selectedNavItem == NewConnectionNavItem)
            {
                // Öffne das Dialogfenster für "Neue Verbindung erstellen"
                 await DisplayNewConnectionDialog();
            }
        }
    }

    private async Task DisplayNewConnectionDialog()
    {
        ContentDialog newConnectionDialog = new ContentDialog();

        // Set the theme of the dialog based on the current theme
        var themeSelectorService = App.GetService<IThemeSelectorService>();
        newConnectionDialog.RequestedTheme = themeSelectorService.Theme;

        newConnectionDialog.XamlRoot = this.XamlRoot;
        newConnectionDialog.Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style;
        newConnectionDialog.Title = "Neue Verbindung erstellen";
        newConnectionDialog.PrimaryButtonText = "Manuelle Verbindung erstellen";
        newConnectionDialog.CloseButtonText = "Abbrechen";
        newConnectionDialog.DefaultButton = ContentDialogButton.Primary;
        newConnectionDialog.Content = new NewConnectionDialogContent();

        // Handle PrimaryButtonClick event
        newConnectionDialog.PrimaryButtonClick += async (sender, args) =>
        {
            // Close the current dialog
            newConnectionDialog.Hide();

            // Show content dialog for manual connection
            ContentDialog manualConnectionDialog = new ContentDialog();

            // Set the theme of the dialog based on the current theme
            manualConnectionDialog.RequestedTheme = themeSelectorService.Theme;

            manualConnectionDialog.XamlRoot = this.XamlRoot;
            manualConnectionDialog.Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style;
            manualConnectionDialog.Title = "Manuelle Verbindung erstellen";
            manualConnectionDialog.PrimaryButtonText = "Verbinden";
            manualConnectionDialog.CloseButtonText = "Abbrechen";
            manualConnectionDialog.DefaultButton = ContentDialogButton.Primary;
            manualConnectionDialog.Content = new ManualConnectionDialogContent();

            await manualConnectionDialog.ShowAsync();
        };

        await newConnectionDialog.ShowAsync();
    }

    // Handle text change and present suitable items
    private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
        // Since selecting an item will also change the text,
        // only listen to changes caused by user entering text.
        if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
        {
           //TODO
        }
    }

    // Handle user selecting an item, in our case just output the selected item.
    private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
    {
        //TODO
    }

}
