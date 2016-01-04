namespace MultiArchitectureUwpLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Windows.UI.Xaml.Controls;

	/// <summary>
	/// A control that displays a hash. Just used to add flavor to the example since exporting XAML controls creates some
	/// more files in the output directory that must also be properly packaged together with the assembly file itself.
	/// </summary>
	public sealed partial class ArchitectureControl : UserControl
	{
		/// <summary></summary>
		public ArchitectureControl()
		{
			this.InitializeComponent();

			Label.Text = ArchitectureDetector.GetCurrentArchitecture();
		}
	}
}