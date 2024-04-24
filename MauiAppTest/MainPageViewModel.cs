using System.ComponentModel;
using System.Windows.Input;

namespace MauiAppTest;

public class MainPageViewModel: INotifyPropertyChanged
{
    private string _TestProp;

    public string TestProp
    {
        get => _TestProp;
        set
        {
            _TestProp = value;
            NotifyPropertyChanged(nameof(TestProp));
        }
    }

    public ICommand TestCommand
    {
        get
        {
            return new Command(() =>
            {
                TestProp = "Text should be red";
            });
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}