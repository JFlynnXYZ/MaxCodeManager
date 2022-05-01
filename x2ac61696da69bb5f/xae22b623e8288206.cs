using System;

namespace x2ac61696da69bb5f;

internal class xae22b623e8288206
{
	private uint[] x6b73aa01aa019d3a;

	private int _7b97b8a48062679d = -1;

	private int _14ed01b5e3f68d92;

	public int x7b97b8a48062679d => _7b97b8a48062679d;

	public int x14ed01b5e3f68d92 => _14ed01b5e3f68d92;

	public xae22b623e8288206(uint[] x4a3f0a05c02f235f)
	{
		x6b73aa01aa019d3a = x4a3f0a05c02f235f;
	}

	public uint x06b0e25aa6ad68a9(int x5bf22067353b9e1c)
	{
		if (x5bf22067353b9e1c <= 0)
		{
			throw new ArgumentOutOfRangeException("bitCount", x5bf22067353b9e1c, "Bit count must be at least 1.");
		}
		if (x5bf22067353b9e1c > 32)
		{
			throw new ArgumentOutOfRangeException("bitCount", x5bf22067353b9e1c, "Bit count cannot be more than 32.");
		}
		uint num = 0u;
		for (int i = 0; i < x5bf22067353b9e1c; i++)
		{
			_14ed01b5e3f68d92--;
			if (_14ed01b5e3f68d92 < 0)
			{
				_14ed01b5e3f68d92 = 31;
				_7b97b8a48062679d++;
			}
			if (_7b97b8a48062679d >= x6b73aa01aa019d3a.Length)
			{
				throw new InvalidOperationException("Bit stream exhausted");
			}
			num = (num << 1) | ((x6b73aa01aa019d3a[_7b97b8a48062679d] >> _14ed01b5e3f68d92) & 1u);
		}
		return num;
	}
}
