using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Mirality.Max.MaxCodes;

namespace x3a260771fe762331;

[DefaultMember("Item")]
public class Codelist : IEnumerable<GameEntry>, IEnumerable
{
	public const string PS2_CODELIST = "PS2_CODELIST";

	private int _77fa6322561797a0;

	private uint _26424204029f48fc;

	private List<GameEntry> _aeced536f22a091b = new List<GameEntry>();

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
			using IEnumerator<GameEntry> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				GameEntry current = enumerator.Current;
				num += current.xd44988f225497f3a;
			}
			return num;
		}
	}

	public uint xd38f244fb61873da
	{
		get
		{
			uint num = (uint)(PS2_CODELIST.Length + 24);
			using IEnumerator<GameEntry> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				GameEntry current = enumerator.Current;
				num += current.xd38f244fb61873da;
			}
			return num;
		}
	}

	public RegionCode Region
	{
		get
		{
			RegionCode regionCode = RegionCode.Unknown;
			using IEnumerator<GameEntry> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				GameEntry current = enumerator.Current;
				RegionCode regionCode2 = current.Region;
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

	public GameEntry xe6d4b1b411ed94b5 => _aeced536f22a091b[0];

	public void xd6b6ed77479ef68c(GameEntry game)
	{
		if (game == null)
		{
			throw new ArgumentNullException("game");
		}
		_aeced536f22a091b.Add(game);
	}

	public void x52b190e626f65140(GameEntry game)
	{
		if (game != null)
		{
			_aeced536f22a091b.Remove(game);
		}
	}

	public void x7121e9e177952651(int xc0c4c459c6ccbd00)
	{
		_aeced536f22a091b.RemoveAt(xc0c4c459c6ccbd00);
	}

	public IEnumerator<GameEntry> GetEnumerator()
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

	public GameEntry x45a46c637b44a527(uint x28011ef2e60e6ef5)
	{
		using (IEnumerator<GameEntry> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GameEntry current = enumerator.Current;
				if (current.x52b8174788d367f9 == x28011ef2e60e6ef5)
				{
					return current;
				}
			}
		}
		return null;
	}

	public CodeEntry x13d95bb225c01867(uint x28011ef2e60e6ef5, uint xba336f6c3ae33222)
	{
		return x45a46c637b44a527(x28011ef2e60e6ef5)?.x13d95bb225c01867(xba336f6c3ae33222);
	}

	public static Codelist x5d95f5f98c940295(string xb41a802ca5fde63b)
	{
		using FileStream input = new FileStream(xb41a802ca5fde63b, FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader xe134235b3526fa = new BinaryReader(input);
		return x5d95f5f98c940295(xe134235b3526fa);
	}

	public static Codelist x5d95f5f98c940295(BinaryReader reader)
	{
		if (!reader.BaseStream.CanSeek)
		{
			throw new ArgumentException("A seekable stream is required.");
		}
		Codelist x33636090f73cdcbf2 = new Codelist();
		byte[] bytes = reader.ReadBytes(12);
		string @string = Encoding.ASCII.GetString(bytes);
		if (@string != PS2_CODELIST)
		{
			throw new IOException("Stream is not an ARMAX codelist!");
		}
		x33636090f73cdcbf2._77fa6322561797a0 = reader.ReadInt32();
		if (reader.ReadInt32() != 0)
		{
			throw new IOException("Expected zero dword in codelist header, but wasn't.");
		}
		uint num = reader.ReadUInt32();
		uint num2 = reader.ReadUInt32();
		long position = reader.BaseStream.Position;
		uint num3 = reader.ReadUInt32();
		x33636090f73cdcbf2._26424204029f48fc = reader.ReadUInt32();
		for (int i = 0; i < num3; i++)
		{
			x33636090f73cdcbf2._aeced536f22a091b.Add(GameEntry.x5d95f5f98c940295(reader));
		}
		if (reader.BaseStream.Position != position + num)
		{
			throw new IOException("Inconsistent structural data, or stream has been misread.");
		}
		if (x33636090f73cdcbf2.x26424204029f48fc != x33636090f73cdcbf2.xbeb7785012fbaf09)
		{
			throw new IOException("Number of codes in header does not match number of codes read.");
		}
		byte[] x5cafa8d49ea71ea = xfade946b595daf3e(reader, position, num);
		x5e4059a15fb5fca5 x5e4059a15fb5fca6 = new x5e4059a15fb5fca5();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(x5cafa8d49ea71ea);
		if (x5e4059a15fb5fca6.xd2f68ee6f47e9dfb != num2)
		{
			throw new IOException("Checksum does not match; codelist is probably corrupted.");
		}
		return x33636090f73cdcbf2;
	}

	public void ExportCodelist(string FilePath, bool IsText = false)
	{
		using FileStream FileStream = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		if (IsText)
		{
			ExportCodelistText(FileStream);
		}
		else
		{
			ExportCodelistBinary(FileStream);
		}
	}

	public void ExportCodelistBinary(Stream Stream)
	{
		if (!Stream.CanSeek)
		{
			throw new ArgumentException("A seekable stream is required.");
		}
		if (!Stream.CanRead || !Stream.CanWrite)
		{
			throw new ArgumentException("A read/write stream is required.");
		}
		BinaryWriter binaryWriter = new BinaryWriter(Stream);
		binaryWriter.Write(Encoding.ASCII.GetBytes(PS2_CODELIST));
		binaryWriter.Write(x77fa6322561797a0);
		binaryWriter.Write(0u);
		long position = binaryWriter.BaseStream.Position;
		binaryWriter.Write(0u);
		binaryWriter.Write(0u);
		long position2 = binaryWriter.BaseStream.Position;
		binaryWriter.Write(x69e1830021be7f93);
		binaryWriter.Write(xbeb7785012fbaf09);
		using (IEnumerator<GameEntry> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GameEntry current = enumerator.Current;
				current.Write(binaryWriter);
			}
		}
		long position3 = binaryWriter.BaseStream.Position;
		int num = (int)(position3 - position2);
		BinaryReader xe134235b3526fa = new BinaryReader(Stream);
		byte[] x5cafa8d49ea71ea = xfade946b595daf3e(xe134235b3526fa, position2, num);
		x5e4059a15fb5fca5 x5e4059a15fb5fca6 = new x5e4059a15fb5fca5();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(x5cafa8d49ea71ea);
		binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);
		binaryWriter.Write(num);
		binaryWriter.Write((uint)x5e4059a15fb5fca6.xd2f68ee6f47e9dfb);
		binaryWriter.BaseStream.Seek(position3, SeekOrigin.Begin);
	}
	
	public void ExportCodelistText(Stream Stream)
	{
		if (!Stream.CanSeek)
		{
			throw new ArgumentException("A seekable stream is required.");
		}
		if (!Stream.CanRead || !Stream.CanWrite)
		{
			throw new ArgumentException("A read/write stream is required.");
		}
		StreamWriter stringWriter = new StreamWriter(Stream);
		using (IEnumerator<GameEntry> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GameEntry current = enumerator.Current;
				current.Write(stringWriter);
			}
		}
		
	}

	public void xd5da23b762ce52a2(Codelist x3b50be75884cb97e)
	{
		if (x3b50be75884cb97e == null)
		{
			return;
		}
		foreach (GameEntry item in x3b50be75884cb97e)
		{
			GameEntry xa0380078f0b6cbb8 = x45a46c637b44a527(item.x52b8174788d367f9);
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

	private static byte[] xfade946b595daf3e(BinaryReader reader, long x4ccf11aafc489179, long x75a9c8b35c93c27a)
	{
		reader.BaseStream.Seek(x4ccf11aafc489179, SeekOrigin.Begin);
		return reader.ReadBytes((int)x75a9c8b35c93c27a);
	}

	internal static string x6cb7e4df256c4673(BinaryReader reader)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char c;
		do
		{
			c = (char)reader.ReadUInt16();
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
