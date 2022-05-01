using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace x7fd6e610350f13fb;

public static class x77dccad1db69a78f
{
	public enum x71a20e267d3fe6fc
	{
		x0b5d2fa4b8fa2e0c,
		x4256ce6b881831eb
	}

	public enum x4dd9c2bed5963f2a
	{
		x022e8703da0b9737,
		x93bd97d3afddf842,
		x411b38a624544322,
		xa75c14bfc9532718,
		xbf331fe297ee1425
	}

	private static Dictionary<x71a20e267d3fe6fc, Dictionary<x4dd9c2bed5963f2a, string>> _77dccad1db69a78f;

	private static x71a20e267d3fe6fc _dea6ad67b4a74598;

	public static string x022e8703da0b9737 => x38758cbbee49e4cb(x4dd9c2bed5963f2a.x022e8703da0b9737);

	public static string x93bd97d3afddf842 => x38758cbbee49e4cb(x4dd9c2bed5963f2a.x93bd97d3afddf842);

	public static string x411b38a624544322 => x38758cbbee49e4cb(x4dd9c2bed5963f2a.x411b38a624544322);

	public static string xa75c14bfc9532718 => x38758cbbee49e4cb(x4dd9c2bed5963f2a.xa75c14bfc9532718);

	public static string xbf331fe297ee1425 => x38758cbbee49e4cb(x4dd9c2bed5963f2a.xbf331fe297ee1425);

	public static x71a20e267d3fe6fc xdea6ad67b4a74598
	{
		get
		{
			return _dea6ad67b4a74598;
		}
		set
		{
			_dea6ad67b4a74598 = value;
		}
	}

	static x77dccad1db69a78f()
	{
		_77dccad1db69a78f = new Dictionary<x71a20e267d3fe6fc, Dictionary<x4dd9c2bed5963f2a, string>>();
		_dea6ad67b4a74598 = x71a20e267d3fe6fc.x0b5d2fa4b8fa2e0c;
		string x7fa82d8fa6f94a1b = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mirality Systems\\MaxCodeManager");
		string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
		_77dccad1db69a78f[x71a20e267d3fe6fc.x4256ce6b881831eb] = new Dictionary<x4dd9c2bed5963f2a, string>();
		_77dccad1db69a78f[x71a20e267d3fe6fc.x0b5d2fa4b8fa2e0c] = new Dictionary<x4dd9c2bed5963f2a, string>();
		x90fda48194fc6b9a(x4dd9c2bed5963f2a.x022e8703da0b9737, x7fa82d8fa6f94a1b, directoryName, "settings.xml");
		x90fda48194fc6b9a(x4dd9c2bed5963f2a.x93bd97d3afddf842, x7fa82d8fa6f94a1b, directoryName, "original-pal.dat");
		x90fda48194fc6b9a(x4dd9c2bed5963f2a.x411b38a624544322, x7fa82d8fa6f94a1b, directoryName, "original-ntsc.dat");
		x90fda48194fc6b9a(x4dd9c2bed5963f2a.xa75c14bfc9532718, x7fa82d8fa6f94a1b, directoryName, "previous-pal.dat");
		x90fda48194fc6b9a(x4dd9c2bed5963f2a.xbf331fe297ee1425, x7fa82d8fa6f94a1b, directoryName, "previous-ntsc.dat");
	}

	public static string x38758cbbee49e4cb(x71a20e267d3fe6fc xf241533d88e3213f, x4dd9c2bed5963f2a x43163d22e8cd5a71)
	{
		return _77dccad1db69a78f[xf241533d88e3213f][x43163d22e8cd5a71];
	}

	public static string x38758cbbee49e4cb(x4dd9c2bed5963f2a x43163d22e8cd5a71)
	{
		return x38758cbbee49e4cb(xdea6ad67b4a74598, x43163d22e8cd5a71);
	}

	private static void x90fda48194fc6b9a(x71a20e267d3fe6fc xf241533d88e3213f, x4dd9c2bed5963f2a x43163d22e8cd5a71, string x1b6b7dc5c7649011, string xe125219852864557)
	{
		_77dccad1db69a78f[xf241533d88e3213f][x43163d22e8cd5a71] = Path.Combine(x1b6b7dc5c7649011, xe125219852864557);
	}

	private static void x90fda48194fc6b9a(x4dd9c2bed5963f2a x43163d22e8cd5a71, string x7fa82d8fa6f94a1b, string xa242d8176a133508, string xe125219852864557)
	{
		x90fda48194fc6b9a(x71a20e267d3fe6fc.x0b5d2fa4b8fa2e0c, x43163d22e8cd5a71, x7fa82d8fa6f94a1b, xe125219852864557);
		x90fda48194fc6b9a(x71a20e267d3fe6fc.x4256ce6b881831eb, x43163d22e8cd5a71, xa242d8176a133508, xe125219852864557);
	}

	public static void x5abe663d857813df()
	{
		string path = Path.ChangeExtension(Application.ExecutablePath, "portable");
		if (File.Exists(path))
		{
			xdea6ad67b4a74598 = x71a20e267d3fe6fc.x4256ce6b881831eb;
		}
		else
		{
			xdea6ad67b4a74598 = x71a20e267d3fe6fc.x0b5d2fa4b8fa2e0c;
		}
	}
}
