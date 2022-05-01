using System;
using System.IO;

namespace x3a260771fe762331;

internal class xcf043bac6e2df84d
{
	private const int xde9568ec2505c32f = 4096;

	private const int xf15e41d0985d6202 = 60;

	private const int xd3f06edc344811a0 = 2;

	private const int xe4547cd10472b6cb = 4096;

	private const int xccb1eeef6a33e9aa = 15;

	private const uint xd808df812eb7281b = 32768u;

	private const uint x857598e86195d392 = 65536u;

	private const uint xb6d200b0a6543a3b = 98304u;

	private const uint xd38e45c99f86f7a8 = 131072u;

	private const uint x879ede138bd5a397 = 32767u;

	private const int xb003a893a71bf0a9 = 314;

	private Stream xcdaeea7afaf570ff;

	private Stream x9c13656d94fc62d0;

	private uint xe8c745d989b21809;

	private uint xce9414753ce189ee;

	private byte x396b72ae0e450abb;

	private byte x7d75ae714636e4a2;

	private byte xb960c0ea181426ae;

	private byte x28eb1cf24d13ebff = 128;

	private byte[] x7b02c8d2e61629d1 = new byte[4155];

	private int x5b2b8f3b8811bbe0;

	private int x497bb6ce50e7f6a5;

	private int[] x2d1142a7dcb401f8 = new int[4097];

	private int[] x2ec7ec95ae71f5c0 = new int[4353];

	private int[] Form = new int[4097];

	private uint xd12d1dba8a023d95;

	private uint x628ea9b89457a2a9 = 131072u;

	private uint xbcea506a33cf9111;

	private int x234d871969102ce6;

	private int[] x1ecfd7897d779a2c = new int[314];

	private int[] x4646ea27dad38636 = new int[315];

	private uint[] x1a2e866ffdb509c5 = new uint[315];

	private uint[] x667fe6525c6ca04d = new uint[315];

	private uint[] xa241e8e3f22f2f35 = new uint[4097];

	private xcf043bac6e2df84d()
	{
	}

	private void x78b23af823d2447d(bool x2dd7de7c7b0ddad5)
	{
		if (x2dd7de7c7b0ddad5)
		{
			xb960c0ea181426ae |= x28eb1cf24d13ebff;
		}
		x28eb1cf24d13ebff >>= 1;
		if (x28eb1cf24d13ebff == 0)
		{
			x9c13656d94fc62d0.WriteByte(xb960c0ea181426ae);
			xb960c0ea181426ae = 0;
			x28eb1cf24d13ebff = 128;
			xce9414753ce189ee++;
		}
	}

	private void x0931e3538c5ed466()
	{
		for (int i = 0; i < 7; i++)
		{
			x78b23af823d2447d(x2dd7de7c7b0ddad5: false);
		}
	}

	private bool x4d80a38e76e27b40()
	{
		x7d75ae714636e4a2 >>= 1;
		if (x7d75ae714636e4a2 == 0)
		{
			x396b72ae0e450abb = (byte)xcdaeea7afaf570ff.ReadByte();
			x7d75ae714636e4a2 = 128;
		}
		return (x396b72ae0e450abb & x7d75ae714636e4a2) != 0;
	}

	private void xf46960baec08dee0()
	{
		for (int i = 4097; i <= 4352; i++)
		{
			x2ec7ec95ae71f5c0[i] = 4096;
		}
		for (int j = 0; j < 4096; j++)
		{
			Form[j] = 4096;
		}
	}

