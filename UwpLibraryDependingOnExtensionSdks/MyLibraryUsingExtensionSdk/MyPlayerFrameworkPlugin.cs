namespace MyLibraryUsingExtensionSdk
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.PlayerFramework;

	public sealed class MyPlayerFrameworkPlugin : IPlugin
	{
		void IPlugin.Load()
		{
		}

		void IPlugin.Update(IMediaSource mediaSource)
		{
		}

		void IPlugin.Unload()
		{
		}

		MediaPlayer IPlugin.MediaPlayer { get; set; }
	}
}