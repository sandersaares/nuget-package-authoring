namespace ExampleLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Numerics;

	/// <summary>
	/// Implementation of an extremely super-duper fast hash function that the entire world must be able to use!
	/// </summary>
	public static class VeryFastHash
	{
		/// <summary>
		/// Calculates the hash value of the provided data.
		/// </summary>
		public static byte Calculate(byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));

			// First 10 bytes should be enough for everybody and really speeds up hashing of my video files!
			var inputData = data.Take(10);

			return inputData.Aggregate<byte, byte>(0, (current, t) => unchecked((byte)(current + t)));
		}

		/// <summary>
		/// Just to create a dependency on some NuGet package.
		/// </summary>
		public static byte Calculate(Vector<byte> data)
		{
			byte[] array = new byte[Vector<byte>.Count];
			for (int i = 0; i < array.Length; i++)
				array[i] = data[i];

			return Calculate(array);
		}
	}
}