	private void x58cb46a7cf40af2b(int xb55b340ae3a3e4e0)
	{
		int num = 1;
		int num2 = 4097 + x7b02c8d2e61629d1[xb55b340ae3a3e4e0];
		x2ec7ec95ae71f5c0[xb55b340ae3a3e4e0] = (x2d1142a7dcb401f8[xb55b340ae3a3e4e0] = 4096);
		x497bb6ce50e7f6a5 = 0;
		while (true)
		{
			if (num >= 0)
			{
				if (x2ec7ec95ae71f5c0[num2] == 4096)
				{
					x2ec7ec95ae71f5c0[num2] = xb55b340ae3a3e4e0;
					Form[xb55b340ae3a3e4e0] = num2;
					return;
				}
				num2 = x2ec7ec95ae71f5c0[num2];
			}
			else
			{
				if (x2d1142a7dcb401f8[num2] == 4096)
				{
					x2d1142a7dcb401f8[num2] = xb55b340ae3a3e4e0;
					Form[xb55b340ae3a3e4e0] = num2;
					return;
				}
				num2 = x2d1142a7dcb401f8[num2];
			}
			int i;
			for (i = 1; i < 60; i++)
			{
				num = x7b02c8d2e61629d1[xb55b340ae3a3e4e0 + i] - x7b02c8d2e61629d1[num2 + i];
				if (num != 0)
				{
					break;
				}
			}
			if (i <= 2)
			{
				continue;
			}
			if (i > x497bb6ce50e7f6a5)
			{
				x5b2b8f3b8811bbe0 = (xb55b340ae3a3e4e0 - num2) & 0xFFF;
				x497bb6ce50e7f6a5 = i;
				if (x497bb6ce50e7f6a5 >= 60)
				{
					break;
				}
			}
			else if (i == x497bb6ce50e7f6a5)
			{
				int num3 = (xb55b340ae3a3e4e0 - num2) & 0xFFF;
				if (num3 < x5b2b8f3b8811bbe0)
				{
					x5b2b8f3b8811bbe0 = num3;
				}
			}
		}
		Form[xb55b340ae3a3e4e0] = Form[num2];
		x2d1142a7dcb401f8[xb55b340ae3a3e4e0] = x2d1142a7dcb401f8[num2];
		x2ec7ec95ae71f5c0[xb55b340ae3a3e4e0] = x2ec7ec95ae71f5c0[num2];
		Form[x2d1142a7dcb401f8[num2]] = xb55b340ae3a3e4e0;
		Form[x2ec7ec95ae71f5c0[num2]] = xb55b340ae3a3e4e0;
		if (x2ec7ec95ae71f5c0[Form[num2]] == num2)
		{
			x2ec7ec95ae71f5c0[Form[num2]] = xb55b340ae3a3e4e0;
		}
		else
		{
			x2d1142a7dcb401f8[Form[num2]] = xb55b340ae3a3e4e0;
		}
		Form[num2] = 4096;
	}

	private void x92361180a53fdf7c(int x9c79b5ad7b769b12)
	{
		if (Form[x9c79b5ad7b769b12] == 4096)
		{
			return;
		}
		int num;
		if (x2ec7ec95ae71f5c0[x9c79b5ad7b769b12] == 4096)
		{
			num = x2d1142a7dcb401f8[x9c79b5ad7b769b12];
		}
		else if (x2d1142a7dcb401f8[x9c79b5ad7b769b12] == 4096)
		{
			num = x2ec7ec95ae71f5c0[x9c79b5ad7b769b12];
		}
		else
		{
			num = x2d1142a7dcb401f8[x9c79b5ad7b769b12];
			if (x2ec7ec95ae71f5c0[num] != 4096)
			{
				do
				{
					num = x2ec7ec95ae71f5c0[x9c79b5ad7b769b12];
				}
				while (x2ec7ec95ae71f5c0[num] != 4096);
				x2ec7ec95ae71f5c0[Form[num]] = x2d1142a7dcb401f8[num];
				Form[x2d1142a7dcb401f8[num]] = Form[num];
				x2d1142a7dcb401f8[num] = x2d1142a7dcb401f8[x9c79b5ad7b769b12];
				Form[x2d1142a7dcb401f8[x9c79b5ad7b769b12]] = num;
			}
			x2ec7ec95ae71f5c0[num] = x2ec7ec95ae71f5c0[x9c79b5ad7b769b12];
			Form[x2ec7ec95ae71f5c0[x9c79b5ad7b769b12]] = num;
		}
		Form[num] = Form[x9c79b5ad7b769b12];
		if (x2ec7ec95ae71f5c0[Form[x9c79b5ad7b769b12]] == x9c79b5ad7b769b12)
		{
			x2ec7ec95ae71f5c0[Form[x9c79b5ad7b769b12]] = num;
		}
		else
		{
			x2d1142a7dcb401f8[Form[x9c79b5ad7b769b12]] = num;
		}
		Form[x9c79b5ad7b769b12] = 4096;
	}

