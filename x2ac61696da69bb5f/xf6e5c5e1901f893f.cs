using System;

namespace x2ac61696da69bb5f;

public class xf6e5c5e1901f893f : ICloneable
{
	private uint[] _6b73aa01aa019d3a;

	public uint[] x6b73aa01aa019d3a => _6b73aa01aa019d3a;

	public xf6e5c5e1901f893f(uint[] x4a3f0a05c02f235f)
	{
		_6b73aa01aa019d3a = x4a3f0a05c02f235f;
	}

	public xf6e5c5e1901f893f(params string[] x0383ec486664fa18)
		: this(x5802df6c190d889f.x0db5280e6da4eea1(x0383ec486664fa18))
	{
	}

	public string[] xa9edb3b115d067da()
	{
		return x5802df6c190d889f.x78ec2064c8cf60f7(x6b73aa01aa019d3a);
	}

	public override string ToString()
	{
		return string.Join(" ", xa9edb3b115d067da());
	}

	public xf6e5c5e1901f893f Clone()
	{
		return new xf6e5c5e1901f893f((uint[])_6b73aa01aa019d3a.Clone());
	}

	private object xc1ca9fe073d7b6d8()
	{
		return Clone();
	}

	object ICloneable.Clone()
	{
		//ILSpy generated this explicit interface implementation from .override directive in xc1ca9fe073d7b6d8
		return this.xc1ca9fe073d7b6d8();
	}
}
