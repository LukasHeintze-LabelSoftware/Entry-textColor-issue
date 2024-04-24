namespace MauiAppTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        TestProp = "This is a Test";
    }

    public string TestProp { get; set; }
}