	private void x07af4ca3c293821e()
	{
		x667fe6525c6ca04d[314] = 0u;
		for (int num = 314; num >= 1; num--)
		{
			int num2 = num - 1;
			x1ecfd7897d779a2c[num2] = num;
			x4646ea27dad38636[num] = num2;
			x1a2e866ffdb509c5[num] = 1u;
			x667fe6525c6ca04d[num - 1] = x667fe6525c6ca04d[num] + x1a2e866ffdb509c5[num];
		}
		x1a2e866ffdb509c5[0] = 0u;
		xa241e8e3f22f2f35[4096] = 0u;
		for (int num3 = 4096; num3 >= 1; num3--)
		{
			xa241e8e3f22f2f35[num3 - 1] = (uint)(xa241e8e3f22f2f35[num3] + 10000 / (num3 + 200));
		}
	}

	private void xafc1150bed64ef7c(int x0b8ed6e6a03488ff)
	{
		int num2;
		if (x667fe6525c6ca04d[0] >= 32767)
		{
			uint num = 0u;
			for (num2 = 314; num2 > 0; num2--)
			{
				x667fe6525c6ca04d[num2] = num;
				x1a2e866ffdb509c5[num2] = x1a2e866ffdb509c5[num2] + 1 >> 1;
				num += x1a2e866ffdb509c5[num2];
			}
			x667fe6525c6ca04d[0] = num;
		}
		num2 = x0b8ed6e6a03488ff;
		while (x1a2e866ffdb509c5[num2] == x1a2e866ffdb509c5[num2 - 1])
		{
			num2--;
		}
		if (num2 < x0b8ed6e6a03488ff)
		{
			int num3 = x4646ea27dad38636[num2];
			int num4 = x4646ea27dad38636[x0b8ed6e6a03488ff];
			x4646ea27dad38636[num2] = num4;
			x4646ea27dad38636[x0b8ed6e6a03488ff] = num3;
			x1ecfd7897d779a2c[num3] = x0b8ed6e6a03488ff;
			x1ecfd7897d779a2c[num4] = num2;
		}
		x1a2e866ffdb509c5[num2]++;
		while (--num2 >= 0)
		{
			x667fe6525c6ca04d[num2]++;
		}
	}

	private void x74effd3a0f44569e(bool x2dd7de7c7b0ddad5)
	{
		x78b23af823d2447d(x2dd7de7c7b0ddad5);
		while (x234d871969102ce6 > 0)
		{
			x78b23af823d2447d(!x2dd7de7c7b0ddad5);
			x234d871969102ce6--;
		}
	}

	private void xe59127b74754b51f(int xb867a42da3ae686d)
	{
		int num = x1ecfd7897d779a2c[xb867a42da3ae686d];
		uint num2 = x628ea9b89457a2a9 - xd12d1dba8a023d95;
		x628ea9b89457a2a9 = xd12d1dba8a023d95 + num2 * x667fe6525c6ca04d[num - 1] / x667fe6525c6ca04d[0];
		xd12d1dba8a023d95 += num2 * x667fe6525c6ca04d[num] / x667fe6525c6ca04d[0];
		while (true)
		{
			if (x628ea9b89457a2a9 <= 65536)
			{
				x74effd3a0f44569e(x2dd7de7c7b0ddad5: false);
			}
			else if (xd12d1dba8a023d95 >= 65536)
			{
				x74effd3a0f44569e(x2dd7de7c7b0ddad5: true);
				xd12d1dba8a023d95 -= 65536u;
				x628ea9b89457a2a9 -= 65536u;
			}
			else
			{
				if (xd12d1dba8a023d95 < 32768 || x628ea9b89457a2a9 > 98304)
				{
					break;
				}
				x234d871969102ce6++;
				xd12d1dba8a023d95 -= 32768u;
				x628ea9b89457a2a9 -= 32768u;
			}
			xd12d1dba8a023d95 += xd12d1dba8a023d95;
			x628ea9b89457a2a9 += x628ea9b89457a2a9;
		}
		xafc1150bed64ef7c(num);
	}

