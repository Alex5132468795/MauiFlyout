using Microsoft.Maui.Controls.PlatformConfiguration;

namespace MauiApp3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		newCol.Command = new Command(x => this.FlyoutBackgroundColor = Color.FromRgba(255, 255, 255, 0.5));
		New.Command = new Command(x => this.FlyoutBackgroundColor = Color.FromRgba(0,0, 0, 0));
	}

}
