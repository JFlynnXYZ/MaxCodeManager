using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal static class x289f1a0ee2f795a7
{
	public static bool x4f90d54847434178(string x62584df2cb5d40dd, string xac08cf66a2c6510c)
	{
		if (x62584df2cb5d40dd == null && xac08cf66a2c6510c == null)
		{
			return true;
		}
		if (x62584df2cb5d40dd == null || xac08cf66a2c6510c == null)
		{
			return false;
		}
		return StringComparer.InvariantCultureIgnoreCase.Compare(x62584df2cb5d40dd.Trim(), xac08cf66a2c6510c.Trim()) == 0;
	}

	public static void x62dd9224cc6b1063(Control control, bool x972d12acec9b230c)
	{
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (control.IsHandleCreated)
		{
			x842e24ef1160275b.SendMessage(new HandleRef(control, control.Handle), 11, new IntPtr(x972d12acec9b230c ? (-1) : 0), IntPtr.Zero);
		}
	}

	public static string[] x3df13c9311a0ba9b(string xbf5efe8743edba7b, string x4c3e8680a15658ef, string xdf65e8781ff47529, bool x8b05b1454697839b)
	{
		bool flag = false;
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		while (num < xbf5efe8743edba7b.Length)
		{
			if (xdf65e8781ff47529 != null && num + xdf65e8781ff47529.Length < xbf5efe8743edba7b.Length && string.Compare(xbf5efe8743edba7b.Substring(num, xdf65e8781ff47529.Length), xdf65e8781ff47529, x8b05b1454697839b, CultureInfo.CurrentCulture) == 0)
			{
				if (flag && num + xdf65e8781ff47529.Length * 2 < xbf5efe8743edba7b.Length && string.Compare(xbf5efe8743edba7b.Substring(num + xdf65e8781ff47529.Length, xdf65e8781ff47529.Length), xdf65e8781ff47529, x8b05b1454697839b, CultureInfo.CurrentCulture) == 0)
				{
					stringBuilder.Append(xdf65e8781ff47529);
					num += xdf65e8781ff47529.Length * 2;
				}
				else
				{
					flag = !flag;
					num += xdf65e8781ff47529.Length;
				}
			}
			else if (!flag && x4c3e8680a15658ef != null && num + x4c3e8680a15658ef.Length < xbf5efe8743edba7b.Length && string.Compare(xbf5efe8743edba7b.Substring(num, x4c3e8680a15658ef.Length), x4c3e8680a15658ef, x8b05b1454697839b, CultureInfo.CurrentCulture) == 0)
			{
				list.Add(stringBuilder.ToString());
				stringBuilder = new StringBuilder();
				num += x4c3e8680a15658ef.Length;
			}
			else
			{
				stringBuilder.Append(xbf5efe8743edba7b[num]);
				num++;
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list.ToArray();
	}

	public static string xf0dac06e79e03a32(uint x0ceec69a97f73617)
	{
		if (x0ceec69a97f73617 > 1073741824)
		{
			return string.Format(CultureInfo.CurrentCulture, "{0:F2} GB", (float)x0ceec69a97f73617 / 1.07374182E+09f);
		}
		if (x0ceec69a97f73617 > 1048576)
		{
			return string.Format(CultureInfo.CurrentCulture, "{0:F2} MB", (float)x0ceec69a97f73617 / 1048576f);
		}
		if (x0ceec69a97f73617 > 1024)
		{
			return string.Format(CultureInfo.CurrentCulture, "{0:F2} KB", (float)x0ceec69a97f73617 / 1024f);
		}
		return string.Format(CultureInfo.CurrentCulture, "{0} bytes", x0ceec69a97f73617);
	}
}
