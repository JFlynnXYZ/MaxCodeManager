using System;
using System.Runtime.InteropServices;

namespace xca7bfd2e2e8437c4;

internal static class x98d5b12cfac5b235
{
	public static bool x53b4834f330a6612(IntPtr x159f8d10bfb3428d, out bool x2fef7d841879a711)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		try
		{
			uint xf8c51ced30acecd;
			return x842e24ef1160275b.GetTokenInformation(x159f8d10bfb3428d, x238376a23aa938d4.xb8cab4e3b6a3986c.xe17500d669cc7c81, intPtr, 4u, out xf8c51ced30acecd);
		}
		finally
		{
			x2fef7d841879a711 = Marshal.ReadInt32(intPtr) != 0;
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static bool x0a2dbdb05d94b2cc(IntPtr x159f8d10bfb3428d, bool x2fef7d841879a711)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		try
		{
			Marshal.WriteInt32(intPtr, x2fef7d841879a711 ? 1 : 0);
			return x842e24ef1160275b.SetTokenInformation(x159f8d10bfb3428d, x238376a23aa938d4.xb8cab4e3b6a3986c.xe17500d669cc7c81, intPtr, 4u);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}
}
