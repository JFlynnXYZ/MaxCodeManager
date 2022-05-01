using System;

namespace x3a260771fe762331;

internal struct x934fb9524f0d460a : IComparable<x934fb9524f0d460a>, IEquatable<x934fb9524f0d460a>, IComparable
{
	public readonly uint x52b8174788d367f9;

	public readonly uint xb3efee94cf138f44;

	public x934fb9524f0d460a(uint x28011ef2e60e6ef5, uint xba336f6c3ae33222)
	{
		x52b8174788d367f9 = x28011ef2e60e6ef5;
		xb3efee94cf138f44 = xba336f6c3ae33222;
	}

	public int CompareTo(x934fb9524f0d460a x3b50be75884cb97e)
	{
		if (x52b8174788d367f9 < x3b50be75884cb97e.x52b8174788d367f9)
		{
			return -1;
		}
		if (x52b8174788d367f9 > x3b50be75884cb97e.x52b8174788d367f9)
		{
			return 1;
		}
		if (xb3efee94cf138f44 < x3b50be75884cb97e.xb3efee94cf138f44)
		{
			return -1;
		}
		if (xb3efee94cf138f44 > x3b50be75884cb97e.xb3efee94cf138f44)
		{
			return 1;
		}
		return 0;
	}

	private int x3a779f47c76a4802(object xa59bff7708de3a18)
	{
		if (xa59bff7708de3a18 is x934fb9524f0d460a)
		{
			return CompareTo((x934fb9524f0d460a)xa59bff7708de3a18);
		}
		throw new ArgumentException("Can only compare against other GameAndCodeIds.", "obj");
	}

	int IComparable.CompareTo(object xa59bff7708de3a18)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x3a779f47c76a4802
		return this.x3a779f47c76a4802(xa59bff7708de3a18);
	}

	public bool Equals(x934fb9524f0d460a x3b50be75884cb97e)
	{
		if (x52b8174788d367f9 == x3b50be75884cb97e.x52b8174788d367f9)
		{
			return xb3efee94cf138f44 == x3b50be75884cb97e.xb3efee94cf138f44;
		}
		return false;
	}

	public override bool Equals(object xa59bff7708de3a18)
	{
		if (xa59bff7708de3a18 is x934fb9524f0d460a)
		{
			return Equals((x934fb9524f0d460a)xa59bff7708de3a18);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (x52b8174788d367f9.GetHashCode() << 19) ^ xb3efee94cf138f44.GetHashCode();
	}

	public override string ToString()
	{
		return "Game:" + x52b8174788d367f9 + " Code:" + xb3efee94cf138f44;
	}
}
