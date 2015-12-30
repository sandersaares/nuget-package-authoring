namespace MultiArchitectureUwpLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// Implements advanced logic processes to detect the architecture that the application is running under.
	/// </summary>
	public static class ArchitectureDetector
	{
		/// <summary>
		/// Gets the name of the current architecture as an uppercase string.
		/// </summary>
		public static string GetCurrentArchitecture()
		{
#if ARCH_ARM
			return "ARM";
#elif ARCH_X64
			return "X64";
#elif ARCH_X86
			return "X86";
#else
			// Just to make the example more realistic - if you have dependencies that do not come in AnyCPU,
			// you will not be able to build your library as AnyCPU, so we make it impossible also in the example.
			#error This library cannot be built for your selected target architecture
#endif
		}
	}
}