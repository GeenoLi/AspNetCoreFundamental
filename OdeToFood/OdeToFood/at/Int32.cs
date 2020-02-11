using System;
using System.Collections.Generic;
using System.Text;

namespace at
{
	public static class Int32
	{
		public static readonly int Dummy = 0;
		public static readonly int Empty = -1;
		public static readonly int Missing = int.MinValue;
		public static readonly int[] EmptyArray = new int[0];

		public static int Of(string literal)
		{
			return Of(literal, 0);
		}

		public static int Of(string literal, int fallback)
		{
			if (!int.TryParse(literal, out int result))
				return fallback;
			return result;
		}

		public static int DigitsOf(int value)
		{
			return (int)Math.Floor(Math.Log10(Math.Abs(value)) + 1.0);
		}

		public static IEnumerable<int> Baes10Sequence(int value, int segment)
		{
			int seed = Math.Abs(value);
			yield return seed;
			double max = Math.Pow(10.0, Math.Abs(segment).Min(10 - DigitsOf(seed)));
			for (int i = 10; i <= max; i *= 10)
			{
				for (int k = 0; k < 10; ++k)
					yield return seed * i + k;
			}
		}

		
	}
}
