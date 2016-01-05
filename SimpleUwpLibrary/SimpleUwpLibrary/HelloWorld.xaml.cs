namespace MyUwpLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Windows.UI.Xaml.Controls;
	using Newtonsoft.Json;

	public sealed partial class HelloWorld : UserControl
	{
		public HelloWorld()
		{
			this.InitializeComponent();

			var json = JsonConvert.SerializeObject(new
			{
				Text = "Hello, world!"
			});

			Label.Text = json;
		}
	}
}