	private void x0a7fe22c931759bf(int x13d4cb8d1bd20347)
	{
		uint num = x628ea9b89457a2a9 - xd12d1dba8a023d95;
		x628ea9b89457a2a9 = xd12d1dba8a023d95 + num * xa241e8e3f22f2f35[x13d4cb8d1bd20347] / xa241e8e3f22f2f35[0];
		xd12d1dba8a023d95 += num * xa241e8e3f22f2f35[x13d4cb8d1bd20347 + 1] / xa241e8e3f22f2f35[0];
		while (true)
		{
			if (x628ea9b89457a2a9 <= 65536)
			{
				x74effd3a0f44569e(x2dd7de7c7b0ddad5: false);
			}
			else if (xd12d1dba8a023d95 >= 65536)
			{
				x74effd3a0f44569e(x2dd7de7c7b0ddad5: true);
				xd12d1dba8a023d95 -= 65536u;
				x628ea9b89457a2a9 -= 65536u;
			}
			else
			{
				if (xd12d1dba8a023d95 < 32768 || x628ea9b89457a2a9 > 98304)
				{
					break;
				}
				x234d871969102ce6++;
				xd12d1dba8a023d95 -= 32768u;
				x628ea9b89457a2a9 -= 32768u;
			}
			xd12d1dba8a023d95 += xd12d1dba8a023d95;
			x628ea9b89457a2a9 += x628ea9b89457a2a9;
		}
	}

	private void x21d1f93247c1cf3b()
	{
		x234d871969102ce6++;
		if (xd12d1dba8a023d95 < 32768)
		{
			x74effd3a0f44569e(x2dd7de7c7b0ddad5: false);
		}
		else
		{
			x74effd3a0f44569e(x2dd7de7c7b0ddad5: true);
		}
		x0931e3538c5ed466();
	}

	private int x23db8f3508504d5b(uint x08db3aeabb253cb1)
	{
		int num = 1;
		int num2 = 314;
		while (num < num2)
		{
			int num3 = (num + num2) / 2;
			if (x667fe6525c6ca04d[num3] > x08db3aeabb253cb1)
			{
				num = num3 + 1;
			}
			else
			{
				num2 = num3;
			}
		}
		return num;
	}

	private int x712204eae0aa1970(uint x08db3aeabb253cb1)
	{
		int num = 1;
		int num2 = 4096;
		while (num < num2)
		{
			int num3 = (num + num2) / 2;
			if (xa241e8e3f22f2f35[num3] > x08db3aeabb253cb1)
			{
				num = num3 + 1;
			}
			else
			{
				num2 = num3;
			}
		}
		return num - 1;
	}

	private void xf54efe08b9d4167b()
	{
		for (int i = 0; i < 17; i++)
		{
			xbcea506a33cf9111 = (uint)((xbcea506a33cf9111 << 1) + (x4d80a38e76e27b40() ? 1 : 0));
		}
	}

