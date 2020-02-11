using System;
using System.Collections.Generic;
using System.Text;

namespace at
{
	public static class ext
	{
		public static T Min<T>(this T me, T other) where T : IComparable<T>
		{
			if (!me.LT(other))
				return other;
			return me;
		}

		public static bool LT<T>(this T me, T other) where T : IComparable<T>
		{
			if (me == null)
				return other != null;
			if (other != null)
				return me.CompareTo(other) < 0;
			return false;
		}
	}
}
