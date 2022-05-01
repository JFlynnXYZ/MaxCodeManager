using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace x3a260771fe762331;

internal class x89c597989b13898e : IDictionary<string, byte[]>, ICollection<KeyValuePair<string, byte[]>>, IEnumerable<KeyValuePair<string, byte[]>>, IEnumerable
{
	public const string x20579840e1e81f89 = "PS2_SETTINGS";

	public const string x3e45f27b1d181f0f = "USER_LIST";

	private Codelist _33636090f73cdcbf;

	private Dictionary<string, byte[]> _a37c212c70888855 = new Dictionary<string, byte[]>();

	public Codelist Codelist => _33636090f73cdcbf;

	public byte[] this[string xba08ce632055a1d9]
	{
		get
		{
			return _a37c212c70888855[xba08ce632055a1d9];
		}
		set
		{
			_a37c212c70888855[xba08ce632055a1d9] = value;
		}
	}

	public ICollection<string> Keys => _a37c212c70888855.Keys;

	public ICollection<byte[]> Values => _a37c212c70888855.Values;

	public int Count => _a37c212c70888855.Count;

	bool ICollection<KeyValuePair<string, byte[]>>.IsReadOnly => ((ICollection<KeyValuePair<string, byte[]>>)_a37c212c70888855).IsReadOnly;

	public bool ContainsKey(string xba08ce632055a1d9)
	{
		return _a37c212c70888855.ContainsKey(xba08ce632055a1d9);
	}

	public void Add(string xba08ce632055a1d9, byte[] xbcea506a33cf9111)
	{
		_a37c212c70888855.Add(xba08ce632055a1d9, xbcea506a33cf9111);
	}

	public bool Remove(string xba08ce632055a1d9)
	{
		return _a37c212c70888855.Remove(xba08ce632055a1d9);
	}

	public bool TryGetValue(string xba08ce632055a1d9, out byte[] xbcea506a33cf9111)
	{
		return _a37c212c70888855.TryGetValue(xba08ce632055a1d9, out xbcea506a33cf9111);
	}

	public void Clear()
	{
		_a37c212c70888855.Clear();
	}

	private bool x2e66f071fa03e90b(KeyValuePair<string, byte[]> item)
	{
		return ((ICollection<KeyValuePair<string, byte[]>>)_a37c212c70888855).Contains(item);
	}

	bool ICollection<KeyValuePair<string, byte[]>>.Contains(KeyValuePair<string, byte[]> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x2e66f071fa03e90b
		return this.x2e66f071fa03e90b(item);
	}

	private void xf351c9053d8f09ae(KeyValuePair<string, byte[]> item)
	{
		((ICollection<KeyValuePair<string, byte[]>>)_a37c212c70888855).Add(item);
	}

	void ICollection<KeyValuePair<string, byte[]>>.Add(KeyValuePair<string, byte[]> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xf351c9053d8f09ae
		this.xf351c9053d8f09ae(item);
	}

	private bool x35911d7c50c036de(KeyValuePair<string, byte[]> item)
	{
		return ((ICollection<KeyValuePair<string, byte[]>>)_a37c212c70888855).Remove(item);
	}

	bool ICollection<KeyValuePair<string, byte[]>>.Remove(KeyValuePair<string, byte[]> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x35911d7c50c036de
		return this.x35911d7c50c036de(item);
	}

