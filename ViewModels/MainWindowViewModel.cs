using System.Collections.ObjectModel;
using ReactiveUI;

namespace Sandbox.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<string> _observableCollection =
    [
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data",
        "Data", "Data", "Data", "Data"
    ];

    public ObservableCollection<string> ObservableCollection
    {
        get => _observableCollection;
        set => this.RaiseAndSetIfChanged(ref _observableCollection, value);
    }
}