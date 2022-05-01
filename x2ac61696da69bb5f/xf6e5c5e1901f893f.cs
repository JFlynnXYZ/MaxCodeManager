using System;

namespace x2ac61696da69bb5f;

public class Codes : ICloneable
{
	private uint[] _6b73aa01aa019d3a;

	public uint[] codes => _6b73aa01aa019d3a;

	public Codes(uint[] x4a3f0a05c02f235f)
	{
		_6b73aa01aa019d3a = x4a3f0a05c02f235f;
	}

	public Codes(params string[] lines)
		: this(x5802df6c190d889f.x0db5280e6da4eea1(lines))
	{
	}

	public string[] xa9edb3b115d067da()
	{
		return x5802df6c190d889f.x78ec2064c8cf60f7(codes);
	}

	public override string ToString()
	{
		return string.Join(" ", xa9edb3b115d067da());
	}
	
	public string ToLines()
	{
		return string.Join("\r\n", xa9edb3b115d067da());
	}

	public Codes Clone()
	{
		return new Codes((uint[])_6b73aa01aa019d3a.Clone());
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
