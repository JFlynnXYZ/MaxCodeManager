using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Mirality.Max.MaxCodes;

namespace x3a260771fe762331;

[DefaultMember("Item")]
public class x33636090f73cdcbf : IEnumerable<xa0380078f0b6cbb7>, IEnumerable
{
	public const string x20579840e1e81f89 = "PS2_CODELIST";

	private int _77fa6322561797a0;

	private uint _26424204029f48fc;

	private List<xa0380078f0b6cbb7> _aeced536f22a091b = new List<xa0380078f0b6cbb7>();

	public int x77fa6322561797a0
	{
		get
		{
			return _77fa6322561797a0;
		}
		set
		{
			_77fa6322561797a0 = value;
		}
	}

	public uint x26424204029f48fc => _26424204029f48fc;

	public int x69e1830021be7f93 => _aeced536f22a091b.Count;

	public int xbeb7785012fbaf09
	{
		get
		{
			int num = 0;
			using IEnumerator<xa0380078f0b6cbb7> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				xa0380078f0b6cbb7 current = enumerator.Current;
				num += current.xd44988f225497f3a;
			}
			return num;
		}
	}

	public uint xd38f244fb61873da
	{
		get
		{
			uint num = (uint)("PS2_CODELIST".Length + 24);
			using IEnumerator<xa0380078f0b6cbb7> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				xa0380078f0b6cbb7 current = enumerator.Current;
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
			using IEnumerator<xa0380078f0b6cbb7> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				xa0380078f0b6cbb7 current = enumerator.Current;
				RegionCode regionCode2 = current.x9b7a81a8f32a1422;
				if (regionCode2 == RegionCode.Mixed)
				{
					return regionCode2;
				}
				if (regionCode2 != regionCode)
				{
					if (regionCode != RegionCode.Unknown)
					{
						return RegionCode.Mixed;
					}
					regionCode = regionCode2;
				}
			}
			return regionCode;
		}
	}

	public xa0380078f0b6cbb7 xe6d4b1b411ed94b5 => _aeced536f22a091b[0];

	public void xd6b6ed77479ef68c(xa0380078f0b6cbb7 x6849540e228fbc76)
	{
		if (x6849540e228fbc76 == null)
		{
			throw new ArgumentNullException("game");
		}
		_aeced536f22a091b.Add(x6849540e228fbc76);
	}

	public void x52b190e626f65140(xa0380078f0b6cbb7 x6849540e228fbc76)
	{
		if (x6849540e228fbc76 != null)
		{
			_aeced536f22a091b.Remove(x6849540e228fbc76);
		}
	}

	public void x7121e9e177952651(int xc0c4c459c6ccbd00)
	{
		_aeced536f22a091b.RemoveAt(xc0c4c459c6ccbd00);
	}

	public IEnumerator<xa0380078f0b6cbb7> GetEnumerator()
	{
		return _aeced536f22a091b.GetEnumerator();
	}

	private IEnumerator x05b0b83b5e6c5de6()
	{
		return _aeced536f22a091b.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in x05b0b83b5e6c5de6
		return this.x05b0b83b5e6c5de6();
	}

	public xa0380078f0b6cbb7 x45a46c637b44a527(uint x28011ef2e60e6ef5)
	{
		using (IEnumerator<xa0380078f0b6cbb7> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				xa0380078f0b6cbb7 current = enumerator.Current;
				if (current.x52b8174788d367f9 == x28011ef2e60e6ef5)
				{
					return current;
				}
			}
		}
		return null;
	}

	public xbabc9feec6f641db x13d95bb225c01867(uint x28011ef2e60e6ef5, uint xba336f6c3ae33222)
	{
		return x45a46c637b44a527(x28011ef2e60e6ef5)?.x13d95bb225c01867(xba336f6c3ae33222);
	}

	public static x33636090f73cdcbf x5d95f5f98c940295(string xb41a802ca5fde63b)
	{
		using FileStream input = new FileStream(xb41a802ca5fde63b, FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader xe134235b3526fa = new BinaryReader(input);
		return x5d95f5f98c940295(xe134235b3526fa);
	}

	public static x33636090f73cdcbf x5d95f5f98c940295(BinaryReader xe134235b3526fa75)
	{
		if (!xe134235b3526fa75.BaseStream.CanSeek)
		{
			throw new ArgumentException("A seekable stream is required.");
		}
		x33636090f73cdcbf x33636090f73cdcbf2 = new x33636090f73cdcbf();
		byte[] bytes = xe134235b3526fa75.ReadBytes(12);
		string @string = Encoding.ASCII.GetString(bytes);
		if (@string != "PS2_CODELIST")
		{
			throw new IOException("Stream is not an ARMAX codelist!");
		}
		x33636090f73cdcbf2._77fa6322561797a0 = xe134235b3526fa75.ReadInt32();
		if (xe134235b3526fa75.ReadInt32() != 0)
		{
			throw new IOException("Expected zero dword in codelist header, but wasn't.");
		}
		uint num = xe134235b3526fa75.ReadUInt32();
		uint num2 = xe134235b3526fa75.ReadUInt32();
		long position = xe134235b3526fa75.BaseStream.Position;
		uint num3 = xe134235b3526fa75.ReadUInt32();
		x33636090f73cdcbf2._26424204029f48fc = xe134235b3526fa75.ReadUInt32();
		for (int i = 0; i < num3; i++)
		{
			x33636090f73cdcbf2._aeced536f22a091b.Add(xa0380078f0b6cbb7.x5d95f5f98c940295(xe134235b3526fa75));
		}
		if (xe134235b3526fa75.BaseStream.Position != position + num)
		{
			throw new IOException("Inconsistent structural data, or stream has been misread.");
		}
		if (x33636090f73cdcbf2.x26424204029f48fc != x33636090f73cdcbf2.xbeb7785012fbaf09)
		{
			throw new IOException("Number of codes in header does not match number of codes read.");
		}
		byte[] x5cafa8d49ea71ea = xfade946b595daf3e(xe134235b3526fa75, position, num);
		x5e4059a15fb5fca5 x5e4059a15fb5fca6 = new x5e4059a15fb5fca5();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(x5cafa8d49ea71ea);
		if (x5e4059a15fb5fca6.xd2f68ee6f47e9dfb != num2)
		{
			throw new IOException("Checksum does not match; codelist is probably corrupted.");
		}
		return x33636090f73cdcbf2;
	}

	public void x0acd3c2012ea2ee8(string xb41a802ca5fde63b)
	{
		using FileStream xcf18e5243f8d5fd = new FileStream(xb41a802ca5fde63b, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		x0acd3c2012ea2ee8(xcf18e5243f8d5fd);
	}

	public void x0acd3c2012ea2ee8(Stream xcf18e5243f8d5fd3)
	{
		if (!xcf18e5243f8d5fd3.CanSeek)
		{
			throw new ArgumentException("A seekable stream is required.");
		}
		if (!xcf18e5243f8d5fd3.CanRead || !xcf18e5243f8d5fd3.CanWrite)
		{
			throw new ArgumentException("A read/write stream is required.");
		}
		BinaryWriter binaryWriter = new BinaryWriter(xcf18e5243f8d5fd3);
		binaryWriter.Write(Encoding.ASCII.GetBytes("PS2_CODELIST"));
		binaryWriter.Write(x77fa6322561797a0);
		binaryWriter.Write(0u);
		long position = binaryWriter.BaseStream.Position;
		binaryWriter.Write(0u);
		binaryWriter.Write(0u);
		long position2 = binaryWriter.BaseStream.Position;
		binaryWriter.Write(x69e1830021be7f93);
		binaryWriter.Write(xbeb7785012fbaf09);
		using (IEnumerator<xa0380078f0b6cbb7> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				xa0380078f0b6cbb7 current = enumerator.Current;
				current.x0acd3c2012ea2ee8(binaryWriter);
			}
		}
		long position3 = binaryWriter.BaseStream.Position;
		int num = (int)(position3 - position2);
		BinaryReader xe134235b3526fa = new BinaryReader(xcf18e5243f8d5fd3);
		byte[] x5cafa8d49ea71ea = xfade946b595daf3e(xe134235b3526fa, position2, num);
		x5e4059a15fb5fca5 x5e4059a15fb5fca6 = new x5e4059a15fb5fca5();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(x5cafa8d49ea71ea);
		binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);
		binaryWriter.Write(num);
		binaryWriter.Write((uint)x5e4059a15fb5fca6.xd2f68ee6f47e9dfb);
		binaryWriter.BaseStream.Seek(position3, SeekOrigin.Begin);
	}

	public void xd5da23b762ce52a2(x33636090f73cdcbf x3b50be75884cb97e)
	{
		if (x3b50be75884cb97e == null)
		{
			return;
		}
		foreach (xa0380078f0b6cbb7 item in x3b50be75884cb97e)
		{
			xa0380078f0b6cbb7 xa0380078f0b6cbb8 = x45a46c637b44a527(item.x52b8174788d367f9);
			if (xa0380078f0b6cbb8 == null)
			{
				xd6b6ed77479ef68c(item.Clone());
			}
			else
			{
				xa0380078f0b6cbb8.xd5da23b762ce52a2(item);
			}
		}
		x77fa6322561797a0 = Math.Max(x77fa6322561797a0, x3b50be75884cb97e.x77fa6322561797a0);
	}

	private static byte[] xfade946b595daf3e(BinaryReader xe134235b3526fa75, long x4ccf11aafc489179, long x75a9c8b35c93c27a)
	{
		xe134235b3526fa75.BaseStream.Seek(x4ccf11aafc489179, SeekOrigin.Begin);
		return xe134235b3526fa75.ReadBytes((int)x75a9c8b35c93c27a);
	}

	internal static string x6cb7e4df256c4673(BinaryReader xe134235b3526fa75)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char c;
		do
		{
			c = (char)xe134235b3526fa75.ReadUInt16();
			if (c != 0)
			{
				stringBuilder.Append(c);
			}
		}
		while (c != 0);
		return stringBuilder.ToString();
	}

	internal static void xd80e037acfa32563(BinaryWriter xbdfb620b7167944b, string xb41faee6912a2313)
	{
		foreach (char value in xb41faee6912a2313)
		{
			xbdfb620b7167944b.Write((ushort)value);
		}
		xbdfb620b7167944b.Write((ushort)0);
	}
}
