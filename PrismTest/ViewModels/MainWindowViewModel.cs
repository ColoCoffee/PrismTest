using System.Diagnostics;
using System.Windows;
using PrismTest.View;

namespace PrismTest.ViewModels;

public class MainWindowViewModel : BindableBase
{
    public DelegateCommand Command1 { get; private set; }
    public DelegateCommand StartCommand => new DelegateCommand(() =>
    {
        var startView = new StartWindow();
        startView.DataContext = _startViewModel;
        startView.Show();
    });

    private StartViewModel _startViewModel;
    
    public MainWindowViewModel()
    {
        _startViewModel = new StartViewModel();
        Command1 = new DelegateCommand(ExecuteCommand1,CanExecuteCommand1).ObservesProperty(() => _startViewModel.InputText);
    }
    
    
    private void ExecuteCommand1()
    {
        MessageBox.Show("Hello World!");
    }

    private int index = 0;
    private bool CanExecuteCommand1()
    {
        
        Debug.WriteLine($"CanExecuteCommand1: {index++}");
        return true;
        // if (_startViewModel == null)
        // {
        //     return false;
        // }
        // if (_startViewModel.InputText == "Hello World!")
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
    }
}