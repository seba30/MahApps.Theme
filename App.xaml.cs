using System;
using System.Diagnostics;
using System.Windows;

using ControlzEx.Theming;

using MahApps.Metro.Theming;

namespace MahApps_20
{
	public partial class App
	{
		public App()
		{
			PresentationTraceSources.DataBindingSource.Listeners.Add(new Tracer());
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			//var theme = ThemeManager.Current.AddLibraryTheme(new LibraryTheme(new Uri("pack://application:,,,/MahApps_20;component/AccentColor.xaml"), MahAppsLibraryThemeProvider.DefaultInstance));

			//ThemeManager.Current.ChangeTheme(this, theme);

			base.OnStartup(e);
		}

		private class Tracer : TraceListener
		{
			public override void Write(string message)
			{
				Debugger.Break();
			}

			public override void WriteLine(string message)
			{
				Debugger.Break();
			}
		}
	}
}