	private int x7c8498fb2942019a()
	{
		uint num = x628ea9b89457a2a9 - xd12d1dba8a023d95;
		int num2 = x23db8f3508504d5b(((xbcea506a33cf9111 - xd12d1dba8a023d95 + 1) * x667fe6525c6ca04d[0] - 1) / num);
		x628ea9b89457a2a9 = xd12d1dba8a023d95 + num * x667fe6525c6ca04d[num2 - 1] / x667fe6525c6ca04d[0];
		xd12d1dba8a023d95 += num * x667fe6525c6ca04d[num2] / x667fe6525c6ca04d[0];
		while (true)
		{
			if (xd12d1dba8a023d95 >= 65536)
			{
				xbcea506a33cf9111 -= 65536u;
				xd12d1dba8a023d95 -= 65536u;
				x628ea9b89457a2a9 -= 65536u;
			}
			else if (xd12d1dba8a023d95 >= 32768 && x628ea9b89457a2a9 <= 98304)
			{
				xbcea506a33cf9111 -= 32768u;
				xd12d1dba8a023d95 -= 32768u;
				x628ea9b89457a2a9 -= 32768u;
			}
			else if (x628ea9b89457a2a9 > 65536)
			{
				break;
			}
			xd12d1dba8a023d95 += xd12d1dba8a023d95;
			x628ea9b89457a2a9 += x628ea9b89457a2a9;
			xbcea506a33cf9111 = (uint)((xbcea506a33cf9111 << 1) + (x4d80a38e76e27b40() ? 1 : 0));
		}
		int result = x4646ea27dad38636[num2];
		xafc1150bed64ef7c(num2);
		return result;
	}

	private int x4217269d72123c76()
	{
		uint num = x628ea9b89457a2a9 - xd12d1dba8a023d95;
		int num2 = x712204eae0aa1970(((xbcea506a33cf9111 - xd12d1dba8a023d95 + 1) * xa241e8e3f22f2f35[0] - 1) / num);
		x628ea9b89457a2a9 = xd12d1dba8a023d95 + num * xa241e8e3f22f2f35[num2] / xa241e8e3f22f2f35[0];
		xd12d1dba8a023d95 += num * xa241e8e3f22f2f35[num2 + 1] / xa241e8e3f22f2f35[0];
		while (true)
		{
			if (xd12d1dba8a023d95 >= 65536)
			{
				xbcea506a33cf9111 -= 65536u;
				xd12d1dba8a023d95 -= 65536u;
				x628ea9b89457a2a9 -= 65536u;
			}
			else if (xd12d1dba8a023d95 >= 32768 && x628ea9b89457a2a9 <= 98304)
			{
				xbcea506a33cf9111 -= 32768u;
				xd12d1dba8a023d95 -= 32768u;
				x628ea9b89457a2a9 -= 32768u;
			}
			else if (x628ea9b89457a2a9 > 65536)
			{
				break;
			}
			xd12d1dba8a023d95 += xd12d1dba8a023d95;
			x628ea9b89457a2a9 += x628ea9b89457a2a9;
			xbcea506a33cf9111 = (uint)((xbcea506a33cf9111 << 1) + (x4d80a38e76e27b40() ? 1 : 0));
		}
		return num2;
	}

