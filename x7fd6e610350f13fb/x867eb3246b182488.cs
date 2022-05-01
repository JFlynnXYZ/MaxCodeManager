using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using x4c5768933ca951f6;
using xca7bfd2e2e8437c4;

namespace x7fd6e610350f13fb;

internal class x867eb3246b182488 : WindowsFormsApplicationBase
{
	private int xd4d00edca619d0bf;

	public static Version x77fa6322561797a0 => typeof(x867eb3246b182488).Assembly.GetName().Version;

	private xf266856f631ec016 xf266856f631ec016
	{
		get
		{
			return (xf266856f631ec016)base.MainForm;
		}
		set
		{
			base.MainForm = value;
		}
	}

	[STAThread]
	private static int Main(string[] xce8d8c7e3c2c2426)
	{
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		x867eb3246b182488 x867eb3246b182489 = new x867eb3246b182488();
		x867eb3246b182489.Run(xce8d8c7e3c2c2426);
		return x867eb3246b182489.xd4d00edca619d0bf;
	}

	private x867eb3246b182488()
	{
		base.IsSingleInstance = true;
		base.EnableVisualStyles = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	protected override bool OnStartup(StartupEventArgs x4061385acc449db9)
	{
		List<string> filenames = x5f9ec5edf699e547(x4061385acc449db9.CommandLine);
		xf35d6cefb4850f77();
		if (xd4d00edca619d0bf == 0)
		{
			xf266856f631ec016 = new xf266856f631ec016();
			xf266856f631ec016.xe60cad9a2d565735 += delegate
			{
				xf266856f631ec016.xc0517110e193d382(filenames);
			};
			return base.OnStartup(x4061385acc449db9);
		}
		return false;
	}

	protected override void OnStartupNextInstance(StartupNextInstanceEventArgs x4061385acc449db9)
	{
		base.OnStartupNextInstance(x4061385acc449db9);
		List<string> x499b08a184e = x5f9ec5edf699e547(x4061385acc449db9.CommandLine);
		if (xd4d00edca619d0bf == 0)
		{
			xf266856f631ec016.xc0517110e193d382(x499b08a184e);
		}
		xd4d00edca619d0bf = 0;
	}

	public List<string> x5f9ec5edf699e547(IEnumerable<string> xce8d8c7e3c2c2426)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (string item in xce8d8c7e3c2c2426)
		{
			if (item.Length != 0)
			{
				if (item[0] == '/' || item[0] == '-')
				{
					list2.Add(item.Substring(1));
				}
				else
				{
					list.Add(item);
				}
			}
		}
		x77dccad1db69a78f.x5abe663d857813df();
		xc6c86a68264c0f03(list2);
		return list;
	}

	private void xc6c86a68264c0f03(List<string> xdfde339da46db651)
	{
		foreach (string item in xdfde339da46db651)
		{
			switch (item.ToLower(CultureInfo.CurrentCulture))
			{
			case "check":
				xf266856f631ec016.xb75fb88443b77f48 = xb428466f1afbae0c.x2ff77f3339c1efa1;
				break;
			case "nocheck":
				xf266856f631ec016.xb75fb88443b77f48 = xb428466f1afbae0c.xe6ff04aae88f6258;
				break;
			case "assoc":
				xf266856f631ec016.x6c212c9a8eebe445 = xb428466f1afbae0c.x2ff77f3339c1efa1;
				break;
			case "?":
			case "help":
				MessageBox.Show("MAX Codelist Manager currently supports the following options:\r\n\r\n  /check\t\tChecks for updated codelists on startup (even if set to not do so)\r\n  /nocheck\tAvoids checking for updated codelists on startup (even if set to)\r\n  /assoc\t\tChecks the file associations (even if set to not do so)\r\n\r\nIn addition, any number of codelist filenames can be specified.  MCM will attempt to add these to its list of custom codelists.", "Command Line Options", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				xd4d00edca619d0bf = 1;
				break;
			}
		}
	}

	private static void xf35d6cefb4850f77()
	{
		if (x77dccad1db69a78f.xdea6ad67b4a74598 == x77dccad1db69a78f.x71a20e267d3fe6fc.x4256ce6b881831eb)
		{
			return;
		}
		foreach (x77dccad1db69a78f.x4dd9c2bed5963f2a value in Enum.GetValues(typeof(x77dccad1db69a78f.x4dd9c2bed5963f2a)))
		{
			x9c67d7f802cd565a.xa0b5d41efa94698d(x77dccad1db69a78f.x38758cbbee49e4cb(x77dccad1db69a78f.x71a20e267d3fe6fc.x4256ce6b881831eb, value), x77dccad1db69a78f.x38758cbbee49e4cb(x77dccad1db69a78f.x71a20e267d3fe6fc.x0b5d2fa4b8fa2e0c, value));
		}
	}
}
