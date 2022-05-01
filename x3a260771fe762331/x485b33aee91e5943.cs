using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace x3a260771fe762331;

internal class x485b33aee91e5943 : IDictionary<string, byte[]>, ICollection<KeyValuePair<string, byte[]>>, IEnumerable<KeyValuePair<string, byte[]>>, IEnumerable
{
	public const string x20579840e1e81f89 = "Ps2PowerSave";

	private string _8ba449f61de5f8ec;

	private string _e9c44fbf9adae540;

	private Dictionary<string, byte[]> _3539b9fa3bc41dc1 = new Dictionary<string, byte[]>();

	public string x8ba449f61de5f8ec
	{
		get
		{
			return _8ba449f61de5f8ec;
		}
		set
		{
			_8ba449f61de5f8ec = value;
		}
	}

	public string xe9c44fbf9adae540
	{
		get
		{
			return _e9c44fbf9adae540;
		}
		set
		{
			_e9c44fbf9adae540 = value;
		}
	}

	public byte[] this[string xba08ce632055a1d9]
	{
		get
		{
			return _3539b9fa3bc41dc1[xba08ce632055a1d9];
		}
		set
		{
			_3539b9fa3bc41dc1[xba08ce632055a1d9] = value;
		}
	}

	public ICollection<string> Keys => _3539b9fa3bc41dc1.Keys;

	public ICollection<byte[]> Values => _3539b9fa3bc41dc1.Values;

	public int Count => _3539b9fa3bc41dc1.Count;

	bool ICollection<KeyValuePair<string, byte[]>>.IsReadOnly => ((ICollection<KeyValuePair<string, byte[]>>)_3539b9fa3bc41dc1).IsReadOnly;

	public bool ContainsKey(string xba08ce632055a1d9)
	{
		return _3539b9fa3bc41dc1.ContainsKey(xba08ce632055a1d9);
	}

	public void Add(string xba08ce632055a1d9, byte[] xbcea506a33cf9111)
	{
		_3539b9fa3bc41dc1.Add(xba08ce632055a1d9, xbcea506a33cf9111);
	}

	public bool Remove(string xba08ce632055a1d9)
	{
		return _3539b9fa3bc41dc1.Remove(xba08ce632055a1d9);
	}

	public bool TryGetValue(string xba08ce632055a1d9, out byte[] xbcea506a33cf9111)
	{
		return _3539b9fa3bc41dc1.TryGetValue(xba08ce632055a1d9, out xbcea506a33cf9111);
	}

	public void Clear()
	{
		_3539b9fa3bc41dc1.Clear();
	}

	private bool x2e66f071fa03e90b(KeyValuePair<string, byte[]> item)
	{
		return ((ICollection<KeyValuePair<string, byte[]>>)_3539b9fa3bc41dc1).Contains(item);
	}

	bool ICollection<KeyValuePair<string, byte[]>>.Contains(KeyValuePair<string, byte[]> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x2e66f071fa03e90b
		return this.x2e66f071fa03e90b(item);
	}

	private void xf351c9053d8f09ae(KeyValuePair<string, byte[]> item)
	{
		((ICollection<KeyValuePair<string, byte[]>>)_3539b9fa3bc41dc1).Add(item);
	}

	void ICollection<KeyValuePair<string, byte[]>>.Add(KeyValuePair<string, byte[]> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xf351c9053d8f09ae
		this.xf351c9053d8f09ae(item);
	}

	private bool x35911d7c50c036de(KeyValuePair<string, byte[]> item)
	{
		return ((ICollection<KeyValuePair<string, byte[]>>)_3539b9fa3bc41dc1).Remove(item);
	}

	bool ICollection<KeyValuePair<string, byte[]>>.Remove(KeyValuePair<string, byte[]> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x35911d7c50c036de
		return this.x35911d7c50c036de(item);
	}

