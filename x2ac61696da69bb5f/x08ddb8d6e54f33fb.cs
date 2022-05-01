using System;
using System.Collections.Generic;

namespace x2ac61696da69bb5f;

internal class x08ddb8d6e54f33fb
{
	private List<uint> _6b73aa01aa019d3a = new List<uint>();

	private int _14ed01b5e3f68d92;

	public int x14ed01b5e3f68d92 => _14ed01b5e3f68d92;

	public uint[] x543681a74a4a8026()
	{
		return _6b73aa01aa019d3a.ToArray();
	}

	public void x6210059f049f0d48(int x5bf22067353b9e1c, uint xbcea506a33cf9111)
	{
		if (x5bf22067353b9e1c <= 0)
		{
			throw new ArgumentOutOfRangeException("bitCount", x5bf22067353b9e1c, "Bit count must be at least 1.");
		}
		if (x5bf22067353b9e1c > 32)
		{
			throw new ArgumentOutOfRangeException("bitCount", x5bf22067353b9e1c, "Bit count cannot be more than 32.");
		}
		if (x5bf22067353b9e1c == 32)
		{
			x6210059f049f0d48(31, xbcea506a33cf9111 >> 1);
			x5bf22067353b9e1c = 1;
			xbcea506a33cf9111 &= 1u;
		}
		uint num = (uint)(1 << x5bf22067353b9e1c);
		if (xbcea506a33cf9111 >= num)
		{
			throw new ArgumentOutOfRangeException("value", xbcea506a33cf9111, "Field width of " + x5bf22067353b9e1c + " bits; value must be within 0 to " + (num - 1));
		}
		for (int i = 0; i < x5bf22067353b9e1c; i++)
		{
			num >>= 1;
			_14ed01b5e3f68d92--;
			if (_14ed01b5e3f68d92 < 0)
			{
				_14ed01b5e3f68d92 = 31;
				_6b73aa01aa019d3a.Add(0u);
			}
			if ((xbcea506a33cf9111 & num) != 0)
			{
				_6b73aa01aa019d3a[_6b73aa01aa019d3a.Count - 1] |= (uint)(1 << _14ed01b5e3f68d92);
			}
		}
	}
}
