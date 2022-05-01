using System;
using System.Collections.Generic;
using Mirality.Max.MaxCodes;

namespace x2ac61696da69bb5f;

public class x047611ec9892e059 : ICloneable
{
	public class x8f4d4d97dd0fc840 : ICloneable
	{
		public byte x3146d638ec378671;

		public uint x6b73aa01aa019d3a;

		public x8f4d4d97dd0fc840(byte x43163d22e8cd5a71, uint x4a3f0a05c02f235f)
		{
			x3146d638ec378671 = x43163d22e8cd5a71;
			x6b73aa01aa019d3a = x4a3f0a05c02f235f;
		}

		public x8f4d4d97dd0fc840 Clone()
		{
			return (x8f4d4d97dd0fc840)MemberwiseClone();
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

	public class x7a274f60ab25f2b9 : ICloneable
	{
		public uint x1d5cfa3bffdfb042;

		public uint xd2f68ee6f47e9dfb;

		public x7a274f60ab25f2b9(uint x179bb663e71b1f59, uint xbcea506a33cf9111)
		{
			x1d5cfa3bffdfb042 = x179bb663e71b1f59;
			xd2f68ee6f47e9dfb = xbcea506a33cf9111;
		}

		public x7a274f60ab25f2b9 Clone()
		{
			return (x7a274f60ab25f2b9)MemberwiseClone();
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

	public uint x52b8174788d367f9;

	public uint xb3efee94cf138f44;

	public bool xda8f238d1a051872;

	public bool xd0431a295f2ed35f;

	public RegionCode x4b94e58155458175 = RegionCode.Unknown;

	public List<x8f4d4d97dd0fc840> xa54a49b4cb11c6d1 = new List<x8f4d4d97dd0fc840>();

	public List<x7a274f60ab25f2b9> xea84056d876cd25a = new List<x7a274f60ab25f2b9>();

	public x047611ec9892e059()
	{
	}

	public x047611ec9892e059(uint x28011ef2e60e6ef5, uint xba336f6c3ae33222, RegionCode xa4d52e34b62b5495)
		: this()
	{
		x52b8174788d367f9 = x28011ef2e60e6ef5;
		xb3efee94cf138f44 = xba336f6c3ae33222;
		x4b94e58155458175 = xa4d52e34b62b5495;
	}

	public x047611ec9892e059 Clone()
	{
		x047611ec9892e059 x047611ec9892e60 = (x047611ec9892e059)MemberwiseClone();
		x047611ec9892e60.xa54a49b4cb11c6d1 = new List<x8f4d4d97dd0fc840>();
		foreach (x8f4d4d97dd0fc840 item in xa54a49b4cb11c6d1)
		{
			x047611ec9892e60.xa54a49b4cb11c6d1.Add(item.Clone());
		}
		x047611ec9892e60.xea84056d876cd25a = new List<x7a274f60ab25f2b9>();
		foreach (x7a274f60ab25f2b9 item2 in xea84056d876cd25a)
		{
			x047611ec9892e60.xea84056d876cd25a.Add(item2.Clone());
		}
		return x047611ec9892e60;
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

	public x8f4d4d97dd0fc840 x4521e8bf4ec2b6be(byte x43163d22e8cd5a71)
	{
		foreach (x8f4d4d97dd0fc840 item in xa54a49b4cb11c6d1)
		{
			if (item.x3146d638ec378671 == x43163d22e8cd5a71)
			{
				return item;
			}
		}
		return null;
	}

	public void x6a0f374870b7d174(byte x43163d22e8cd5a71)
	{
		xa54a49b4cb11c6d1.RemoveAll((x8f4d4d97dd0fc840 xe413319369b234aa) => xe413319369b234aa.x3146d638ec378671 == x43163d22e8cd5a71);
	}
}
