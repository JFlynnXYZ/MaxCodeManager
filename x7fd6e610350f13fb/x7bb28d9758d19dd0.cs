using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Mirality.Max.MaxCodes;
using x2ac61696da69bb5f;
using x3a260771fe762331;
using xca7bfd2e2e8437c4;

namespace x7fd6e610350f13fb;

internal class x7bb28d9758d19dd0
{
	private static readonly string xc47612914d7178b2;

	private static bool _3452082a8fecf97d;

	private static bool _3b67f7a0ce62b49b;

	private static FileVersionInfo _77fa6322561797a0;

	private static AssemblyName _54eeb852ed5036a2;

	private static TimeSpan _321c8219d9ae23e6;

	private static readonly xf6e5c5e1901f893f[] _8d4ca4824671bb70;

	private static readonly x047611ec9892e059[] _47a596f517a06afc;

	public static bool x3452082a8fecf97d => _3452082a8fecf97d;

	public static bool x3b67f7a0ce62b49b => _3b67f7a0ce62b49b;

	public static FileVersionInfo x77fa6322561797a0 => _77fa6322561797a0;

	public static AssemblyName x54eeb852ed5036a2 => _54eeb852ed5036a2;

	private x7bb28d9758d19dd0()
	{
	}

	static x7bb28d9758d19dd0()
	{
		xc47612914d7178b2 = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "MaxCryptor.exe");
		_321c8219d9ae23e6 = TimeSpan.Zero;
		_8d4ca4824671bb70 = new xf6e5c5e1901f893f[5];
		_8d4ca4824671bb70[0] = new xf6e5c5e1901f893f("RK6H-QTBZ-Z1AQJ", "Z20Q-9YPG-TE8A7");
		_8d4ca4824671bb70[1] = new xf6e5c5e1901f893f("8G45-8TTM-37RZY");
		_8d4ca4824671bb70[2] = new xf6e5c5e1901f893f("6RMD-FFD2-FB6PG", "XM6T-KNFE-7M9F7");
		_8d4ca4824671bb70[3] = new xf6e5c5e1901f893f("J5B0-M53F-ETN1U", "JB9E-91K0-74840");
		_8d4ca4824671bb70[4] = new xf6e5c5e1901f893f("UW3J-QFME-DANPF", "3KG4-2MQN-X1YYV", "VFE7-FK9B-M32EA", "KQEK-5ZFB-F8UP9");
		_47a596f517a06afc = new x047611ec9892e059[5];
		_47a596f517a06afc[0] = new x047611ec9892e059(1365u, 84520u, RegionCode.PAL);
		_47a596f517a06afc[0].xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(15, 42u));
		_47a596f517a06afc[1] = new x047611ec9892e059(1365u, 84520u, RegionCode.PAL);
		_47a596f517a06afc[1].xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(5, 0u));
		_47a596f517a06afc[2] = new x047611ec9892e059(1365u, 84521u, RegionCode.PAL);
		_47a596f517a06afc[2].xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(4, 84520u));
		_47a596f517a06afc[2].xea84056d876cd25a.Add(new x047611ec9892e059.x7a274f60ab25f2b9(3600416u, 14691u));
		_47a596f517a06afc[3] = new x047611ec9892e059(1365u, 81237u, RegionCode.PAL);
		_47a596f517a06afc[3].xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(4, 81223u));
		_47a596f517a06afc[3].xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(5, 0u));
		_47a596f517a06afc[4] = new x047611ec9892e059(1236u, 72183u, RegionCode.PAL);
		_47a596f517a06afc[4].xda8f238d1a051872 = true;
		_47a596f517a06afc[4].xea84056d876cd25a.Add(new x047611ec9892e059.x7a274f60ab25f2b9(3295554508u, 2048u));
		_47a596f517a06afc[4].xea84056d876cd25a.Add(new x047611ec9892e059.x7a274f60ab25f2b9(202309780u, 1u));
		_47a596f517a06afc[4].xea84056d876cd25a.Add(new x047611ec9892e059.x7a274f60ab25f2b9(3288334336u, 67585u));
	}

	public static bool? x7c3f02898beff87a()
	{
		_3452082a8fecf97d = false;
		_3b67f7a0ce62b49b = false;
		if (File.Exists(xc47612914d7178b2))
		{
			_77fa6322561797a0 = FileVersionInfo.GetVersionInfo(xc47612914d7178b2);
			try
			{
				_54eeb852ed5036a2 = AssemblyName.GetAssemblyName(xc47612914d7178b2);
			}
			catch
			{
				_54eeb852ed5036a2 = null;
			}
			_3452082a8fecf97d = x4760cd10f5b01fbf();
			if (x3452082a8fecf97d)
			{
				_3b67f7a0ce62b49b = xbf8f07e6cbdbd014();
				return true;
			}
			return false;
		}
		_77fa6322561797a0 = null;
		_54eeb852ed5036a2 = null;
		return null;
	}

	private static bool x4760cd10f5b01fbf()
	{
		List<xbabc9feec6f641db> list = new List<xbabc9feec6f641db>();
		for (int i = 0; i < _8d4ca4824671bb70.Length; i++)
		{
			list.Add(new xbabc9feec6f641db());
			list[i].xb3efee94cf138f44 = (uint)i;
			list[i].Name = (i + 1).ToString(CultureInfo.CurrentCulture);
			list[i].x7e5b09fa2269d9a5 = _8d4ca4824671bb70[i];
		}
		_3452082a8fecf97d = true;
		try
		{
			_321c8219d9ae23e6 = TimeSpan.FromSeconds(10.0);
			List<string> list2 = x2731b90dfbad5cbc(list);
			if (list2.Count == 0)
			{
				return false;
			}
		}
		catch
		{
			return false;
		}
		finally
		{
			_321c8219d9ae23e6 = TimeSpan.Zero;
		}
		if (list[0].xbe23edc82b0342c0 != null)
		{
			return false;
		}
		for (int j = 1; j < _8d4ca4824671bb70.Length; j++)
		{
			if (list[j].xbe23edc82b0342c0 == null)
			{
				return false;
			}
			if (list[j].xbe23edc82b0342c0.xda8f238d1a051872 != _47a596f517a06afc[j].xda8f238d1a051872 || list[j].xbe23edc82b0342c0.xd0431a295f2ed35f != _47a596f517a06afc[j].xd0431a295f2ed35f || list[j].xbe23edc82b0342c0.x52b8174788d367f9 != _47a596f517a06afc[j].x52b8174788d367f9 || list[j].xbe23edc82b0342c0.xb3efee94cf138f44 != _47a596f517a06afc[j].xb3efee94cf138f44 || list[j].xbe23edc82b0342c0.x4b94e58155458175 != _47a596f517a06afc[j].x4b94e58155458175 || list[j].xbe23edc82b0342c0.xa54a49b4cb11c6d1.Count != _47a596f517a06afc[j].xa54a49b4cb11c6d1.Count || list[j].xbe23edc82b0342c0.xea84056d876cd25a.Count != _47a596f517a06afc[j].xea84056d876cd25a.Count)
			{
				return false;
			}
			for (int k = 0; k < list[j].xbe23edc82b0342c0.xa54a49b4cb11c6d1.Count; k++)
			{
				if (list[j].xbe23edc82b0342c0.xa54a49b4cb11c6d1[k].x3146d638ec378671 != _47a596f517a06afc[j].xa54a49b4cb11c6d1[k].x3146d638ec378671 || list[j].xbe23edc82b0342c0.xa54a49b4cb11c6d1[k].x6b73aa01aa019d3a != _47a596f517a06afc[j].xa54a49b4cb11c6d1[k].x6b73aa01aa019d3a)
				{
					return false;
				}
			}
			for (int l = 0; l < list[j].xbe23edc82b0342c0.xea84056d876cd25a.Count; l++)
			{
				if (list[j].xbe23edc82b0342c0.xea84056d876cd25a[l].x1d5cfa3bffdfb042 != _47a596f517a06afc[j].xea84056d876cd25a[l].x1d5cfa3bffdfb042 || list[j].xbe23edc82b0342c0.xea84056d876cd25a[l].xd2f68ee6f47e9dfb != _47a596f517a06afc[j].xea84056d876cd25a[l].xd2f68ee6f47e9dfb)
				{
					return false;
				}
			}
		}
		return true;
	}

	private static bool xbf8f07e6cbdbd014()
	{
		List<xbabc9feec6f641db> list = new List<xbabc9feec6f641db>();
		for (int i = 0; i < _47a596f517a06afc.Length; i++)
		{
			list.Add(new xbabc9feec6f641db());
			list[i].xb3efee94cf138f44 = (uint)i;
			list[i].Name = (i + 1).ToString(CultureInfo.CurrentCulture);
			list[i].xbe23edc82b0342c0 = _47a596f517a06afc[i];
		}
		_3b67f7a0ce62b49b = true;
		try
		{
			_321c8219d9ae23e6 = TimeSpan.FromSeconds(10.0);
			List<string> list2 = x6b6fd0a44693bc2e(list);
			if (list2.Count == 0)
			{
				return false;
			}
		}
		catch
		{
			return false;
		}
		finally
		{
			_321c8219d9ae23e6 = TimeSpan.Zero;
		}
		if (list[0].x7e5b09fa2269d9a5 == null || list[0].x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length != 0)
		{
			return false;
		}
		for (int j = 1; j < _47a596f517a06afc.Length; j++)
		{
			if (list[j].x7e5b09fa2269d9a5 == null)
			{
				return false;
			}
			if (list[j].x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length != _8d4ca4824671bb70[j].x6b73aa01aa019d3a.Length)
			{
				return false;
			}
			for (int k = 0; k < list[j].x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length; k++)
			{
				if (list[j].x7e5b09fa2269d9a5.x6b73aa01aa019d3a[k] != _8d4ca4824671bb70[j].x6b73aa01aa019d3a[k])
				{
					return false;
				}
			}
		}
		return true;
	}

	public static List<string> x2731b90dfbad5cbc(List<xbabc9feec6f641db> xcdff170dbac909bf)
	{
		if (!x3452082a8fecf97d)
		{
			throw new InvalidOperationException("No decryption engine");
		}
		List<string> list = new List<string>();
		string tempFileName = Path.GetTempFileName();
		string tempFileName2 = Path.GetTempFileName();
		try
		{
			using (StreamWriter xbdfb620b7167944b = new StreamWriter(tempFileName, append: false, Encoding.UTF8))
			{
				using x2193eba2bfddddf7 x2193eba2bfddddf = new x2193eba2bfddddf7(xbdfb620b7167944b, x4658008e2185b037: false);
				if (x3b67f7a0ce62b49b)
				{
					List<xbabc9feec6f641db> list2 = new List<xbabc9feec6f641db>();
					foreach (xbabc9feec6f641db item in xcdff170dbac909bf)
					{
						if (item.x7e5b09fa2269d9a5.x6b73aa01aa019d3a.Length == 0)
						{
							list2.Add(item);
						}
					}
					if (list2.Count > 0)
					{
						List<xbabc9feec6f641db> list3 = new List<xbabc9feec6f641db>();
						foreach (xbabc9feec6f641db item2 in list2)
						{
							if (item2.xa0380078f0b6cbb7 == null)
							{
								list3.Add(item2);
								continue;
							}
							item2.xbe23edc82b0342c0 = new x047611ec9892e059(item2.xa0380078f0b6cbb7.x52b8174788d367f9, item2.xb3efee94cf138f44, item2.xb1d0737e4174a713);
							list.Add("Code " + item2.xb3efee94cf138f44 + " \"" + item2.Name + "\": no code lines (auto repairing)");
						}
						foreach (xbabc9feec6f641db item3 in list3)
						{
							list2.Remove(item3);
						}
						List<string> list4 = x6b6fd0a44693bc2e(list2);
						if (list4.Count > 0)
						{
							list.Add("");
							list.Add("Auto-repair errors:");
							list.AddRange(list4);
							list.Add("");
						}
					}
				}
				int num = 0;
				foreach (xbabc9feec6f641db item4 in xcdff170dbac909bf)
				{
					x2193eba2bfddddf.xc4305ca6c268b073(num.ToString(CultureInfo.InvariantCulture), item4.x7e5b09fa2269d9a5);
					num++;
				}
			}
			if (!xedb1d036cd19179d(string.Format(CultureInfo.InvariantCulture, "/Decrypt \"{0}\" \"{1}\"", tempFileName, tempFileName2), list))
			{
				list.Insert(0, "Decryption utility reported failure.");
				list.Add("");
			}
			try
			{
				using StreamReader xe134235b3526fa = new StreamReader(tempFileName2);
				using x51b2a3ee6460788d x51b2a3ee6460788d = new x51b2a3ee6460788d(xe134235b3526fa);
				for (xff029f749c7f2d1b xff029f749c7f2d1b = x51b2a3ee6460788d.x45a68e2bd45abecf(); xff029f749c7f2d1b != null; xff029f749c7f2d1b = x51b2a3ee6460788d.x45a68e2bd45abecf())
				{
					try
					{
						int index = int.Parse(xff029f749c7f2d1b.xea1e81378298fa81, CultureInfo.InvariantCulture);
						xbabc9feec6f641db xbabc9feec6f641db = xcdff170dbac909bf[index];
						if (xff029f749c7f2d1b.xb0b4ff1622a01d12 != null)
						{
							xbabc9feec6f641db.xbe23edc82b0342c0 = xff029f749c7f2d1b.xb0b4ff1622a01d12;
						}
						if (xff029f749c7f2d1b.xdc1af3a17717bf0a != null)
						{
							list.Add("Code " + xbabc9feec6f641db.xb3efee94cf138f44 + " \"" + xbabc9feec6f641db.Name + "\": " + xff029f749c7f2d1b.xdc1af3a17717bf0a);
						}
					}
					catch (Exception ex)
					{
						list.Add(ex.Message);
					}
				}
			}
			catch (Exception ex2)
			{
				list.Add(ex2.Message);
			}
			return list;
		}
		finally
		{
			File.Delete(tempFileName2);
			File.Delete(tempFileName);
		}
	}

	public static List<string> x6b6fd0a44693bc2e(List<xbabc9feec6f641db> xcdff170dbac909bf)
	{
		if (!x3452082a8fecf97d)
		{
			throw new InvalidOperationException("No encryption engine");
		}
		if (!x3b67f7a0ce62b49b)
		{
			throw new InvalidOperationException("Engine cannot encrypt");
		}
		string tempFileName = Path.GetTempFileName();
		string tempFileName2 = Path.GetTempFileName();
		try
		{
			using (StreamWriter xbdfb620b7167944b = new StreamWriter(tempFileName, append: false, Encoding.UTF8))
			{
				using xed601ddc3e643870 xed601ddc3e = new xed601ddc3e643870(xbdfb620b7167944b, x4658008e2185b037: false);
				int num = 0;
				foreach (xbabc9feec6f641db item in xcdff170dbac909bf)
				{
					xed601ddc3e.xc4305ca6c268b073(num.ToString(CultureInfo.InvariantCulture), item.xbe23edc82b0342c0);
					num++;
				}
			}
			List<string> list = new List<string>();
			if (!xedb1d036cd19179d(string.Format(CultureInfo.InvariantCulture, "/Encrypt \"{0}\" \"{1}\"", tempFileName, tempFileName2), list))
			{
				list.Insert(0, "Encryption utility reported failure.");
				list.Add("");
			}
			try
			{
				using StreamReader xe134235b3526fa = new StreamReader(tempFileName2);
				using xd10cf34fd89fb332 xd10cf34fd89fb = new xd10cf34fd89fb332(xe134235b3526fa);
				for (x41b0bc8b458547c2 x41b0bc8b458547c = xd10cf34fd89fb.x45a68e2bd45abecf(); x41b0bc8b458547c != null; x41b0bc8b458547c = xd10cf34fd89fb.x45a68e2bd45abecf())
				{
					try
					{
						int index = int.Parse(x41b0bc8b458547c.xea1e81378298fa81, CultureInfo.InvariantCulture);
						xbabc9feec6f641db xbabc9feec6f641db = xcdff170dbac909bf[index];
						if (x41b0bc8b458547c.xb0b4ff1622a01d12 != null)
						{
							xbabc9feec6f641db.x7e5b09fa2269d9a5 = x41b0bc8b458547c.xb0b4ff1622a01d12;
						}
						if (x41b0bc8b458547c.xdc1af3a17717bf0a != null)
						{
							list.Add("Code " + xbabc9feec6f641db.xb3efee94cf138f44 + " \"" + xbabc9feec6f641db.Name + "\": " + x41b0bc8b458547c.xdc1af3a17717bf0a);
						}
					}
					catch (Exception ex)
					{
						list.Add(ex.Message);
					}
				}
			}
			catch (Exception ex2)
			{
				list.Add(ex2.Message);
			}
			return list;
		}
		finally
		{
			File.Delete(tempFileName2);
			File.Delete(tempFileName);
		}
	}

	private static bool xedb1d036cd19179d(string x370586d4d8ea21a8, List<string> xc32481e37a3cd1f2)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(xc47612914d7178b2, x370586d4d8ea21a8);
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardError = true;
		Process process = Process.Start(processStartInfo);
		if (process == null)
		{
			throw new IOException("Unable to start process.");
		}
		try
		{
			using (MainWindow.xebcf83b00134300b(null, "Analysing game codes..."))
			{
				process.ErrorDataReceived += delegate(object xe0292b9ed559da7d, DataReceivedEventArgs xfbf34718e704c6bc)
				{
					if (!string.IsNullOrEmpty(xfbf34718e704c6bc.Data))
					{
						xc32481e37a3cd1f2.Add(xfbf34718e704c6bc.Data);
					}
				};
				process.BeginErrorReadLine();
				if (_321c8219d9ae23e6 > TimeSpan.Zero)
				{
					if (!process.WaitForExit((int)_321c8219d9ae23e6.TotalMilliseconds))
					{
						xc32481e37a3cd1f2.Add("Timed out waiting for response from crypt engine.");
						process.Kill();
						return false;
					}
				}
				else
				{
					process.WaitForExit();
				}
				process.CancelErrorRead();
				if (process.ExitCode == 0)
				{
					return true;
				}
				return false;
			}
		}
		finally
		{
			process.Close();
		}
	}
}
