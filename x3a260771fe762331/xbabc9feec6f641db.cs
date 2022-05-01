using System;
using System.IO;
using System.Text;
using Mirality.Max.MaxCodes;
using x2ac61696da69bb5f;

namespace x3a260771fe762331;

public class xbabc9feec6f641db : ICloneable
{
	private uint _b3efee94cf138f44;

	private xa0380078f0b6cbb7 _a0380078f0b6cbb7;

	private string _759aa16c2016a289 = "";

	private string _4e020dae918bd2ce = "";

	private byte[] _fd7718c88ee45a3e = new byte[3];

	private xf6e5c5e1901f893f _7e5b09fa2269d9a5 = new xf6e5c5e1901f893f(new uint[0]);

	private x047611ec9892e059 _be23edc82b0342c0;

	private static string[] x3713acf1774ed802 = new string[32]
	{
		null, null, null, "L3", "R3", null, null, null, null, null,
		null, null, null, null, null, null, "Cross", "Square", "Triangle", "Circle",
		"Select", "Start", "Up", "Right", "Down", "Left", "L1", "L2", "R1", "R2",
		null, null
	};

	public uint xb3efee94cf138f44
	{
		get
		{
			return _b3efee94cf138f44;
		}
		set
		{
			_b3efee94cf138f44 = value;
		}
	}

	public xa0380078f0b6cbb7 xa0380078f0b6cbb7
	{
		get
		{
			return _a0380078f0b6cbb7;
		}
		internal set
		{
			_a0380078f0b6cbb7 = value;
		}
	}

	public string Name
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

	public byte[] xfd7718c88ee45a3e => _fd7718c88ee45a3e;

	public bool xda8f238d1a051872
	{
		get
		{
			return xfd7718c88ee45a3e[1] == 1;
		}
		set
		{
			xfd7718c88ee45a3e[1] = (byte)(value ? 1u : 0u);
		}
	}

	public RegionCode xb1d0737e4174a713
	{
		get
		{
			return (RegionCode)xfd7718c88ee45a3e[2];
		}
		set
		{
			xfd7718c88ee45a3e[2] = (byte)value;
		}
	}

	public xf6e5c5e1901f893f x7e5b09fa2269d9a5
	{
		get
		{
			return _7e5b09fa2269d9a5;
		}
		set
		{
			_7e5b09fa2269d9a5 = value;
			_be23edc82b0342c0 = null;
		}
	}

	public x047611ec9892e059 xbe23edc82b0342c0
	{
		get
		{
			return _be23edc82b0342c0;
		}
		set
		{
			_be23edc82b0342c0 = value;
		}
	}

	public string x4191326b8c285bfa => string.Join("  ", x7e5b09fa2269d9a5.xa9edb3b115d067da());

	public uint xd38f244fb61873da => (uint)(4 + (Name.Length + x4e020dae918bd2ce.Length + 2) * 2 + xfd7718c88ee45a3e.Length + 4 + x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length * 4);

	public xbabc9feec6f641db Clone()
	{
		xbabc9feec6f641db xbabc9feec6f641db2 = (xbabc9feec6f641db)MemberwiseClone();
		xbabc9feec6f641db2.xa0380078f0b6cbb7 = null;
		xbabc9feec6f641db2._fd7718c88ee45a3e = (byte[])xfd7718c88ee45a3e.Clone();
		if (x7e5b09fa2269d9a5 != null)
		{
			xbabc9feec6f641db2.x7e5b09fa2269d9a5 = x7e5b09fa2269d9a5.Clone();
		}
		if (xbe23edc82b0342c0 != null)
		{
			xbabc9feec6f641db2.xbe23edc82b0342c0 = xbe23edc82b0342c0.Clone();
		}
		return xbabc9feec6f641db2;
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

	public static xbabc9feec6f641db x5d95f5f98c940295(BinaryReader xe134235b3526fa75)
	{
		if (xe134235b3526fa75 == null)
		{
			throw new ArgumentNullException("reader");
		}
		xbabc9feec6f641db xbabc9feec6f641db2 = new xbabc9feec6f641db();
		xbabc9feec6f641db2._b3efee94cf138f44 = xe134235b3526fa75.ReadUInt32();
		xbabc9feec6f641db2._759aa16c2016a289 = x6b7a089e1d3477ec(x33636090f73cdcbf.x6cb7e4df256c4673(xe134235b3526fa75));
		xbabc9feec6f641db2._4e020dae918bd2ce = x6b7a089e1d3477ec(x33636090f73cdcbf.x6cb7e4df256c4673(xe134235b3526fa75));
		xbabc9feec6f641db2._fd7718c88ee45a3e = xe134235b3526fa75.ReadBytes(3);
		int num = xe134235b3526fa75.ReadInt32();
		if (((uint)num & (true ? 1u : 0u)) != 0)
		{
			throw new IOException("Code size mismatch in code id " + xbabc9feec6f641db2.xb3efee94cf138f44);
		}
		if (num > 0)
		{
			uint[] array = new uint[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = xe134235b3526fa75.ReadUInt32();
			}
			xbabc9feec6f641db2._7e5b09fa2269d9a5 = new xf6e5c5e1901f893f(array);
		}
		return xbabc9feec6f641db2;
	}

	public void x0acd3c2012ea2ee8(BinaryWriter xbdfb620b7167944b)
	{
		if (xbdfb620b7167944b == null)
		{
			throw new ArgumentNullException("writer");
		}
		xbdfb620b7167944b.Write(xb3efee94cf138f44);
		x33636090f73cdcbf.xd80e037acfa32563(xbdfb620b7167944b, x9e58cde81e068cff(Name));
		x33636090f73cdcbf.xd80e037acfa32563(xbdfb620b7167944b, x9e58cde81e068cff(x4e020dae918bd2ce));
		xbdfb620b7167944b.Write(xfd7718c88ee45a3e);
		xbdfb620b7167944b.Write((uint)x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length);
		for (int i = 0; i < x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length; i++)
		{
			xbdfb620b7167944b.Write(x7e5b09fa2269d9a5.x6b73aa01aa019d3a[i]);
		}
	}

	public static string x6b7a089e1d3477ec(string xb41faee6912a2313)
	{
		if (xb41faee6912a2313 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in xb41faee6912a2313)
		{
			if (c < ' ' && x3713acf1774ed802[(uint)c] != null)
			{
				stringBuilder.Append("{" + x3713acf1774ed802[(uint)c] + "}");
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	public static string x9e58cde81e068cff(string xb41faee6912a2313)
	{
		if (xb41faee6912a2313 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(xb41faee6912a2313);
		for (int i = 0; i < 32; i++)
		{
			if (x3713acf1774ed802[i] != null)
			{
				stringBuilder.Replace("{" + x3713acf1774ed802[i] + "}", new string((char)i, 1));
			}
		}
		return stringBuilder.ToString();
	}

	public void x548b1e187be884eb()
	{
		if (xbe23edc82b0342c0 == null)
		{
			throw new InvalidOperationException("Cannot update from nonexistent decrypted data.");
		}
		if (x7e5b09fa2269d9a5 == null)
		{
			throw new InvalidOperationException("Encrypted code data expected to be present already.");
		}
		xb3efee94cf138f44 = xbe23edc82b0342c0.xb3efee94cf138f44;
		xda8f238d1a051872 = xbe23edc82b0342c0.xda8f238d1a051872;
		xb1d0737e4174a713 = xbe23edc82b0342c0.x4b94e58155458175;
	}
}
