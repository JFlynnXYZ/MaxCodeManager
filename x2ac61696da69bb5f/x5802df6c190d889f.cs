using System;
using System.Collections.Generic;
using System.Text;
using Mirality.Max.MaxCodes;

namespace x2ac61696da69bb5f;

internal static class x5802df6c190d889f
{
	private const string x58bd5e60166948c5 = "0123456789ABCDEFGHJKMNPQRTUVWXYZ";

	public static string x485aeac4429d388f(uint xb5a2e77d8a10fc03, uint xafb40ac268818189)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 6; i++)
		{
			if (i == 4)
			{
				stringBuilder.Append('-');
			}
			stringBuilder.Append("0123456789ABCDEFGHJKMNPQRTUVWXYZ"[(int)((xb5a2e77d8a10fc03 >> (5 - i) * 5 + 2) & 0x1F)]);
		}
		stringBuilder.Append("0123456789ABCDEFGHJKMNPQRTUVWXYZ"[(int)(((xb5a2e77d8a10fc03 << 3) | (xafb40ac268818189 >> 29)) & 0x1F)]);
		for (int j = 1; j < 6; j++)
		{
			if (j == 2)
			{
				stringBuilder.Append('-');
			}
			stringBuilder.Append("0123456789ABCDEFGHJKMNPQRTUVWXYZ"[(int)((xafb40ac268818189 >> (5 - j) * 5 + 4) & 0x1F)]);
		}
		byte b = 0;
		for (int k = 0; k < 32; k++)
		{
			b = (byte)(b ^ (byte)(xb5a2e77d8a10fc03 >> k));
		}
		for (int l = 0; l < 32; l++)
		{
			b = (byte)(b ^ (byte)(xafb40ac268818189 >> l));
		}
		stringBuilder.Append("0123456789ABCDEFGHJKMNPQRTUVWXYZ"[(byte)((xafb40ac268818189 << 1) & 0x1E) | (b & 1)]);
		return stringBuilder.ToString();
	}

	private static bool x039b7b9dae47acfd(char x3c4da2980d043c95, out uint xbcea506a33cf9111)
	{
		switch (x3c4da2980d043c95)
		{
		case 'I':
			x3c4da2980d043c95 = '1';
			break;
		case 'S':
			x3c4da2980d043c95 = '5';
			break;
		case 'O':
			x3c4da2980d043c95 = '0';
			break;
		}
		xbcea506a33cf9111 = (uint)"0123456789ABCDEFGHJKMNPQRTUVWXYZ".IndexOf(x3c4da2980d043c95);
		return xbcea506a33cf9111 != uint.MaxValue;
	}

	public static bool x00f742c9f580fc6b(string x311e7a92306d7199, out uint xb5a2e77d8a10fc03, out uint xafb40ac268818189)
	{
		if (x311e7a92306d7199 == null)
		{
			throw new ArgumentNullException("line");
		}
		x311e7a92306d7199 = x311e7a92306d7199.Trim().ToUpperInvariant().Replace("-", "");
		xb5a2e77d8a10fc03 = 0u;
		xafb40ac268818189 = 0u;
		if (x311e7a92306d7199.Length != 13)
		{
			return false;
		}
		uint xbcea506a33cf;
		for (int i = 0; i < 6; i++)
		{
			if (!x039b7b9dae47acfd(x311e7a92306d7199[i], out xbcea506a33cf))
			{
				return false;
			}
			xb5a2e77d8a10fc03 |= xbcea506a33cf << (5 - i) * 5 + 2;
		}
		if (!x039b7b9dae47acfd(x311e7a92306d7199[6], out xbcea506a33cf))
		{
			return false;
		}
		xb5a2e77d8a10fc03 |= xbcea506a33cf >> 3;
		for (int j = 0; j < 6; j++)
		{
			if (!x039b7b9dae47acfd(x311e7a92306d7199[j + 6], out xbcea506a33cf))
			{
				return false;
			}
			xafb40ac268818189 |= xbcea506a33cf << (5 - j) * 5 + 4;
		}
		if (!x039b7b9dae47acfd(x311e7a92306d7199[12], out xbcea506a33cf))
		{
			return false;
		}
		xafb40ac268818189 |= xbcea506a33cf >> 1;
		byte b = (byte)(xbcea506a33cf & 1u);
		byte b2 = 0;
		for (int k = 0; k < 32; k++)
		{
			b2 = (byte)(b2 ^ (byte)(xb5a2e77d8a10fc03 >> k));
		}
		for (int l = 0; l < 32; l++)
		{
			b2 = (byte)(b2 ^ (byte)(xafb40ac268818189 >> l));
		}
		return b == (b2 & 1);
	}

	public static string[] x78ec2064c8cf60f7(uint[] xcdff170dbac909bf)
	{
		if (xcdff170dbac909bf == null)
		{
			throw new ArgumentNullException("codes");
		}
		if (((uint)xcdff170dbac909bf.Length & (true ? 1u : 0u)) != 0)
		{
			throw new ArgumentException("Data must consist of an even number of dwords.");
		}
		List<string> list = new List<string>();
		for (int i = 0; i < xcdff170dbac909bf.Length; i += 2)
		{
			list.Add(x485aeac4429d388f(xcdff170dbac909bf[i], xcdff170dbac909bf[i + 1]));
		}
		return list.ToArray();
	}

	public static uint[] x0db5280e6da4eea1(string[] x0383ec486664fa18)
	{
		if (x0383ec486664fa18 == null)
		{
			throw new ArgumentNullException("lines");
		}
		uint[] array = new uint[2 * x0383ec486664fa18.Length];
		for (int i = 0; i < x0383ec486664fa18.Length; i++)
		{
			if (!x00f742c9f580fc6b(x0383ec486664fa18[i], out array[2 * i], out array[2 * i + 1]))
			{
				throw new CodeLineException(i, x0383ec486664fa18[i], new ArgumentException("Unable to parse code"));
			}
		}
		return array;
	}
}
