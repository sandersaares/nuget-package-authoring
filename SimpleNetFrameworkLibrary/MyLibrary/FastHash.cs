namespace MyLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// Implementation of an extremely fast hash function that the entire world must be able to use!
	/// </summary>
	public static class FastHash
	{
		/// <summary>
		/// Calculates the hash value of the provided data.
		/// </summary>
		public static byte Calculate(byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));

			return data.Aggregate<byte, byte>(0, (current, t) => unchecked((byte)(current + t)));
		}
	}
}