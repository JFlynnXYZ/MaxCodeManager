using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Mirality.Max.MaxCodes;
using x2ac61696da69bb5f;

namespace x3a260771fe762331;

[DefaultMember("Item")]
public class xa0380078f0b6cbb7 : IEnumerable<xbabc9feec6f641db>, ICloneable, IEnumerable
{
	private uint _52b8174788d367f9;

	private string _759aa16c2016a289 = "";

	private string _4e020dae918bd2ce = "";

	private List<xbabc9feec6f641db> _9425d7602dc80ff4 = new List<xbabc9feec6f641db>();

	public uint x52b8174788d367f9
	{
		get
		{
			return _52b8174788d367f9;
		}
		set
		{
			_52b8174788d367f9 = value;
		}
	}

	public string x759aa16c2016a289
	{
		get
		{
			return _759aa16c2016a289;
		}
		set
		{
			_759aa16c2016a289 = value;
		}
	}

	public string x4e020dae918bd2ce
	{
		get
		{
			return _4e020dae918bd2ce;
		}
		set
		{
			_4e020dae918bd2ce = value;
		}
	}

	public uint xd38f244fb61873da
	{
		get
		{
			uint num = (uint)(4 + (x759aa16c2016a289.Length + x4e020dae918bd2ce.Length + 2) * 2 + 4);
			using IEnumerator<xbabc9feec6f641db> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				xbabc9feec6f641db current = enumerator.Current;
				num += current.xd38f244fb61873da;
			}
			return num;
		}
	}

	public RegionCode x9b7a81a8f32a1422
	{
		get
		{
			RegionCode regionCode = RegionCode.Unknown;
			using IEnumerator<xbabc9feec6f641db> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				xbabc9feec6f641db current = enumerator.Current;
				if (current.xb1d0737e4174a713 != regionCode)
				{
					if (regionCode != RegionCode.Unknown)
					{
						return RegionCode.Mixed;
					}
					regionCode = current.xb1d0737e4174a713;
				}
			}
			return regionCode;
		}
	}

	public int xd44988f225497f3a => _9425d7602dc80ff4.Count;

	public xbabc9feec6f641db xe6d4b1b411ed94b5 => _9425d7602dc80ff4[0];

	public IEnumerator<xbabc9feec6f641db> GetEnumerator()
	{
		return _9425d7602dc80ff4.GetEnumerator();
	}

	private IEnumerator x05b0b83b5e6c5de6()
	{
		return _9425d7602dc80ff4.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in x05b0b83b5e6c5de6
		return this.x05b0b83b5e6c5de6();
	}

	public xa0380078f0b6cbb7 Clone()
	{
		xa0380078f0b6cbb7 xa0380078f0b6cbb8 = (xa0380078f0b6cbb7)MemberwiseClone();
		xa0380078f0b6cbb8._9425d7602dc80ff4 = new List<xbabc9feec6f641db>();
		using IEnumerator<xbabc9feec6f641db> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			xbabc9feec6f641db current = enumerator.Current;
			xa0380078f0b6cbb8.xd6b6ed77479ef68c(current.Clone());
		}
		return xa0380078f0b6cbb8;
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

	public xbabc9feec6f641db x13d95bb225c01867(uint xba336f6c3ae33222)
	{
		using (IEnumerator<xbabc9feec6f641db> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				xbabc9feec6f641db current = enumerator.Current;
				if (current.xb3efee94cf138f44 == xba336f6c3ae33222)
				{
					return current;
				}
			}
		}
		return null;
	}

	public void xd6b6ed77479ef68c(xbabc9feec6f641db x9035cf16181332fc)
	{
		if (x9035cf16181332fc.xa0380078f0b6cbb7 != null)
		{
			throw new ArgumentException("Cannot add a code to a game when it is already in another game.", "code");
		}
		_9425d7602dc80ff4.Add(x9035cf16181332fc);
		x9035cf16181332fc.xa0380078f0b6cbb7 = this;
	}

	public void xf82029c4e8b4cfc3(IEnumerable<xbabc9feec6f641db> xcdff170dbac909bf)
	{
		_9425d7602dc80ff4.AddRange(xcdff170dbac909bf);
	}

	public void x52b190e626f65140(xbabc9feec6f641db x9035cf16181332fc)
	{
		_9425d7602dc80ff4.Remove(x9035cf16181332fc);
		if (x9035cf16181332fc.xa0380078f0b6cbb7 == this)
		{
			x9035cf16181332fc.xa0380078f0b6cbb7 = null;
		}
	}

	public void x57bf52bb3d1c2d43(xbabc9feec6f641db x7154be0fb4f7bcf8, xbabc9feec6f641db x452dc757938a7923)
	{
		if (x7154be0fb4f7bcf8 == null)
		{
			throw new ArgumentNullException("oldCode");
		}
		if (x452dc757938a7923 == null)
		{
			throw new ArgumentNullException("newCode");
		}
		int num = _9425d7602dc80ff4.IndexOf(x7154be0fb4f7bcf8);
		if (num == -1)
		{
			throw new ArgumentException("Cannot replace nonexistent code.", "oldCode");
		}
		_9425d7602dc80ff4.RemoveAt(num);
		_9425d7602dc80ff4.Insert(num, x452dc757938a7923);
		x7154be0fb4f7bcf8.xa0380078f0b6cbb7 = null;
		x452dc757938a7923.xa0380078f0b6cbb7 = this;
	}

	public void xd5da23b762ce52a2(xa0380078f0b6cbb7 x3b50be75884cb97e)
	{
		foreach (xbabc9feec6f641db item in x3b50be75884cb97e)
		{
			xbabc9feec6f641db xbabc9feec6f641db2 = x13d95bb225c01867(item.xb3efee94cf138f44);
			if (xbabc9feec6f641db2 == null)
			{
				xd6b6ed77479ef68c(item.Clone());
			}
		}
	}

	public int x2ee5ad3d826ed0fe(xbabc9feec6f641db x9035cf16181332fc)
	{
		return _9425d7602dc80ff4.IndexOf(x9035cf16181332fc);
	}

	public void x01b2723108ff3dfe(xbabc9feec6f641db x9035cf16181332fc, int x873721d4383ca28a)
	{
		int num = _9425d7602dc80ff4.IndexOf(x9035cf16181332fc);
		if (num != -1 && x873721d4383ca28a >= 0 && x873721d4383ca28a < _9425d7602dc80ff4.Count)
		{
			_9425d7602dc80ff4.RemoveAt(num);
			_9425d7602dc80ff4.Insert(x873721d4383ca28a, x9035cf16181332fc);
		}
	}

	public void x93b8c3e46ffd8a96()
	{
		bool flag = false;
		while (!flag)
		{
			flag = true;
			for (int num = _9425d7602dc80ff4.Count - 1; num >= 0; num--)
			{
				xbabc9feec6f641db xbabc9feec6f641db2 = _9425d7602dc80ff4[num];
				if (xbabc9feec6f641db2.xbe23edc82b0342c0 != null)
				{
					x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc = xbabc9feec6f641db2.xbe23edc82b0342c0.x4521e8bf4ec2b6be(4);
					if (x8f4d4d97dd0fc != null)
					{
						xbabc9feec6f641db xbabc9feec6f641db3 = x13d95bb225c01867(x8f4d4d97dd0fc.x6b73aa01aa019d3a);
						if (xbabc9feec6f641db3 != null)
						{
							int num2 = _9425d7602dc80ff4.IndexOf(xbabc9feec6f641db2);
							int num3 = _9425d7602dc80ff4.IndexOf(xbabc9feec6f641db3);
							if (num3 >= num2)
							{
								_9425d7602dc80ff4.RemoveAt(num2);
								_9425d7602dc80ff4.Insert(num3 + 1, xbabc9feec6f641db2);
								flag = false;
								break;
							}
						}
					}
				}
			}
		}
	}

	public static xa0380078f0b6cbb7 x5d95f5f98c940295(BinaryReader xe134235b3526fa75)
	{
		xa0380078f0b6cbb7 xa0380078f0b6cbb8 = new xa0380078f0b6cbb7();
		xa0380078f0b6cbb8._52b8174788d367f9 = xe134235b3526fa75.ReadUInt32();
		xa0380078f0b6cbb8._759aa16c2016a289 = xbabc9feec6f641db.x6b7a089e1d3477ec(x33636090f73cdcbf.x6cb7e4df256c4673(xe134235b3526fa75));
		xa0380078f0b6cbb8._4e020dae918bd2ce = xbabc9feec6f641db.x6b7a089e1d3477ec(x33636090f73cdcbf.x6cb7e4df256c4673(xe134235b3526fa75));
		uint num = xe134235b3526fa75.ReadUInt32();
		for (int i = 0; i < num; i++)
		{
			xa0380078f0b6cbb8.xd6b6ed77479ef68c(xbabc9feec6f641db.x5d95f5f98c940295(xe134235b3526fa75));
		}
		return xa0380078f0b6cbb8;
	}

	public void x0acd3c2012ea2ee8(BinaryWriter xbdfb620b7167944b)
	{
		xbdfb620b7167944b.Write(x52b8174788d367f9);
		x33636090f73cdcbf.xd80e037acfa32563(xbdfb620b7167944b, xbabc9feec6f641db.x9e58cde81e068cff(x759aa16c2016a289));
		x33636090f73cdcbf.xd80e037acfa32563(xbdfb620b7167944b, xbabc9feec6f641db.x9e58cde81e068cff(x4e020dae918bd2ce));
		xbdfb620b7167944b.Write((uint)xd44988f225497f3a);
		using IEnumerator<xbabc9feec6f641db> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			xbabc9feec6f641db current = enumerator.Current;
			current.x0acd3c2012ea2ee8(xbdfb620b7167944b);
		}
	}
}
