namespace ExampleLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public static class HashHelper
	{
		public static byte CalculateStringHash(string s)
		{
			return VeryFastHash.Calculate(Encoding.ASCII.GetBytes(s));
		}
	}
}