	private void x4513c2ceec411caf(KeyValuePair<string, byte[]>[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		((ICollection<KeyValuePair<string, byte[]>>)_a37c212c70888855).CopyTo(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}

	void ICollection<KeyValuePair<string, byte[]>>.CopyTo(KeyValuePair<string, byte[]>[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x4513c2ceec411caf
		this.x4513c2ceec411caf(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}

	public IEnumerator<KeyValuePair<string, byte[]>> GetEnumerator()
	{
		return _a37c212c70888855.GetEnumerator();
	}

	private IEnumerator x05b0b83b5e6c5de6()
	{
		return _a37c212c70888855.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in x05b0b83b5e6c5de6
		return this.x05b0b83b5e6c5de6();
	}

	public static x89c597989b13898e x5d95f5f98c940295(string xb41a802ca5fde63b)
	{
		using FileStream input = new FileStream(xb41a802ca5fde63b, FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader xe134235b3526fa = new BinaryReader(input);
		return x5d95f5f98c940295(xe134235b3526fa);
	}

	public static x89c597989b13898e x5d95f5f98c940295(BinaryReader reader)
	{
		byte[] bytes = reader.ReadBytes(12);
		string @string = Encoding.ASCII.GetString(bytes);
		if (@string != "PS2_SETTINGS")
		{
			throw new IOException("Stream is not an ARMAX settings file!");
		}
		uint num = reader.ReadUInt32();
		uint num2 = reader.ReadUInt32();
		if (num2 != reader.BaseStream.Length)
		{
			throw new IOException($"Internal length is {num2}, but actual stream length is {reader.BaseStream.Length}.");
		}
		x5e4059a15fb5fca5 x5e4059a15fb5fca6 = new x5e4059a15fb5fca5();
		x5e4059a15fb5fca6.x295cb4a1df7a5add(BitConverter.GetBytes(num2));
		x89c597989b13898e x89c597989b13898e2 = new x89c597989b13898e();
		while (reader.BaseStream.Position < num2)
		{
			x89c597989b13898e2.xe685dac5c8fe8444(reader, x5e4059a15fb5fca6);
		}
		if (x5e4059a15fb5fca6.xd2f68ee6f47e9dfb != num)
		{
			throw new IOException("Checksum does not match; settings file is probably corrupted.");
		}
		x89c597989b13898e2.x878a2a620459f85a();
		return x89c597989b13898e2;
	}

	private void xe685dac5c8fe8444(BinaryReader reader, x5e4059a15fb5fca5 xa4660e7fe4e71d99)
	{
		byte[] array = reader.ReadBytes(12);
		string @string = Encoding.ASCII.GetString(array);
		char[] trimChars = new char[1];
		string xba08ce632055a1d = @string.TrimEnd(trimChars);
		int num = reader.ReadInt32();
		byte[] array2 = reader.ReadBytes(num);
		int count = (int)(((reader.BaseStream.Position + 11) & -16) + 4 - reader.BaseStream.Position);
		byte[] x5cafa8d49ea71ea = reader.ReadBytes(count);
		xa4660e7fe4e71d99.x295cb4a1df7a5add(array);
		xa4660e7fe4e71d99.x295cb4a1df7a5add(BitConverter.GetBytes(num));
		xa4660e7fe4e71d99.x295cb4a1df7a5add(array2);
		xa4660e7fe4e71d99.x295cb4a1df7a5add(x5cafa8d49ea71ea);
		if (num >= 4)
		{
			int num2 = BitConverter.ToInt32(array2, 0);
			if (num >= num2)
			{
				Array.Copy(array2, 4, array2, 0, array2.Length - 4);
				Array.Resize(ref array2, array2.Length - 4);
			}
			else
			{
				using MemoryStream xdc4cce4a2fe6be = new MemoryStream(array2);
				using MemoryStream memoryStream = new MemoryStream();
				xcf043bac6e2df84d.xf76803be5e9ee2aa(xdc4cce4a2fe6be, memoryStream);
				memoryStream.Close();
				array2 = memoryStream.ToArray();
			}
		}
		Add(xba08ce632055a1d, array2);
	}

	private void x878a2a620459f85a()
	{
		if (!TryGetValue("USER_LIST", out var xbcea506a33cf))
		{
			return;
		}
		_33636090f73cdcbf = new Codelist();
		using MemoryStream input = new MemoryStream(xbcea506a33cf);
		BinaryReader binaryReader = new BinaryReader(input);
		Codelist.x77fa6322561797a0 = binaryReader.ReadInt32();
		uint num = binaryReader.ReadUInt32();
		uint num2 = binaryReader.ReadUInt32();
		for (int i = 0; i < num; i++)
		{
			Codelist.xd6b6ed77479ef68c(GameEntry.x5d95f5f98c940295(binaryReader));
		}
		if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
		{
			throw new IOException("Inconsistent structural data, or codelist stream has been misread.");
		}
		if (num2 != Codelist.xbeb7785012fbaf09)
		{
			throw new IOException("Number of codes in header does not match number of codes read.");
		}
	}
}