	private void x4513c2ceec411caf(KeyValuePair<string, byte[]>[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		((ICollection<KeyValuePair<string, byte[]>>)_3539b9fa3bc41dc1).CopyTo(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}

	void ICollection<KeyValuePair<string, byte[]>>.CopyTo(KeyValuePair<string, byte[]>[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x4513c2ceec411caf
		this.x4513c2ceec411caf(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}

	public IEnumerator<KeyValuePair<string, byte[]>> GetEnumerator()
	{
		return _3539b9fa3bc41dc1.GetEnumerator();
	}

	private IEnumerator x05b0b83b5e6c5de6()
	{
		return _3539b9fa3bc41dc1.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in x05b0b83b5e6c5de6
		return this.x05b0b83b5e6c5de6();
	}

	public static x485b33aee91e5943 x5d95f5f98c940295(string xb41a802ca5fde63b)
	{
		using FileStream input = new FileStream(xb41a802ca5fde63b, FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader xe134235b3526fa = new BinaryReader(input);
		return x5d95f5f98c940295(xe134235b3526fa);
	}

	public static x485b33aee91e5943 x5d95f5f98c940295(BinaryReader reader)
	{
		x5e4059a15fb5fca5 x5e4059a15fb5fca6 = new x5e4059a15fb5fca5();
		byte[] array = reader.ReadBytes(12);
		string @string = Encoding.ASCII.GetString(array);
		if (@string != "Ps2PowerSave")
		{
			throw new IOException("Stream is not an ARMAX savegame file!");
		}
		x5e4059a15fb5fca6.x295cb4a1df7a5add(array);
		uint num = reader.ReadUInt32();
		byte[] x5cafa8d49ea71ea = new byte[4];
		x5e4059a15fb5fca6.x295cb4a1df7a5add(x5cafa8d49ea71ea);
		x485b33aee91e5943 x485b33aee91e5944 = new x485b33aee91e5943();
		byte[] array2 = reader.ReadBytes(32);
		string string2 = Encoding.ASCII.GetString(array2);
		char[] trimChars = new char[1];
		x485b33aee91e5944.x8ba449f61de5f8ec = string2.TrimEnd(trimChars);
		x5e4059a15fb5fca6.x295cb4a1df7a5add(array2);
		byte[] array3 = reader.ReadBytes(32);
		string string3 = Encoding.ASCII.GetString(array3);
		char[] trimChars2 = new char[1];
		x485b33aee91e5944.xe9c44fbf9adae540 = string3.TrimEnd(trimChars2);
		x5e4059a15fb5fca6.x295cb4a1df7a5add(array3);
		uint num2 = reader.ReadUInt32();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(BitConverter.GetBytes(num2));
		uint num3 = reader.ReadUInt32();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(BitConverter.GetBytes(num3));
		byte[] array4 = reader.ReadBytes((int)num2);
		x5e4059a15fb5fca6.x295cb4a1df7a5add(array4);
		if (x5e4059a15fb5fca6.xd2f68ee6f47e9dfb != num)
		{
			throw new IOException("Checksum does not match; savegame file is probably corrupted.");
		}
		using MemoryStream xdc4cce4a2fe6be = new MemoryStream(array4);
		using MemoryStream memoryStream = new MemoryStream();
		xcf043bac6e2df84d.xf76803be5e9ee2aa(xdc4cce4a2fe6be, memoryStream);
		x485b33aee91e5944.xba67e1c81a3ed562(num3, memoryStream.ToArray());
		return x485b33aee91e5944;
	}

	private int x3976eef19a227e9d(int xbcea506a33cf9111)
	{
		return (xbcea506a33cf9111 + 15) & -16;
	}

	private void xba67e1c81a3ed562(uint xc1be85414e87b810, byte[] x4a3f0a05c02f235f)
	{
		Clear();
		int num = 0;
		for (int i = 0; i < xc1be85414e87b810; i++)
		{
			int num2 = BitConverter.ToInt32(x4a3f0a05c02f235f, num);
			string @string = Encoding.ASCII.GetString(x4a3f0a05c02f235f, num + 4, 32);
			char[] trimChars = new char[1];
			string xba08ce632055a1d = @string.TrimEnd(trimChars);
			byte[] array = new byte[num2];
			Array.Copy(x4a3f0a05c02f235f, num + 36, array, 0, num2);
			Add(xba08ce632055a1d, array);
			num = x3976eef19a227e9d(num + 36 + num2 + 8) - 8;
		}
	}
}
