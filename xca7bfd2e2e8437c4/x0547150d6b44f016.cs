using System;
using System.Text;

namespace xca7bfd2e2e8437c4;

internal static class x0547150d6b44f016
{
	public static bool xbf361f5cb8f2055b => IntPtr.Size == 4;

	public static bool x0977df479255d60d => IntPtr.Size == 8;

	public static string xc3d72d7dffc966c8 => x77ee4433eea6f321(xbe7ac400e8f3da31: false, "ProgramFilesDir");

	public static string xd77ec234f772174a => x77ee4433eea6f321(xbe7ac400e8f3da31: true, "ProgramFilesDir");

	private static string x77ee4433eea6f321(bool xbe7ac400e8f3da31, string x250224921a47c2f5)
	{
		return xf9371716581558a8(xbe7ac400e8f3da31, x238376a23aa938d4.x1dfa56dfb9d0bc9d, "Software\\Microsoft\\Windows\\CurrentVersion", x250224921a47c2f5);
	}

	private static string xf9371716581558a8(bool xbe7ac400e8f3da31, x9695cd4b47f35ccb xc301afa072787492, string x38373bcb8ebeb635, string x250224921a47c2f5)
	{
		x238376a23aa938d4.xaf679febdab5ba2b xaf679febdab5ba2b = x238376a23aa938d4.xaf679febdab5ba2b.x91ce83c7cd1bb1ec;
		if (xbe7ac400e8f3da31 && !x0977df479255d60d)
		{
			xaf679febdab5ba2b |= x238376a23aa938d4.xaf679febdab5ba2b.xa28da979e76d91b4;
		}
		else if (!xbe7ac400e8f3da31 && x0977df479255d60d)
		{
			xaf679febdab5ba2b |= x238376a23aa938d4.xaf679febdab5ba2b.x9e1e71f90f911c9f;
		}
		if (x842e24ef1160275b.RegOpenKeyEx(xc301afa072787492, x38373bcb8ebeb635, 0u, xaf679febdab5ba2b, out var x202c94d1e030f) == 0)
		{
			using (x202c94d1e030f)
			{
				StringBuilder stringBuilder = new StringBuilder(512);
				int x261e0948ef9763b = stringBuilder.Capacity;
				if (x842e24ef1160275b.RegQueryValueEx(x202c94d1e030f, x250224921a47c2f5, IntPtr.Zero, out var _, stringBuilder, ref x261e0948ef9763b) == 0)
				{
					return stringBuilder.ToString();
				}
			}
		}
		return null;
	}
}
