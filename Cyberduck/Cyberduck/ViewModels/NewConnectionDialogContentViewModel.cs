using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Cyberduck.Contracts.ViewModels;
using Cyberduck.Core.Services;
using TestApp.Core.Models;

namespace Cyberduck.ViewModels;

public partial class NewConnectionDialogContentViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();


    public NewConnectionDialogContentViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {

    }

    public void OnNavigatedFrom()
    {
    }
}

