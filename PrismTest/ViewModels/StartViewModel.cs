namespace PrismTest.ViewModels;

public class StartViewModel : BindableBase
{
    private string _inputText { get; set; }

    public string InputText
    {
        get => _inputText;
        set { this._inputText = value; RaisePropertyChanged();}
    }
    
    //构造函数
    public StartViewModel()
    {
        
        //初始化
    }

    public DelegateCommand Command => new DelegateCommand(() =>
    {
        InputText = "Hello World!";
    });
}