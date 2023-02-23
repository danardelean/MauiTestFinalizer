namespace TestFinalizer;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());// new AppShell();
	}
}

