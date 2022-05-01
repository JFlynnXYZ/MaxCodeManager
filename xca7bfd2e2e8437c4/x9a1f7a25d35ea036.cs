using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Win32;

namespace xca7bfd2e2e8437c4;

internal static class x9a1f7a25d35ea036
{
	public sealed class x4f14b99f5099d83a : IDisposable
	{
		private RegistryKey _6d1ed3a0a357eddc;

		private x1f2816c754531bb9 _080a233dd16d015c;

		private bool _df3d8f13acb97655;

		public bool xdf3d8f13acb97655 => _df3d8f13acb97655;

		public x9e7010a9873522d2 x586b7652ac7cefe0
		{
			get
			{
				x9e7010a9873522d2? x9e7010a9873522d = (x9e7010a9873522d2?)_6d1ed3a0a357eddc.GetValue("EditFlags");
				if (x9e7010a9873522d.HasValue)
				{
					return x9e7010a9873522d.Value;
				}
				return x9e7010a9873522d2.x4d0b9d4447ba7566;
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set flags");
				}
				_6d1ed3a0a357eddc.SetValue("EditFlags", (int)value, RegistryValueKind.Binary);
			}
		}

		public string x3d235fc95c355365
		{
			get
			{
				return (string)_6d1ed3a0a357eddc.GetValue(null);
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set description");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				_6d1ed3a0a357eddc.SetValue(null, value, RegistryValueKind.String);
			}
		}