	private void xac0e812e543b0f99()
	{
		xe8c745d989b21809 = (uint)xcdaeea7afaf570ff.Length;
		x9c13656d94fc62d0.Write(BitConverter.GetBytes(xe8c745d989b21809), 0, 4);
		xce9414753ce189ee = 4u;
		if (xe8c745d989b21809 == 0)
		{
			return;
		}
		xe8c745d989b21809 = 0u;
		x07af4ca3c293821e();
		xf46960baec08dee0();
		int num = 0;
		int num2 = 4036;
		for (int i = num; i < num2; i++)
		{
			x7b02c8d2e61629d1[i] = 32;
		}
		int j;
		for (j = 0; j < 60; j++)
		{
			int num3;
			if ((num3 = xcdaeea7afaf570ff.ReadByte()) == -1)
			{
				break;
			}
			x7b02c8d2e61629d1[num2 + j] = (byte)num3;
		}
		xe8c745d989b21809 = (uint)j;
		for (int k = 1; k <= 60; k++)
		{
			x58cb46a7cf40af2b(num2 - k);
		}
		x58cb46a7cf40af2b(num2);
		do
		{
			if (x497bb6ce50e7f6a5 > j)
			{
				x497bb6ce50e7f6a5 = j;
			}
			if (x497bb6ce50e7f6a5 <= 2)
			{
				x497bb6ce50e7f6a5 = 1;
				xe59127b74754b51f(x7b02c8d2e61629d1[num2]);
			}
			else
			{
				xe59127b74754b51f(253 + x497bb6ce50e7f6a5);
				x0a7fe22c931759bf(x5b2b8f3b8811bbe0 - 1);
			}
			int num4 = x497bb6ce50e7f6a5;
			int l;
			for (l = 0; l < num4; l++)
			{
				int num3;
				if ((num3 = xcdaeea7afaf570ff.ReadByte()) == -1)
				{
					break;
				}
				x92361180a53fdf7c(num);
				x7b02c8d2e61629d1[num] = (byte)num3;
				if (num < 59)
				{
					x7b02c8d2e61629d1[num + 4096] = (byte)num3;
				}
				num = (num + 1) & 0xFFF;
				num2 = (num2 + 1) & 0xFFF;
				x58cb46a7cf40af2b(num2);
			}
			xe8c745d989b21809 += (uint)l;
			while (l++ < num4)
			{
				x92361180a53fdf7c(num);
				num = (num + 1) & 0xFFF;
				num2 = (num2 + 1) & 0xFFF;
				j--;
				if (j > 0)
				{
					x58cb46a7cf40af2b(num2);
				}
			}
		}
		while (j > 0);
		x21d1f93247c1cf3b();
	}

	private void x4ed59c2454a69938()
	{
		byte[] array = new byte[4];
		xcdaeea7afaf570ff.Read(array, 0, 4);
		xe8c745d989b21809 = BitConverter.ToUInt32(array, 0);
		if (xe8c745d989b21809 == 0)
		{
			return;
		}
		xf54efe08b9d4167b();
		x07af4ca3c293821e();
		for (int i = 0; i < 4036; i++)
		{
			x7b02c8d2e61629d1[i] = 32;
		}
		int num = 4036;
		int num2 = 0;
		while (num2 < xe8c745d989b21809)
		{
			int num3 = x7c8498fb2942019a();
			if (num3 < 256)
			{
				x9c13656d94fc62d0.WriteByte((byte)num3);
				x7b02c8d2e61629d1[num] = (byte)num3;
				num = (num + 1) & 0xFFF;
				num2++;
				continue;
			}
			int num4 = (num - x4217269d72123c76() - 1) & 0xFFF;
			int num5 = num3 - 255 + 2;
			for (int j = 0; j < num5; j++)
			{
				num3 = x7b02c8d2e61629d1[(num4 + j) & 0xFFF];
				x9c13656d94fc62d0.WriteByte((byte)num3);
				x7b02c8d2e61629d1[num] = (byte)num3;
				num = (num + 1) & 0xFFF;
				num2++;
			}
		}
	}

	public static void x8291881ef07bb5c7(Stream xdc4cce4a2fe6be69, Stream xf823f0edaa261f3b)
	{
		xcf043bac6e2df84d xcf043bac6e2df84d2 = new xcf043bac6e2df84d();
		xcf043bac6e2df84d2.xcdaeea7afaf570ff = xdc4cce4a2fe6be69;
		xcf043bac6e2df84d2.x9c13656d94fc62d0 = xf823f0edaa261f3b;
		xcf043bac6e2df84d2.xac0e812e543b0f99();
	}

	public static void xf76803be5e9ee2aa(Stream xdc4cce4a2fe6be69, Stream xf823f0edaa261f3b)
	{
		xcf043bac6e2df84d xcf043bac6e2df84d2 = new xcf043bac6e2df84d();
		xcf043bac6e2df84d2.xcdaeea7afaf570ff = xdc4cce4a2fe6be69;
		xcf043bac6e2df84d2.x9c13656d94fc62d0 = xf823f0edaa261f3b;
		xcf043bac6e2df84d2.x4ed59c2454a69938();
	}
}
