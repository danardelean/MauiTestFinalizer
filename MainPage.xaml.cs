namespace TestFinalizer;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        //await Shell.Current.GoToAsync($"/{nameof(SecondPage)}");
        await Navigation.PushAsync(new SecondPage());
    }

    void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
    {
		GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}


