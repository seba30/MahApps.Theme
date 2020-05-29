using System.Diagnostics;

namespace MahApps_20
{
	public partial class App
	{
		public App()
		{
			PresentationTraceSources.DataBindingSource.Listeners.Add(new Tracer());
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
