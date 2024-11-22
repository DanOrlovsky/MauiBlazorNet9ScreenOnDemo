namespace MauiBlazorNet9ScreenOnDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new MainPage()) { Title = "MauiBlazorNet9ScreenOnDemo" };
	}
}
