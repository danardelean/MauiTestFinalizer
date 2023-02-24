namespace TestFinalizer;

public partial class SecondPage : ContentPage
{
    static int pageInstances = 0;
    public SecondPage()
	{
		InitializeComponent();
        pageInstances++;
        Console.WriteLine($"{pageInstances} instances of SecondPage still in memory");
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        lblInstances.Text = $"{pageInstances} instances of SecondPage still in memory";
    }

    ~SecondPage()
    {
        pageInstances--;
        Console.WriteLine($"{pageInstances} instances of SecondPage still in memory");
    }

  
}
