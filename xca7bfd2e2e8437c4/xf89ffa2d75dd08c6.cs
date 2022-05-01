using System;
using System.Collections;

namespace xca7bfd2e2e8437c4;

internal static class xf89ffa2d75dd08c6
{
	private static string[] xf224c03044d5d4e1(x238376a23aa938d4.xdbb3b44e59f3022c x43163d22e8cd5a71, bool xe3b13379c7058411)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		ArrayList arrayList = new ArrayList();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (x842e24ef1160275b.GetDriveType(text) != x43163d22e8cd5a71)
			{
				continue;
			}
			if (xe3b13379c7058411)
			{
				if (x842e24ef1160275b.GetVolumeInformation(text, null, 0, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, null, 0))
				{
					arrayList.Add(text);
				}
			}
			else
			{
				arrayList.Add(text);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	public static string[] x85dcc4807ea67141()
	{
		return xf224c03044d5d4e1(x238376a23aa938d4.xdbb3b44e59f3022c.xd9860122ca1ea309, xe3b13379c7058411: true);
	}

	public static string[] x15ed2829418ba79b(bool xe3b13379c7058411)
	{
		return xf224c03044d5d4e1(x238376a23aa938d4.xdbb3b44e59f3022c.xd551e4b2b6894eec, xe3b13379c7058411);
	}
}