		public string x84fb75d7f9b8baa9
		{
			get
			{
				using RegistryKey registryKey = _6d1ed3a0a357eddc.OpenSubKey("DefaultIcon");
				if (registryKey == null)
				{
					return null;
				}
				return (string)registryKey.GetValue(null);
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set icon");
				}
				if (value == null)
				{
					_6d1ed3a0a357eddc.DeleteSubKey("DefaultIcon", throwOnMissingSubKey: false);
					return;
				}
				using RegistryKey registryKey = _6d1ed3a0a357eddc.CreateSubKey("DefaultIcon");
				registryKey.SetValue(null, value, RegistryValueKind.String);
			}
		}

		public string xddebe5a8f5476540
		{
			get
			{
				using RegistryKey registryKey = _6d1ed3a0a357eddc.OpenSubKey("shell");
				if (registryKey == null)
				{
					return null;
				}
				return (string)registryKey.GetValue(null);
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set default verb");
				}
				using RegistryKey registryKey = _6d1ed3a0a357eddc.CreateSubKey("shell");
				if (value == null)
				{
					registryKey.DeleteValue("", throwOnMissingValue: false);
				}
				else
				{
					registryKey.SetValue(null, value, RegistryValueKind.String);
				}
			}
		}

		public x1f2816c754531bb9 x080a233dd16d015c => _080a233dd16d015c;

		internal x4f14b99f5099d83a(RegistryKey x6cb3c254615f6c60, bool x5cd59169779524f3)
		{
			_6d1ed3a0a357eddc = x6cb3c254615f6c60;
			_df3d8f13acb97655 = x5cd59169779524f3;
			_080a233dd16d015c = new x1f2816c754531bb9(x6cb3c254615f6c60, x5cd59169779524f3);
		}

		public void Dispose()
		{
			if (_6d1ed3a0a357eddc != null)
			{
				_6d1ed3a0a357eddc.Close();
				_6d1ed3a0a357eddc = null;
				_080a233dd16d015c.x3607c8ea8b9a05f6();
			}
		}
	}

	public sealed class xe264ee45dcea29ee
	{
		private RegistryKey _9da19e5e5f6643a1;

		private bool _df3d8f13acb97655;

		public bool xdf3d8f13acb97655 => _df3d8f13acb97655;

		public string x3d235fc95c355365
		{
			get
			{
				return (string)_9da19e5e5f6643a1.GetValue(null);
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set description");
				}
				if (value == null)
				{
					_9da19e5e5f6643a1.DeleteValue("", throwOnMissingValue: false);
				}
				else
				{
					_9da19e5e5f6643a1.SetValue(null, value, RegistryValueKind.String);
				}
			}
		}

		public string x7a274f60ab25f2b9
		{
			get
			{
				using RegistryKey registryKey = _9da19e5e5f6643a1.OpenSubKey("command");
				if (registryKey == null)
				{
					return null;
				}
				return (string)registryKey.GetValue(null);
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set command");
				}
				if (value == null)
				{
					_9da19e5e5f6643a1.DeleteSubKey("command", throwOnMissingSubKey: false);
					return;
				}
				using RegistryKey registryKey = _9da19e5e5f6643a1.CreateSubKey("command");
				registryKey.SetValue(null, value, RegistryValueKind.String);
			}
		}

		public bool x6e6bdce65918d15d
		{
			get
			{
				return _9da19e5e5f6643a1.GetValue("extended") != null;
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set extended");
				}
				if (value)
				{
					_9da19e5e5f6643a1.SetValue("extended", "", RegistryValueKind.String);
				}
				else
				{
					_9da19e5e5f6643a1.DeleteValue("extended", throwOnMissingValue: false);
				}
			}
		}

		internal xe264ee45dcea29ee(RegistryKey xcaaacea3d4f71ad7, bool x5cd59169779524f3)
		{
			_9da19e5e5f6643a1 = xcaaacea3d4f71ad7;
			_df3d8f13acb97655 = x5cd59169779524f3;
		}

		internal void x3607c8ea8b9a05f6()
		{
			if (_9da19e5e5f6643a1 != null)
			{
				_9da19e5e5f6643a1.Close();
				_9da19e5e5f6643a1 = null;
			}
		}
	}

	public sealed class x3cc749c036e97730 : IDisposable
	{
		private RegistryKey _181635f98076eb3c;

		private bool _df3d8f13acb97655;

		public bool xdf3d8f13acb97655 => _df3d8f13acb97655;

		public string xe5d13ccbc3df998a
		{
			get
			{
				return (string)_181635f98076eb3c.GetValue(null);
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set progid");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				_181635f98076eb3c.SetValue(null, value, RegistryValueKind.String);
			}
		}

		public string x0b93856f95be30d0
		{
			get
			{
				return (string)_181635f98076eb3c.GetValue("PerceivedType");
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set perceived type");
				}
				if (value == null)
				{
					_181635f98076eb3c.DeleteValue("PerceivedType", throwOnMissingValue: false);
				}
				else
				{
					_181635f98076eb3c.SetValue("PerceivedType", value, RegistryValueKind.String);
				}
			}
		}

		public string x11466b77b5936b52
		{
			get
			{
				return (string)_181635f98076eb3c.GetValue("Content Type");
			}
			set
			{
				if (xdf3d8f13acb97655)
				{
					throw new InvalidOperationException("Read only; cannot set content type");
				}
				if (value == null)
				{
					_181635f98076eb3c.DeleteValue("Content Type", throwOnMissingValue: false);
				}
				else
				{
					_181635f98076eb3c.SetValue("Content Type", value, RegistryValueKind.String);
				}
			}
		}

		internal x3cc749c036e97730(RegistryKey xa224e2f3e2221e6f, bool x5cd59169779524f3)
		{
			_181635f98076eb3c = xa224e2f3e2221e6f;
			_df3d8f13acb97655 = x5cd59169779524f3;
		}

		public void Dispose()
		{
			if (_181635f98076eb3c != null)
			{
				_181635f98076eb3c.Close();
				_181635f98076eb3c = null;
			}
		}
	}

	[DefaultMember("Item")]
	public sealed class x1f2816c754531bb9 : IEnumerable<xe264ee45dcea29ee>, IEnumerable
	{
		private RegistryKey _2638e5469f8234dc;

		private bool _df3d8f13acb97655;

		private Dictionary<string, xe264ee45dcea29ee> _080a233dd16d015c = new Dictionary<string, xe264ee45dcea29ee>(StringComparer.InvariantCultureIgnoreCase);

		public bool xdf3d8f13acb97655 => _df3d8f13acb97655;

		public int xd44988f225497f3a => _080a233dd16d015c.Count;

		public xe264ee45dcea29ee xe6d4b1b411ed94b5 => _080a233dd16d015c["open"];

		internal x1f2816c754531bb9(RegistryKey x6cb3c254615f6c60, bool x5cd59169779524f3)
		{
			_df3d8f13acb97655 = x5cd59169779524f3;
			if (x5cd59169779524f3)
			{
				_2638e5469f8234dc = x6cb3c254615f6c60.OpenSubKey("shell");
			}
			else
			{
				_2638e5469f8234dc = x6cb3c254615f6c60.CreateSubKey("shell");
			}
			if (_2638e5469f8234dc != null)
			{
				string[] subKeyNames = _2638e5469f8234dc.GetSubKeyNames();
				foreach (string text in subKeyNames)
				{
					_080a233dd16d015c.Add(text, new xe264ee45dcea29ee(_2638e5469f8234dc.OpenSubKey(text, !x5cd59169779524f3), x5cd59169779524f3));
				}
			}
		}

		internal void x3607c8ea8b9a05f6()
		{
			if (_2638e5469f8234dc == null)
			{
				return;
			}
			_2638e5469f8234dc.Close();
			_2638e5469f8234dc = null;
			foreach (xe264ee45dcea29ee value in _080a233dd16d015c.Values)
			{
				value.x3607c8ea8b9a05f6();
			}
		}

		public bool x263d579af1d0d43f(string verbName)
		{
			return _080a233dd16d015c.ContainsKey(verbName);
		}

		public xe264ee45dcea29ee xd6b6ed77479ef68c(string verbName)
		{
			if (xdf3d8f13acb97655)
			{
				throw new InvalidOperationException("Read only; cannot add verb");
			}
			if (verbName == null)
			{
				throw new ArgumentNullException("verbName");
			}
			if (x263d579af1d0d43f(verbName))
			{
				return this.xe6d4b1b411ed94b5;
			}
			RegistryKey xcaaacea3d4f71ad = _2638e5469f8234dc.CreateSubKey(verbName);
			xe264ee45dcea29ee xe264ee45dcea29ee = new xe264ee45dcea29ee(xcaaacea3d4f71ad, xdf3d8f13acb97655);
			_080a233dd16d015c.Add(verbName, xe264ee45dcea29ee);
			return xe264ee45dcea29ee;
		}

		public IEnumerator<xe264ee45dcea29ee> GetEnumerator()
		{
			return _080a233dd16d015c.Values.GetEnumerator();
		}

		private IEnumerator x05b0b83b5e6c5de6()
		{
			return GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in x05b0b83b5e6c5de6
			return this.x05b0b83b5e6c5de6();
		}
	}

	[Flags]
	public enum x9e7010a9873522d2
	{
		x4d0b9d4447ba7566 = 0,
		x799ceb8bdd5b54ef = 1,
		x35579b297303ed43 = 2,
		xfb244db2ef04cda9 = 4,
		xd71312e27fdc8d6c = 8,
		x6973b6f1ea4bebf8 = 0x10,
		xc327296162ad1699 = 0x20,
		xcd56741d586e2a32 = 0x40,
		xb703e94039549736 = 0x80,
		x8e7169c35b1c784e = 0x100,
		x91b59b298980f7d9 = 0x200,
		xb1ac64ece5630757 = 0x400,
		xf0bdc256ecb89aa5 = 0x800,
		x3fc33344940e4b57 = 0x1000,
		x1caf7edd03d84d35 = 0x2000,
		x5aebeac8b4839337 = 0x8000,
		xb0d1076174024b92 = 0x10000,
		xdcf56bd69987c976 = 0x20000,
		x8e4d865c546b888a = 0x40000,
		xe13e2ed1e3d5c286 = 0x100000
	}

	public static x3cc749c036e97730 x9b18ebf16a053dab(string xca6cce6923124135)
	{
		RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("." + xca6cce6923124135);
		if (registryKey == null)
		{
			return null;
		}
		return new x3cc749c036e97730(registryKey, x5cd59169779524f3: true);
	}

	public static x4f14b99f5099d83a x5692a4a358340536(string x1fd8f5e5bbfdb602)
	{
		RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(x1fd8f5e5bbfdb602);
		if (registryKey == null)
		{
			return null;
		}
		return new x4f14b99f5099d83a(registryKey, x5cd59169779524f3: true);
	}

	public static string xe637e96cc5386930(string xca6cce6923124135)
	{
		x3cc749c036e97730 x3cc749c036e = x9b18ebf16a053dab(xca6cce6923124135);
		if (x3cc749c036e == null)
		{
			return null;
		}
		x4f14b99f5099d83a x4f14b99f5099d83a = x5692a4a358340536(x3cc749c036e.xe5d13ccbc3df998a);
		if (x4f14b99f5099d83a == null)
		{
			return null;
		}
		string text = x4f14b99f5099d83a.xddebe5a8f5476540;
		if (string.IsNullOrEmpty(text))
		{
			text = "open";
		}
		if (!x4f14b99f5099d83a.x080a233dd16d015c.x263d579af1d0d43f(text))
		{
			return null;
		}
		xe264ee45dcea29ee xe264ee45dcea29ee = x4f14b99f5099d83a.x080a233dd16d015c.xe6d4b1b411ed94b5;
		string x7a274f60ab25f2b = xe264ee45dcea29ee.x7a274f60ab25f2b9;
		if (string.IsNullOrEmpty(x7a274f60ab25f2b))
		{
			return null;
		}
		string[] array = x289f1a0ee2f795a7.x3df13c9311a0ba9b(x7a274f60ab25f2b, " ", "\"", x8b05b1454697839b: false);
		return array[0];
	}

	public static x3cc749c036e97730 x9fbde06ead3353c8(string xca6cce6923124135)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Classes\\." + xca6cce6923124135);
		if (registryKey == null)
		{
			return null;
		}
		return new x3cc749c036e97730(registryKey, x5cd59169779524f3: false);
	}

	public static x4f14b99f5099d83a x6f1a5f10b6837ab1(string x1fd8f5e5bbfdb602)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Classes\\" + x1fd8f5e5bbfdb602);
		if (registryKey == null)
		{
			return null;
		}
		return new x4f14b99f5099d83a(registryKey, x5cd59169779524f3: false);
	}

	public static void x792ba40fa40166fc()
	{
		x842e24ef1160275b.SHChangeNotify(x238376a23aa938d4.x5802bd9c5cc04456.xe3a4fb0fa6a336a0, x238376a23aa938d4.xab86832616e9a6ab.xe591fb1f32419985, IntPtr.Zero, IntPtr.Zero);
	}
}
