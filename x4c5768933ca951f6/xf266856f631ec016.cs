using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Mirality.Max.CodeManager;
using Mirality.Max.MaxCodes;
using x3a260771fe762331;
using x7fd6e610350f13fb;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class xf266856f631ec016 : Form
{
	public enum xc690ec495a7b270c
	{
		x4d0b9d4447ba7566,
		xf9ad6fb78355fe13,
		x34639b140e83dce7,
		x4bc88de02db3a00d,
		x48fa56367e187548
	}

	public xb428466f1afbae0c xb75fb88443b77f48;

	public xb428466f1afbae0c x6c212c9a8eebe445;

	private x131eae80bdcb392e x341b5be0450509fe = x131eae80bdcb392e.x45260ad4b94166f2;

	private x131eae80bdcb392e xd8c2f6d1ce092fe8 = x131eae80bdcb392e.x45260ad4b94166f2;

	private x131eae80bdcb392e x7d682c974eb9bc38 = x131eae80bdcb392e.x45260ad4b94166f2;

	private Codelist x40d7509752490077;

	private Codelist x768b6665179efa05;

	private Codelist CodeListData;

	private Codelist x0bc07355221f6454;

	private CodelistFile x50892314664b644e;

	private bool x990ce41f6429c278;

	private ListViewItem xcd3f268901925ceb;

	private IContainer xb7dfc13308b54974;

	private TableLayoutPanel x645415d3d104f12c;

	private TableLayoutPanel x6faa1d7ea341a63b;

	private GroupBox xf1e74be3b0861edd;

	private Label x9c2b9f5916527061;

	private Label xb2f3dc67f47be862;

	private Label xec01cc607223b2a5;

	private Button xa7513da32d6c65f9;

	private GroupBox x84d02b28dabdd2b4;

	private Button AddCodeListBtn;

	private Button RemoveCodeListBtn;

	private Label x33a6dcc90c5f6721;

	private Panel x1c4e58c064fe01db;

	private Button SettingsBtn;

	private xef58b78651bbbe4e xdb68d5db35f39c3b;

	private Label x2377a0ecadab130a;

	private Button xb7a48894a0af41a5;

	private Button NewCodeListBtn;

	private Button MakeActiveBtn;

	private ColumnHeader x5a428ce3753ad1d1;

	private ColumnHeader x4f9e88a7f60520ba;

	private Button x0b02574824d92cc7;

	private Label x31b6f3a354074bae;

	private x97cc998483ae0218 xad90bf79a283dea6;

	private x97cc998483ae0218 x985c922c6fd8031c;

	private x97cc998483ae0218 x3cabd9709ac6c0f8;

	private OpenFileDialog x1d8fb7d81af42349;

	private SaveFileDialog xc21543d0206190f3;

	private Button ViewCodeListBtn;

	private Button CompareCodeListsBtn;

	private LinkLabel MiralityLinkLabel;

	private LinkLabel CodeJunkiesLinkLabel;

	private Button MoveUpBtn;

	private Button MoveDownBtn;

	private ToolTip xc4c34e75b01b4519;

	private Label x9be4e52c9a35b583;

	private ImageList x7bcd86e0772d838f;

	private SaveFileDialog x2005f29ea96528c1;

	private GroupBox xd514546ab3c9516d;

	private Label x7702318dbc4bbe4b;

	private Label x7468a31bcc5ded5a;

	private x3ccd15e4a951572e x75cfc97b61818036;

	private Button ExportActiveBtn;

	private Button ViewActiveBtn;

	private Panel x7662eb616ef3d51d;

	private GroupBox x7c1870c66bed243f;

	private ListView xda8bb6fd239370b7;

	private ColumnHeader x5f68d5b5d2980b57;

	private ColumnHeader CodesColumnHeader;

	private Button ViewCombinedBtn;

	private Button ExportFavsBtn;

	private x3ccd15e4a951572e xd710ac080d58c58d;

	private ColumnHeader RegionColumnHeader;

	private GroupBox xb13e3492976e6435;

	private x3ccd15e4a951572e x0f289e063dca8ffa;

	private x3ccd15e4a951572e xa06a52b1869d241d;

	private Timer xb2f83dca3a2248d7;

	private Timer x0626bb430c72c389;

	public event EventHandler xe60cad9a2d565735;

	public xf266856f631ec016()
	{
		x85601834555fb7d5();
		MiralityLinkLabel.Links[0].LinkData = "http://www.mirality.co.nz/";
		CodeJunkiesLinkLabel.Links[0].LinkData = "http://www.codejunkies.com/";
		CodeJunkiesLinkLabel.Links[0].Start = CodeJunkiesLinkLabel.Text.IndexOf("CodeJunkies");
		CodeJunkiesLinkLabel.Links[0].Length = "CodeJunkies".Length;
	}

	public void xc0517110e193d382(IEnumerable<string> x499b08a184e62535)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (string item in x499b08a184e62535)
		{
			try
			{
				string fullPath = Path.GetFullPath(item);
				if (File.Exists(fullPath))
				{
					if (CodeManagerSettings.Instance.Codelists.Contains(fullPath))
					{
						list.Add(fullPath + ": already loaded");
					}
					else
					{
						list2.Add(fullPath);
					}
				}
				else
				{
					list.Add(fullPath + ": does not exist");
				}
			}
			catch (Exception ex)
			{
				list.Add(item + ": " + ex.Message);
			}
		}
		if (list2.Count > 0 && MessageBox.Show("Would you like to add the following files to your codelists?\r\n\r\n   " + string.Join("\r\n   ", list2.ToArray()), "Add Codelists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			xdb68d5db35f39c3b.BeginUpdate();
			try
			{
				xdb68d5db35f39c3b.SelectedItems.Clear();
				foreach (string item2 in list2)
				{
					if (!CodeManagerSettings.Instance.Codelists.Contains(item2))
					{
						string text = xd8871c5f4b559650(item2);
						if (text != null)
						{
							list.Add(item2 + ": " + text);
						}
					}
				}
			}
			finally
			{
				xdb68d5db35f39c3b.EndUpdate();
			}
		}
		if (list.Count > 0)
		{
			MessageBox.Show("The following files could not be added to your codelists:\r\n\r\n   " + string.Join("\r\n   ", list.ToArray()), "Add Codelists", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	protected virtual void OnLoaded(EventArgs xfbf34718e704c6bc)
	{
		if (this.xe60cad9a2d565735 != null)
		{
			this.xe60cad9a2d565735(this, xfbf34718e704c6bc);
		}
	}

	private void xd9e6c62b87227770(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
	}

	protected override void OnLoad(EventArgs xfbf34718e704c6bc)
	{
		base.UseWaitCursor = true;
		try
		{
			x31b6f3a354074bae.Text = x867eb3246b182488.x77fa6322561797a0.ToString(2);
			x267b27bc4addcd6d(this, EventArgs.Empty);
			x1aaf83a875993cfd(this, EventArgs.Empty);
			xb59232ba9bfe3e83();
			xca640ee3fb73956c();
			x8c06f59cda51f321();
			x81940daabd5d42a2();
			xc7ed830360cab883();
			xece840ab67ddb8e0();
			x0a87b5fb6258b9b3();
			x7d682c974eb9bc38 = xd8c2f6d1ce092fe8;
			x788ad6b71a6e521f();
			x89f94fbb2f9f5452();
		}
		finally
		{
			base.UseWaitCursor = false;
		}
		base.OnLoad(xfbf34718e704c6bc);
	}

	protected override void OnShown(EventArgs xfbf34718e704c6bc)
	{
		base.OnShown(xfbf34718e704c6bc);
		OnLoaded(EventArgs.Empty);
		if (x8d368e4d547c1f32(x6c212c9a8eebe445, CodeManagerSettings.Instance.CheckAssociations))
		{
			x6d9ca4e37730b3ad();
		}
		if (x8d368e4d547c1f32(xb75fb88443b77f48, CodeManagerSettings.Instance.CheckServerOnStartup))
		{
			x3787ad1bc8cbbc9d(xa85f9af1c5f740b5: true);
		}
	}

	protected override void OnClosing(CancelEventArgs xfbf34718e704c6bc)
	{
		base.OnClosing(xfbf34718e704c6bc);
		if (!xfbf34718e704c6bc.Cancel)
		{
			if (!x0cb22ffedfb043d7() && MessageBox.Show(this, "Errors occurred while saving the codelists.  Do you still want to exit?", "Exit anyway?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				xfbf34718e704c6bc.Cancel = true;
			}
			else
			{
				xa0390700e6b1b0d4();
			}
		}
	}

	private static bool x8d368e4d547c1f32(xb428466f1afbae0c x884efbc7d6619c80, bool xf471f9a61fce5e7d)
	{
		return x884efbc7d6619c80 switch
		{
			xb428466f1afbae0c.x2ff77f3339c1efa1 => true, 
			xb428466f1afbae0c.xe6ff04aae88f6258 => false, 
			_ => xf471f9a61fce5e7d, 
		};
	}

	private static void xca640ee3fb73956c()
	{
		using (MainWindow.CreateMessageBox(null, "Verifying correctness of crypt engine..."))
		{
			if (x7bb28d9758d19dd0.x7c3f02898beff87a() == false)
			{
				MessageBox.Show(null, "While a crypt engine appears to be present, it did not pass the basic sanity test.\r\n\r\nThis means that it probably has some kind of bug.  Use of this engine has been temporarily disabled.", "Engine Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void xb59232ba9bfe3e83()
	{
		try
		{
			CodeManagerSettings.Load();
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "The settings file could not be read -- which means that the file has been corrupted somehow, or we've made an incompatible change to the file format.  The default settings will be used instead.\r\n\r\nNote that if you had any stored favourite games and codelists before, they will have been forgotten.\r\n\r\n" + ex.Message, "Cannot load settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void xa0390700e6b1b0d4()
	{
		try
		{
			CodeManagerSettings.Save();
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "The settings file could not be saved -- which means that any changes you have made in this session will be lost.\r\n\r\n" + ex.Message, "Cannot save settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void x6af1203b6caa7239(ref x131eae80bdcb392e x7d45a69b707b1582, RegionCode xa4d52e34b62b5495, string xb41a802ca5fde63b, string x5b017a6ede496d54, string x43ca4b32e485d93f, MainWindow MainWindow)
	{
		if (File.Exists(xb41a802ca5fde63b))
		{
			try
			{
				x7d45a69b707b1582.x90fda48194fc6b9a(xa4d52e34b62b5495, Codelist.x5d95f5f98c940295(xb41a802ca5fde63b));
			}
			catch (Exception ex)
			{
				MainWindow.x5486e0b5e830d25c();
				MessageBox.Show(this, "Could not load " + x43ca4b32e485d93f + " codelist file.\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	private void xb5debc4debbe9b2d(ref x131eae80bdcb392e x7d45a69b707b1582, x97cc998483ae0218 control, string x5b017a6ede496d54, string x43ca4b32e485d93f, string xdd505126a6f8795f, string xfe91b1d530d8d078)
	{
		bool useWaitCursor = base.UseWaitCursor;
		base.UseWaitCursor = true;
		try
		{
			x7d45a69b707b1582 = x131eae80bdcb392e.x45260ad4b94166f2;
			control.x451c5ee2445ffafd(x7d45a69b707b1582);
			using MainWindow x346ddb85fad09a = MainWindow.CreateMessageBox(this, "Loading " + x5b017a6ede496d54 + " codelist...");
			switch (CodeManagerSettings.Instance.RegionCode)
			{
			case RegionCode.Mixed:
				x6af1203b6caa7239(ref x7d45a69b707b1582, RegionCode.PAL, xdd505126a6f8795f, x5b017a6ede496d54, x43ca4b32e485d93f, x346ddb85fad09a);
				x6af1203b6caa7239(ref x7d45a69b707b1582, RegionCode.NTSC, xfe91b1d530d8d078, x5b017a6ede496d54, x43ca4b32e485d93f, x346ddb85fad09a);
				break;
			case RegionCode.NTSC:
				x6af1203b6caa7239(ref x7d45a69b707b1582, RegionCode.NTSC, xfe91b1d530d8d078, x5b017a6ede496d54, x43ca4b32e485d93f, x346ddb85fad09a);
				break;
			default:
				x6af1203b6caa7239(ref x7d45a69b707b1582, RegionCode.PAL, xdd505126a6f8795f, x5b017a6ede496d54, x43ca4b32e485d93f, x346ddb85fad09a);
				break;
			}
			control.x451c5ee2445ffafd(x7d45a69b707b1582);
		}
		finally
		{
			base.UseWaitCursor = useWaitCursor;
		}
	}

	private void x8c06f59cda51f321()
	{
		xb5debc4debbe9b2d(ref x341b5be0450509fe, xad90bf79a283dea6, "CD", "original CD", x77dccad1db69a78f.x93bd97d3afddf842, x77dccad1db69a78f.x411b38a624544322);
	}

	private void x81940daabd5d42a2()
	{
		xb5debc4debbe9b2d(ref xd8c2f6d1ce092fe8, x3cabd9709ac6c0f8, "downloaded", "previously downloaded", x77dccad1db69a78f.xa75c14bfc9532718, x77dccad1db69a78f.xbf331fe297ee1425);
		x990ce41f6429c278 = false;
	}

	private void x788ad6b71a6e521f()
	{
		x985c922c6fd8031c.x451c5ee2445ffafd(x7d682c974eb9bc38);
		x0b02574824d92cc7.Enabled = x7d682c974eb9bc38.xe60cad9a2d565735;
		xb7a48894a0af41a5.Enabled = xd8c2f6d1ce092fe8.xe60cad9a2d565735 && x7d682c974eb9bc38.xe60cad9a2d565735 && x7d682c974eb9bc38 != xd8c2f6d1ce092fe8;
		x76d8474d05bbe7db();
		x7a8b34a4828fff0b();
		x761d57200285bc56(this, EventArgs.Empty);
	}

	private void SettingsBtnFn(object sender, EventArgs e)
	{
		RegionCode regionCode = CodeManagerSettings.Instance.RegionCode;
		bool checkAssociations = CodeManagerSettings.Instance.CheckAssociations;
		bool x68ff273cc374232d;
		using (xa781f36c24e56139 xa781f36c24e56140 = new xa781f36c24e56139())
		{
			xa781f36c24e56140.ShowDialog(this);
			x68ff273cc374232d = xa781f36c24e56140.x68ff273cc374232d;
		}
		if (CodeManagerSettings.Instance.CheckAssociations && CodeManagerSettings.Instance.CheckAssociations != checkAssociations)
		{
			x6d9ca4e37730b3ad();
		}
		if (CodeManagerSettings.Instance.RegionCode != regionCode)
		{
			x7d682c974eb9bc38 = x131eae80bdcb392e.x45260ad4b94166f2;
			x8c06f59cda51f321();
			x81940daabd5d42a2();
			x7d682c974eb9bc38 = xd8c2f6d1ce092fe8;
			x788ad6b71a6e521f();
		}
		else if (x68ff273cc374232d)
		{
			x8c06f59cda51f321();
			x7a8b34a4828fff0b();
		}
	}

	public void x6d9ca4e37730b3ad()
	{
		string text = x9a1f7a25d35ea036.xe637e96cc5386930("mcmcode");
		if ((!string.IsNullOrEmpty(text) && x289f1a0ee2f795a7.x4f90d54847434178(text, Application.ExecutablePath)) || (x6c212c9a8eebe445 != xb428466f1afbae0c.x2ff77f3339c1efa1 && MessageBox.Show(this, "MAX Code Manager does not appear to be associated with .mcmcode files.\r\n\r\nWould you like it to associate itself with them?", "File Association", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes))
		{
			return;
		}
		try
		{
			using (x9a1f7a25d35ea036.x4f14b99f5099d83a x4f14b99f5099d83a = x9a1f7a25d35ea036.x6f1a5f10b6837ab1("MaxCodeManager.Codelist"))
			{
				x4f14b99f5099d83a.x3d235fc95c355365 = "MAX Codelist Manager Codelist";
				x4f14b99f5099d83a.x84fb75d7f9b8baa9 = Application.ExecutablePath + ",-2";
				x4f14b99f5099d83a.xddebe5a8f5476540 = null;
				x9a1f7a25d35ea036.xe264ee45dcea29ee xe264ee45dcea29ee = x4f14b99f5099d83a.x080a233dd16d015c.xd6b6ed77479ef68c("open");
				xe264ee45dcea29ee.x7a274f60ab25f2b9 = '"' + Application.ExecutablePath + "\" \"%1\"";
				xe264ee45dcea29ee.x3d235fc95c355365 = null;
				xe264ee45dcea29ee.x6e6bdce65918d15d = false;
			}
			using (x9a1f7a25d35ea036.x3cc749c036e97730 x3cc749c036e = x9a1f7a25d35ea036.x9fbde06ead3353c8("mcmcode"))
			{
				x3cc749c036e.xe5d13ccbc3df998a = "MaxCodeManager.Codelist";
			}
			x9a1f7a25d35ea036.x792ba40fa40166fc();
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "An error occurred while trying to create the file association: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void DownloadBtnFn(object sender, EventArgs e)
	{
		if (x990ce41f6429c278)
		{
			x81940daabd5d42a2();
		}
		x3787ad1bc8cbbc9d(xa85f9af1c5f740b5: false);
	}

	private void x3787ad1bc8cbbc9d(bool xa85f9af1c5f740b5)
	{
		switch (CodeManagerSettings.Instance.RegionCode)
		{
		default:
			x0dffdf693828ef7b(RegionCode.PAL, xa85f9af1c5f740b5);
			break;
		case RegionCode.NTSC:
			x0dffdf693828ef7b(RegionCode.NTSC, xa85f9af1c5f740b5);
			break;
		case RegionCode.Mixed:
			x0dffdf693828ef7b(RegionCode.PAL, xa85f9af1c5f740b5);
			x0dffdf693828ef7b(RegionCode.NTSC, xa85f9af1c5f740b5);
			break;
		}
		if (x990ce41f6429c278)
		{
			x788ad6b71a6e521f();
		}
	}

	private void x0dffdf693828ef7b(RegionCode xa4d52e34b62b5495, bool xa85f9af1c5f740b5)
	{
		x0dffdf693828ef7b(xa4d52e34b62b5495, xa85f9af1c5f740b5, x6b753c834085f4f9: false);
	}

	private void x0dffdf693828ef7b(RegionCode xa4d52e34b62b5495, bool xa85f9af1c5f740b5, bool x6b753c834085f4f9)
	{
		if (x204c70d9180bf248(xa4d52e34b62b5495, xa85f9af1c5f740b5, x6b753c834085f4f9, out var xc7ffcf38b300713c))
		{
			xb1fade4398e4ef6c(xa4d52e34b62b5495, xc7ffcf38b300713c);
		}
	}

	private bool x204c70d9180bf248(RegionCode xa4d52e34b62b5495, bool xa85f9af1c5f740b5, bool x6b753c834085f4f9, out bool xc7ffcf38b300713c)
	{
		Codelist codelist = xd8c2f6d1ce092fe8.x38758cbbee49e4cb(xa4d52e34b62b5495);
		xc7ffcf38b300713c = false;
		int num;
		try
		{
			if (x6b753c834085f4f9)
			{
				throw new Exception("There was a problem last time, so you asked to skip this server.");
			}
			num = x71e47d5e67c3290d.x3952158a13fc61b9(this, xa4d52e34b62b5495);
		}
		catch (Exception ex)
		{
			try
			{
				num = x71e47d5e67c3290d.xf097174157e3d00e(this, xa4d52e34b62b5495);
				xc7ffcf38b300713c = true;
			}
			catch (Exception ex2)
			{
				if (xa85f9af1c5f740b5)
				{
					return false;
				}
				MessageBox.Show(this, "An error occurred while trying to contact both the CodeJunkies and backup servers.\r\n\r\nCodeJunkies: " + ex.Message + "\r\nBackup: " + ex2.Message, "Cannot download codelist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
		}
		if (codelist != null)
		{
			if (num < codelist.x77fa6322561797a0)
			{
				string format = "You currently have version {0} of the {1} codelist, and version {2} is the latest available on the " + (xc7ffcf38b300713c ? "backup server.  Maybe you should get in touch with Mirality Systems and offer them your codelist?" : "CodeJunkies server.  Congratulations, you appear to have achieved time travel.");
				MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, format, codelist.x77fa6322561797a0, xa4d52e34b62b5495.ToString(), num), "Your codelist is better than theirs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (num == codelist.x77fa6322561797a0)
			{
				if (xa85f9af1c5f740b5)
				{
					return false;
				}
				string format2 = "You currently have version {0} of the {1} codelist.  That appears to match the latest version available from " + (xc7ffcf38b300713c ? "the backup server.  (The CodeJunkies server couldn't be contacted.)" : "the CodeJunkies server.");
				MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, format2, codelist.x77fa6322561797a0, xa4d52e34b62b5495.ToString()), "Your codelist is already up to date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			string format3 = "You currently have version {0} of the {1} codelist, and version {2} is now available on " + (xc7ffcf38b300713c ? "the backup server.  (The CodeJunkies server couldn't be contacted.)  " : "the CodeJunkies server.  ") + "Would you like to download it?";
			if (MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, format3, codelist.x77fa6322561797a0, xa4d52e34b62b5495.ToString(), num), "New codelist available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return false;
			}
		}
		return true;
	}

	private void xb1fade4398e4ef6c(RegionCode xa4d52e34b62b5495, bool xc7ffcf38b300713c)
	{
		base.UseWaitCursor = true;
		try
		{
			string tempFileName = Path.GetTempFileName();
			try
			{
				if (xc7ffcf38b300713c ? x71e47d5e67c3290d.x3b4eb5505a678b12(this, xa4d52e34b62b5495, tempFileName) : x71e47d5e67c3290d.xb1fade4398e4ef6c(this, xa4d52e34b62b5495, tempFileName))
				{
					Codelist codelist = null;
					try
					{
						codelist = Codelist.x5d95f5f98c940295(tempFileName);
					}
					catch (Exception ex)
					{
						if (xc7ffcf38b300713c)
						{
							MessageBox.Show(this, string.Concat("A new ", xa4d52e34b62b5495, " codelist was successfully downloaded from the backup server (since we couldn't contact the CodeJunkies server), but an error occurred while trying to read it.  I guess this just isn't your lucky day.  (Most likely you're having some kind of network corruption issues; try again later.)\r\n\r\n", ex.Message), "Unable to load backup codelist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						else if (MessageBox.Show(this, string.Concat("A new ", xa4d52e34b62b5495, " codelist was successfully downloaded from the CodeJunkies server, but an error occurred while trying to read it.  It may have been corrupted in transit, or possibly CodeJunkies uploaded an invalid codelist (it's been known to happen from time to time).\r\n\r\n", ex.Message, "\r\n\r\nWould you like to try downloading from the backup server instead?"), "Unable to load codelist", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
						{
							x0dffdf693828ef7b(xa4d52e34b62b5495, xa85f9af1c5f740b5: false, x6b753c834085f4f9: true);
						}
						return;
					}
					switch (xa4d52e34b62b5495)
					{
					case RegionCode.NTSC:
						Directory.CreateDirectory(Path.GetDirectoryName(x77dccad1db69a78f.xbf331fe297ee1425));
						File.Copy(tempFileName, x77dccad1db69a78f.xbf331fe297ee1425, overwrite: true);
						break;
					case RegionCode.PAL:
						Directory.CreateDirectory(Path.GetDirectoryName(x77dccad1db69a78f.xa75c14bfc9532718));
						File.Copy(tempFileName, x77dccad1db69a78f.xa75c14bfc9532718, overwrite: true);
						break;
					}
					x990ce41f6429c278 = true;
					x7d682c974eb9bc38.x90fda48194fc6b9a(xa4d52e34b62b5495, codelist);
				}
				else
				{
					MessageBox.Show(this, "An error occurred while trying to download the codelist.  You may need to try again later.", "Cannot download codelist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			finally
			{
				File.Delete(tempFileName);
			}
		}
		finally
		{
			base.UseWaitCursor = false;
		}
	}

	private void x89f94fbb2f9f5452()
	{
		xfbb5d827b0145991();
		if (x50892314664b644e == null)
		{
			x7468a31bcc5ded5a.Text = "(none)";
			x7702318dbc4bbe4b.Text = "No codelist selected.";
			x75cfc97b61818036.x06ca69422bbb7502 = null;
			xd514546ab3c9516d.Enabled = false;
			return;
		}
		if (x50892314664b644e.x06ca69422bbb7502 == null)
		{
			throw new InvalidOperationException("active codelist not loaded?!?");
		}
		xd514546ab3c9516d.Enabled = true;
		x7468a31bcc5ded5a.Text = Path.GetFileNameWithoutExtension(x50892314664b644e.Filename);
		x7702318dbc4bbe4b.Text = xebb19d67c65291be(x50892314664b644e.Filename);
		xc4c34e75b01b4519.SetToolTip(x7702318dbc4bbe4b, x7702318dbc4bbe4b.Text);
		x75cfc97b61818036.x06ca69422bbb7502 = x50892314664b644e.x06ca69422bbb7502.x9425d7602dc80ff4;
	}

	private static string xebb19d67c65291be(string xb41a802ca5fde63b)
	{
		string x7d95d971d8923f4c = null;
		if (x087a8d6965e36af1(xb41a802ca5fde63b, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "[Desktop]", ref x7d95d971d8923f4c))
		{
			return x7d95d971d8923f4c;
		}
		if (x087a8d6965e36af1(xb41a802ca5fde63b, Environment.GetFolderPath(Environment.SpecialFolder.Personal), "[Documents]", ref x7d95d971d8923f4c))
		{
			return x7d95d971d8923f4c;
		}
		if (x087a8d6965e36af1(xb41a802ca5fde63b, Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "[Programs]", ref x7d95d971d8923f4c))
		{
			return x7d95d971d8923f4c;
		}
		return xb41a802ca5fde63b;
	}

	private static bool x087a8d6965e36af1(string xb41a802ca5fde63b, string x49b4162c27824599, string x1c2743f354837549, ref string x7d95d971d8923f4c)
	{
		if (x7d95d971d8923f4c != null)
		{
			return false;
		}
		string text = xb41a802ca5fde63b.ToLowerInvariant();
		string text2 = x49b4162c27824599.ToLowerInvariant();
		if (text.StartsWith(text2))
		{
			x7d95d971d8923f4c = x1c2743f354837549 + text.Substring(text2.Length);
			return true;
		}
		return false;
	}

	private void x361f2cc1e9b948a0(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xb2f83dca3a2248d7.Stop();
		x7a8b34a4828fff0b();
	}

	private void x76d8474d05bbe7db()
	{
		using (MainWindow.CreateMessageBox(this, "Generating official codelist..."))
		{
			x40d7509752490077 = new Codelist();
			x40d7509752490077.xd5da23b762ce52a2(x7d682c974eb9bc38.x32866930416901c3);
			x40d7509752490077.xd5da23b762ce52a2(x341b5be0450509fe.x32866930416901c3);
		}
	}

	private void x7a8b34a4828fff0b()
	{
		using (MainWindow.CreateMessageBox(this, "Generating combined codelist..."))
		{
			Codelist codelist = xa021be45aed5eb5d();
			x768b6665179efa05 = new Codelist();
			x768b6665179efa05.xd5da23b762ce52a2(codelist);
			x768b6665179efa05.xd5da23b762ce52a2(x40d7509752490077);
			xa06a52b1869d241d.x06ca69422bbb7502 = codelist;
			x0f289e063dca8ffa.x06ca69422bbb7502 = x768b6665179efa05;
		}
		x5662a37e9c62e4ee();
	}

	private Codelist xa021be45aed5eb5d()
	{
		x0bc07355221f6454 = new Codelist();
		Codelist codelist = new Codelist();
		bool flag = false;
		foreach (ListViewItem item in xdb68d5db35f39c3b.Items)
		{
			if (item == xcd3f268901925ceb)
			{
				flag = true;
				x0bc07355221f6454.xd5da23b762ce52a2(codelist);
			}
			if (item.Checked)
			{
				xc68feac946ffcf6f x06ca69422bbb = ((CodelistFile)item.Tag).x06ca69422bbb7502;
				if (x06ca69422bbb != null)
				{
					codelist.xd5da23b762ce52a2(x06ca69422bbb.x9425d7602dc80ff4);
				}
			}
		}
		if (!flag)
		{
			x0bc07355221f6454.xd5da23b762ce52a2(codelist);
		}
		x0bc07355221f6454.xd5da23b762ce52a2(x40d7509752490077);
		return codelist;
	}

	private void x267b27bc4addcd6d(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		int num = xdb68d5db35f39c3b.ClientSize.Width - 2;
		num -= x4f9e88a7f60520ba.Width;
		x5a428ce3753ad1d1.Width = num;
	}

	private void x1aaf83a875993cfd(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		int num = xda8bb6fd239370b7.ClientSize.Width - 2;
		num -= CodesColumnHeader.Width + RegionColumnHeader.Width;
		x5f68d5b5d2980b57.Width = num;
	}

	private void x761d57200285bc56(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		bool flag = xdb68d5db35f39c3b.SelectedItems.Count == 1;
		bool enabled = xdb68d5db35f39c3b.SelectedItems.Count == 2;
		bool enabled2 = xdb68d5db35f39c3b.SelectedItems.Count >= 1;
		MoveUpBtn.Enabled = flag && xdb68d5db35f39c3b.SelectedIndices[0] > 0;
		MoveDownBtn.Enabled = flag && xdb68d5db35f39c3b.SelectedIndices[0] < xdb68d5db35f39c3b.Items.Count - 1;
		ViewCodeListBtn.Enabled = enabled2;
		CompareCodeListsBtn.Enabled = enabled;
		RemoveCodeListBtn.Enabled = enabled2;
		MakeActiveBtn.Enabled = flag && xdb68d5db35f39c3b.SelectedItems[0] != xcd3f268901925ceb;
	}

	private void xbbd29bd1d5a360f1(object xe0292b9ed559da7d, ItemCheckedEventArgs xfbf34718e704c6bc)
	{
		((CodelistFile)xfbf34718e704c6bc.Item.Tag).Active = xfbf34718e704c6bc.Item.Checked;
		xb2f83dca3a2248d7.Start();
	}

	private void x05d68e95df241fd3(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		ViewCodeListBtn.PerformClick();
	}

	private void xc7ed830360cab883()
	{
		List<string> list = new List<string>();
		foreach (CodelistFile codelist in CodeManagerSettings.Instance.Codelists)
		{
			try
			{
				x964d37dff5e41bd4(codelist);
			}
			catch (Exception ex)
			{
				list.Add(string.Format(CultureInfo.CurrentCulture, "\"{0}\": {1}", Path.GetFileNameWithoutExtension(codelist.Filename), ex.Message));
			}
		}
		if (list.Count > 0)
		{
			MessageBox.Show(this, "An error occurred while loading one or more custom codelists.\r\n\r\n" + string.Join("\r\n", list.ToArray()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void x964d37dff5e41bd4(CodelistFile xb44380e048627945)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(xb44380e048627945.Filename);
		using (MainWindow.CreateMessageBox(this, "Loading codelist \"" + fileNameWithoutExtension + "\"..."))
		{
			xb44380e048627945.x06ca69422bbb7502 = xc68feac946ffcf6f.x5d95f5f98c940295(xb44380e048627945.Filename);
		}
	}

	private bool xd37bd1ba3d96dde7(CodelistFile xb44380e048627945)
	{
		try
		{
			xb44380e048627945.x06ca69422bbb7502.Write(xb44380e048627945.Filename);
			xb44380e048627945.Dirty = false;
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "An error occurred while saving the codelist \"" + Path.GetFileNameWithoutExtension(xb44380e048627945.Filename) + "\".\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
	}

	private bool x0cb22ffedfb043d7()
	{
		bool result = true;
		foreach (CodelistFile codelist in CodeManagerSettings.Instance.Codelists)
		{
			if (codelist.Dirty && !xd37bd1ba3d96dde7(codelist))
			{
				result = false;
			}
		}
		return result;
	}

	private void xece840ab67ddb8e0()
	{
		bool useWaitCursor = base.UseWaitCursor;
		base.UseWaitCursor = true;
		xdb68d5db35f39c3b.BeginUpdate();
		try
		{
			xdb68d5db35f39c3b.Items.Clear();
			foreach (CodelistFile codelist in CodeManagerSettings.Instance.Codelists)
			{
				xc423482c5e4eb4b4(codelist);
			}
		}
		finally
		{
			xdb68d5db35f39c3b.EndUpdate();
			base.UseWaitCursor = useWaitCursor;
		}
	}

	private void x0a87b5fb6258b9b3()
	{
		if (string.IsNullOrEmpty(CodeManagerSettings.Instance.ActiveCodelistFile))
		{
			return;
		}
		foreach (ListViewItem item in xdb68d5db35f39c3b.Items)
		{
			CodelistFile codelistFile = (CodelistFile)item.Tag;
			if (x289f1a0ee2f795a7.x4f90d54847434178(CodeManagerSettings.Instance.ActiveCodelistFile, codelistFile.Filename))
			{
				x10cbf211cdc9304b(item);
				break;
			}
		}
	}

	private void AddBtnFn(object sender, EventArgs e)
	{
		x1d8fb7d81af42349.Filter = "All supported files|*.mcmcode;*.bin;*.max;arsettings.dat|MCM Codelist (*.mcmcode)|*.mcmcode|MAX Codelist (*.bin)|*.bin|MAX SaveGame (*.max)|*.max|arsettings.dat file|arsettings.dat|All files|*.*";
		if (x1d8fb7d81af42349.ShowDialog(this) == DialogResult.OK)
		{
			x3f4b45fa2073b695(x1d8fb7d81af42349.FileNames);
		}
	}

	private void x3f4b45fa2073b695(string[] x499b08a184e62535)
	{
		try
		{
			xdb68d5db35f39c3b.BeginUpdate();
			xdb68d5db35f39c3b.SelectedItems.Clear();
			foreach (string text in x499b08a184e62535)
			{
				bool useWaitCursor = base.UseWaitCursor;
				base.UseWaitCursor = true;
				try
				{
					if (CodeManagerSettings.Instance.Codelists.Contains(text))
					{
						MessageBox.Show(this, "Codelist file \"" + text + "\" is already in your list.", "Already loaded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						continue;
					}
					string text2 = xd8871c5f4b559650(text);
					if (text2 != null)
					{
						MessageBox.Show(this, "Could not load codelist file \"" + text + "\".\r\n\r\n" + text2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				finally
				{
					base.UseWaitCursor = useWaitCursor;
				}
			}
		}
		finally
		{
			xdb68d5db35f39c3b.EndUpdate();
		}
	}

	private string xd8871c5f4b559650(string xb41a802ca5fde63b)
	{
		try
		{
			switch (Path.GetExtension(xb41a802ca5fde63b).ToLowerInvariant())
			{
			case ".mcmcode":
			{
				CodelistFile codelistFile = new CodelistFile(xb41a802ca5fde63b);
				x964d37dff5e41bd4(codelistFile);
				CodeManagerSettings.Instance.Codelists.Add(codelistFile);
				ListViewItem listViewItem = xc423482c5e4eb4b4(codelistFile);
				listViewItem.Selected = true;
				break;
			}
			case ".bin":
				x7e6266fd418decf0("a MAX codelist file", xb41a802ca5fde63b, Codelist.x5d95f5f98c940295(xb41a802ca5fde63b));
				break;
			case ".max":
			{
				x485b33aee91e5943 x485b33aee91e = x485b33aee91e5943.x5d95f5f98c940295(xb41a802ca5fde63b);
				if (x485b33aee91e.TryGetValue("codelist.bin", out var xbcea506a33cf))
				{
					using (MemoryStream input = new MemoryStream(xbcea506a33cf))
					{
						Codelist x8a0b266419f09a = Codelist.x5d95f5f98c940295(new BinaryReader(input));
						x7e6266fd418decf0("a MAX savegame file (with embedded codelist)", xb41a802ca5fde63b, x8a0b266419f09a);
					}
					break;
				}
				if (x485b33aee91e.TryGetValue("settings.dat", out xbcea506a33cf))
				{
					using (MemoryStream input2 = new MemoryStream(xbcea506a33cf))
					{
						x89c597989b13898e x89c597989b13898e = x89c597989b13898e.x5d95f5f98c940295(new BinaryReader(input2));
						x7e6266fd418decf0("a MAX savegame file (with embedded settings)", xb41a802ca5fde63b, x89c597989b13898e.Codelist);
					}
					break;
				}
				return "While the file \"" + xb41a802ca5fde63b + "\" does appear to be a valid MAX save file (\"" + x485b33aee91e.xe9c44fbf9adae540 + "\"), it does not appear to be an \"ActionReplayMAXSettings\" file and so does not contain a loadable codelist.";
			}
			case ".dat":
				x7e6266fd418decf0("a MAX settings file", xb41a802ca5fde63b, x89c597989b13898e.x5d95f5f98c940295(xb41a802ca5fde63b).Codelist);
				break;
			default:
				return "The file \"" + xb41a802ca5fde63b + "\" doesn't have a recognised extension; not sure how to load it.";
			}
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		return null;
	}

	private void x7e6266fd418decf0(string xc2358fbac7da3d45, string xb41a802ca5fde63b, Codelist list)
	{
		if ((list == null || list.x69e1830021be7f93 == 0) && MessageBox.Show(this, "While the file \"" + xb41a802ca5fde63b + "\" does appear to be valid, it doesn't seem to contain any actual codes.\r\n\r\nDo you want to continue importing it anyway?", "Codelist empty", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
		{
			return;
		}
		string fileName = Path.ChangeExtension(xb41a802ca5fde63b, ".mcmcode");
		MessageBox.Show(this, "The file \"" + xb41a802ca5fde63b + "\" is " + xc2358fbac7da3d45 + ", and must be resaved in MCM format in order to add it to your list of MCM codelists.", "Resave as MCM codelist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		xc21543d0206190f3.FileName = fileName;
		if (xc21543d0206190f3.ShowDialog(this) != DialogResult.OK)
		{
			return;
		}
		fileName = xc21543d0206190f3.FileName;
		if (CodeManagerSettings.Instance.Codelists.Contains(fileName))
		{
			MessageBox.Show(this, "Codelist file \"" + xb41a802ca5fde63b + "\" is already in your list.", "Already loaded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		try
		{
			CodelistFile codelistFile = new CodelistFile(fileName);
			codelistFile.x06ca69422bbb7502 = new xc68feac946ffcf6f();
			codelistFile.x06ca69422bbb7502.x9425d7602dc80ff4 = list;
			codelistFile.Dirty = true;
			CodeManagerSettings.Instance.Codelists.Add(codelistFile);
			ListViewItem listViewItem = xc423482c5e4eb4b4(codelistFile);
			listViewItem.Selected = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "Could not create codelist file \"" + fileName + "\".\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private ListViewItem xc423482c5e4eb4b4(CodelistFile xb44380e048627945)
	{
		ListViewItem listViewItem = new ListViewItem(new string[xdb68d5db35f39c3b.Columns.Count]);
		listViewItem.Tag = xb44380e048627945;
		listViewItem.Checked = xb44380e048627945.Active;
		x3d18c4841d9c7d0b(listViewItem);
		return xdb68d5db35f39c3b.Items.Add(listViewItem);
	}

	private void x3d18c4841d9c7d0b(ListViewItem item)
	{
		CodelistFile codelistFile = (CodelistFile)item.Tag;
		item.ForeColor = ((codelistFile.x06ca69422bbb7502 == null) ? Color.Red : Color.Empty);
		item.SubItems[x5a428ce3753ad1d1.Index].Text = Path.GetFileNameWithoutExtension(codelistFile.Filename);
		item.SubItems[x4f9e88a7f60520ba.Index].Text = ((codelistFile.x06ca69422bbb7502 == null) ? "0" : codelistFile.x06ca69422bbb7502.x9425d7602dc80ff4.x69e1830021be7f93.ToString(CultureInfo.CurrentCulture));
	}

	private void xfbb5d827b0145991()
	{
		if (x50892314664b644e == null)
		{
			return;
		}
		foreach (ListViewItem item in xdb68d5db35f39c3b.Items)
		{
			if (item.Tag == x50892314664b644e)
			{
				x3d18c4841d9c7d0b(item);
				break;
			}
		}
	}

	private void NewCodeListBtnFn(object sender, EventArgs e)
	{
		if (xc21543d0206190f3.ShowDialog(this) == DialogResult.OK)
		{
			xdb68d5db35f39c3b.SelectedItems.Clear();
			string fileName = xc21543d0206190f3.FileName;
			if (CodeManagerSettings.Instance.Codelists.Contains(fileName))
			{
				MessageBox.Show(this, "Codelist file \"" + fileName + "\" is already in your list.", "Already loaded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			CodelistFile codelistFile = new CodelistFile(fileName);
			codelistFile.x06ca69422bbb7502 = new xc68feac946ffcf6f();
			CodeManagerSettings.Instance.Codelists.Add(codelistFile);
			ListViewItem listViewItem = xc423482c5e4eb4b4(codelistFile);
			listViewItem.Selected = true;
		}
	}

	private void RemoveBtnFn(object sender, EventArgs e)
	{
		xdb68d5db35f39c3b.BeginUpdate();
		try
		{
			while (xdb68d5db35f39c3b.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = xdb68d5db35f39c3b.SelectedItems[0];
				CodelistFile codelistFile = (CodelistFile)listViewItem.Tag;
				if (codelistFile.Dirty)
				{
					switch (MessageBox.Show(this, "You have made changes to the list \"" + listViewItem.Text + "\".\r\n\r\nWould you like to save those changes before removing it?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
					{
					case DialogResult.Yes:
						if (!xd37bd1ba3d96dde7(codelistFile))
						{
							return;
						}
						break;
					case DialogResult.Cancel:
						return;
					}
				}
				if (listViewItem == xcd3f268901925ceb)
				{
					x10cbf211cdc9304b(null);
				}
				CodeManagerSettings.Instance.Codelists.Remove(codelistFile);
				xdb68d5db35f39c3b.Items.Remove(listViewItem);
			}
		}
		finally
		{
			xdb68d5db35f39c3b.EndUpdate();
		}
	}

	private void xf34dbca941eda6fd(ListViewItem item, int x374ea4fe62468d0f)
	{
		CodelistFile xccb63ca5f63dc471 = (CodelistFile)item.Tag;
		int num = CodeManagerSettings.Instance.Codelists.IndexOf(xccb63ca5f63dc471);
		if (num == -1)
		{
			return;
		}
		CodeManagerSettings.Instance.Codelists.RemoveAt(num);
		CodeManagerSettings.Instance.Codelists.Insert(num + x374ea4fe62468d0f, xccb63ca5f63dc471);
		num = item.Index;
		xdb68d5db35f39c3b.BeginUpdate();
		try
		{
			xdb68d5db35f39c3b.Items.Remove(item);
			xdb68d5db35f39c3b.Items.Insert(num + x374ea4fe62468d0f, item);
		}
		finally
		{
			xdb68d5db35f39c3b.EndUpdate();
		}
	}

	private void MoveUpBtnFn(object sender, EventArgs e)
	{
		xf34dbca941eda6fd(xdb68d5db35f39c3b.SelectedItems[0], -1);
	}

	private void MoveDownBtnFn(object sender, EventArgs e)
	{
		xf34dbca941eda6fd(xdb68d5db35f39c3b.SelectedItems[0], 1);
	}

	private static void x2ff81ffb42e24727(string xf50d6d3c10c0eac9)
	{
		try
		{
			Process.Start(xf50d6d3c10c0eac9)?.Close();
		}
		catch
		{
		}
	}

	private void OpenLinkBtnFn(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (e.Button == MouseButtons.Left && e.Link.LinkData.ToString().StartsWith("http://"))
		{
			x2ff81ffb42e24727(e.Link.LinkData.ToString());
		}
	}

	private void x72c269e9be1c5015(string xc15bd84e01929885, Codelist list)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		Codelist codelist = ((x50892314664b644e == null) ? null : x50892314664b644e.x06ca69422bbb7502.x9425d7602dc80ff4);
		if (x0bc07355221f6454 == null)
		{
			x7a8b34a4828fff0b();
		}
		using x325527706166bcaf x325527706166bcaf2 = new x325527706166bcaf(xc15bd84e01929885, list, codelist, x768b6665179efa05, (list == codelist) ? x0bc07355221f6454 : null);
		bool favouritesChanged = false;
		bool activeListChanged = false;
		x325527706166bcaf2.x978f28482caa2f52 += delegate
		{
			favouritesChanged = true;
		};
		x325527706166bcaf2.xcded22aefe17fee1 += delegate
		{
			activeListChanged = true;
		};
		x325527706166bcaf2.ShowDialog(this);
		if (activeListChanged)
		{
			x50892314664b644e.Dirty = true;
			x89f94fbb2f9f5452();
			x7a8b34a4828fff0b();
		}
		else if (favouritesChanged)
		{
			x5662a37e9c62e4ee();
		}
	}

	private void ViewAllCodesBtnFn(object sender, EventArgs e)
	{
		x72c269e9be1c5015("Official Lists", x40d7509752490077);
	}

	private void ViewCodeListBtnFn(object sender, EventArgs e)
	{
		if (xdb68d5db35f39c3b.SelectedItems.Count == 0)
		{
			return;
		}
		if (xdb68d5db35f39c3b.SelectedItems.Count == 1)
		{
			ListViewItem listViewItem = xdb68d5db35f39c3b.SelectedItems[0];
			CodelistFile codelistFile = (CodelistFile)listViewItem.Tag;
			if (codelistFile.x06ca69422bbb7502 == null)
			{
				try
				{
					x964d37dff5e41bd4(codelistFile);
					x3d18c4841d9c7d0b(listViewItem);
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, "Could not load codelist file \"" + codelistFile.Filename + "\".\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
			x72c269e9be1c5015(listViewItem.Text, codelistFile.x06ca69422bbb7502.x9425d7602dc80ff4);
			return;
		}
		Codelist codelist = new Codelist();
		foreach (ListViewItem selectedItem in xdb68d5db35f39c3b.SelectedItems)
		{
			xc68feac946ffcf6f x06ca69422bbb = ((CodelistFile)selectedItem.Tag).x06ca69422bbb7502;
			if (x06ca69422bbb != null)
			{
				codelist.xd5da23b762ce52a2(x06ca69422bbb.x9425d7602dc80ff4);
			}
		}
		x72c269e9be1c5015("Custom Codelists", codelist);
	}

	private void MakeActiveBtnFn(object sender, EventArgs e)
	{
		x10cbf211cdc9304b(xdb68d5db35f39c3b.SelectedItems[0]);
		MakeActiveBtn.Enabled = false;
	}

	private void x10cbf211cdc9304b(ListViewItem item)
	{
		CodelistFile codelistFile = ((item == null) ? null : ((CodelistFile)item.Tag));
		if (codelistFile != null && codelistFile.x06ca69422bbb7502 == null)
		{
			try
			{
				x964d37dff5e41bd4(codelistFile);
				x3d18c4841d9c7d0b(item);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, "Could not load codelist file \"" + codelistFile.Filename + "\".\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		if (xcd3f268901925ceb != null)
		{
			xcd3f268901925ceb.ForeColor = SystemColors.WindowText;
		}
		xcd3f268901925ceb = item;
		if (item == null)
		{
			x50892314664b644e = null;
			CodeManagerSettings.Instance.ActiveCodelistFile = null;
		}
		else
		{
			x50892314664b644e = (CodelistFile)item.Tag;
			item.ForeColor = Color.Green;
			CodeManagerSettings.Instance.ActiveCodelistFile = x50892314664b644e.Filename;
		}
		x0bc07355221f6454 = null;
		x89f94fbb2f9f5452();
	}

	private void ViewActiveBtnFn(object sender, EventArgs e)
	{
		x72c269e9be1c5015("Active List", x50892314664b644e.x06ca69422bbb7502.x9425d7602dc80ff4);
	}

	private void ViewCombinedBtnFn(object sender, EventArgs e)
	{
		x72c269e9be1c5015("Combined List", x768b6665179efa05);
	}

	private void WhatsNewBtnFn(object sender, EventArgs e)
	{
		Codelist x32866930416901c = xd8c2f6d1ce092fe8.x32866930416901c3;
		string x13c3fb0565df0a = string.Format(CultureInfo.CurrentCulture, "Previously downloaded official codelist (v{0})", x32866930416901c.x77fa6322561797a0);
		Codelist x32866930416901c2 = x7d682c974eb9bc38.x32866930416901c3;
		string xac95817976f = string.Format(CultureInfo.CurrentCulture, "Newly downloaded official codelist (v{0})", x32866930416901c2.x77fa6322561797a0);
		bool favouritesChanged = false;
		using (x9ae7778f2e265c77 x9ae7778f2e265c78 = new x9ae7778f2e265c77(x13c3fb0565df0a, x32866930416901c, xac95817976f, x32866930416901c2))
		{
			x9ae7778f2e265c78.x978f28482caa2f52 += delegate
			{
				favouritesChanged = true;
			};
			x9ae7778f2e265c78.ShowDialog(this);
		}
		if (favouritesChanged)
		{
			x5662a37e9c62e4ee();
		}
	}

	private void CompareCodeListsBtnFn(object sender, EventArgs e)
	{
		if (xdb68d5db35f39c3b.SelectedItems.Count != 2)
		{
			return;
		}
		CodelistFile codelistFile = (CodelistFile)xdb68d5db35f39c3b.SelectedItems[0].Tag;
		CodelistFile codelistFile2 = (CodelistFile)xdb68d5db35f39c3b.SelectedItems[1].Tag;
		if (codelistFile.x06ca69422bbb7502 == null || codelistFile2.x06ca69422bbb7502 == null)
		{
			MessageBox.Show(this, "One or both of the selected codelists have not been loaded, and cannot be compared.", "Cannot compare", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		bool favouritesChanged = false;
		using (x9ae7778f2e265c77 x9ae7778f2e265c78 = new x9ae7778f2e265c77(codelistFile.Filename, codelistFile.x06ca69422bbb7502.x9425d7602dc80ff4, codelistFile2.Filename, codelistFile2.x06ca69422bbb7502.x9425d7602dc80ff4))
		{
			x9ae7778f2e265c78.x978f28482caa2f52 += delegate
			{
				favouritesChanged = true;
			};
			x9ae7778f2e265c78.ShowDialog(this);
		}
		if (favouritesChanged)
		{
			x5662a37e9c62e4ee();
		}
	}

	private void ExportActiveBtnFn(object sender, EventArgs e)
	{
		x2005f29ea96528c1.Filter = "Text files (*.txt)|*.txt|XML files (*.xml)|*.xml|HTML files (*.html)|*.html|MAX Codelist files (*.bin)|*.bin|All files (*.*)|*.*";
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(x50892314664b644e.Filename);
		x2005f29ea96528c1.Title = "Export Active Codelist (" + fileNameWithoutExtension + ")";
		x2005f29ea96528c1.FileName = fileNameWithoutExtension;
		if (x2005f29ea96528c1.ShowDialog(this) != DialogResult.OK)
		{
			return;
		}
		try
		{
			using MainWindow x0ad6e0a9d6b71dfc = MainWindow.CreateMessageBox(this, "Exporting codelist...");
			switch (x2005f29ea96528c1.FilterIndex)
			{
			case 1:
				x3b21e6c5d86aa690.xe0fbb350f1c86030(fileNameWithoutExtension, x50892314664b644e.x06ca69422bbb7502, x2005f29ea96528c1.FileName);
				break;
			case 2:
				x3b21e6c5d86aa690.xee53a77bb6ce3bd7(fileNameWithoutExtension, x50892314664b644e.x06ca69422bbb7502, x2005f29ea96528c1.FileName);
				break;
			case 3:
				x3b21e6c5d86aa690.x7d1fb3e819ed7b11(fileNameWithoutExtension, x50892314664b644e.x06ca69422bbb7502, x2005f29ea96528c1.FileName);
				break;
			case 4:
				x3b21e6c5d86aa690.x8db8994c865b7964(fileNameWithoutExtension, x50892314664b644e.x06ca69422bbb7502, x2005f29ea96528c1.FileName);
				break;
			default:
				x0ad6e0a9d6b71dfc.x5486e0b5e830d25c();
				MessageBox.Show(this, "Couldn't figure out which export format to use.  This is most likely an internal error; please report it to Mirality Systems.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "An error occurred while trying to export the codelist.\r\n\r\n" + ex.Message, "Export failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void x8b108b69e9a68ccd(object xe0292b9ed559da7d, CancelEventArgs xfbf34718e704c6bc)
	{
		if (x2005f29ea96528c1.FilterIndex <= 0 || x2005f29ea96528c1.FilterIndex > 4)
		{
			MessageBox.Show(this, "Please select a file type from the list (anything except All Files).\r\n\r\nMCM needs this information to determine what format you want to export the list as.", "Select Export Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
		}
	}

	protected override void OnPaintBackground(PaintEventArgs x6e8f4405e0958692)
	{
		base.OnPaintBackground(x6e8f4405e0958692);
		if (VisualStyleRenderer.IsSupported)
		{
			using (LinearGradientBrush brush = new LinearGradientBrush(base.ClientRectangle, SystemColors.Control, SystemColors.ControlLight, LinearGradientMode.ForwardDiagonal))
			{
				x6e8f4405e0958692.Graphics.FillRectangle(brush, base.ClientRectangle);
			}
		}
	}

	private void x5662a37e9c62e4ee()
	{
		xda8bb6fd239370b7.BeginUpdate();
		try
		{
			xda8bb6fd239370b7.Items.Clear();
			foreach (FavouriteGame favourite in CodeManagerSettings.Instance.Favourites)
			{
				ListViewItem listViewItem = new ListViewItem(new string[xda8bb6fd239370b7.Columns.Count]);
				listViewItem.SubItems[x5f68d5b5d2980b57.Index].Text = favourite.Name;
				listViewItem.SubItems[RegionColumnHeader.Index].Text = favourite.Region.ToString();
				listViewItem.Tag = favourite;
				GameEntry xa0380078f0b6cbb = ((x768b6665179efa05 == null) ? null : x768b6665179efa05.x45a46c637b44a527(favourite.GameId));
				if (xa0380078f0b6cbb == null)
				{
					listViewItem.ForeColor = Color.Red;
					listViewItem.SubItems[CodesColumnHeader.Index].Text = "0";
				}
				else
				{
					if (favourite.Region == RegionCode.Unknown)
					{
						favourite.Region = xa0380078f0b6cbb.Region;
					}
					listViewItem.SubItems[CodesColumnHeader.Index].Text = xa0380078f0b6cbb.xd44988f225497f3a.ToString(CultureInfo.CurrentCulture);
				}
				xda8bb6fd239370b7.Items.Add(listViewItem);
			}
		}
		finally
		{
			xda8bb6fd239370b7.EndUpdate();
		}
		x78487572c0ac6449();
	}

	private void x78487572c0ac6449()
	{
		using (MainWindow.CreateMessageBox(this, "Generating favourite codelist..."))
		{
			if (x768b6665179efa05 == null || x768b6665179efa05.x69e1830021be7f93 == 0)
			{
				xd710ac080d58c58d.x06ca69422bbb7502 = null;
				CodeListData = null;
				ExportFavsBtn.Enabled = false;
				return;
			}
			Codelist codelist = new Codelist();
			codelist.x77fa6322561797a0 = x768b6665179efa05.x77fa6322561797a0;
			foreach (FavouriteGame favourite in CodeManagerSettings.Instance.Favourites)
			{
				GameEntry xa0380078f0b6cbb = x768b6665179efa05.x45a46c637b44a527(favourite.GameId);
				if (xa0380078f0b6cbb != null)
				{
					codelist.xd6b6ed77479ef68c(xa0380078f0b6cbb);
				}
			}
			xd710ac080d58c58d.x06ca69422bbb7502 = codelist;
			CodeListData = codelist;
			ExportFavsBtn.Enabled = true;
		}
	}

	private void xddf2ff03bc0f8292(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (xda8bb6fd239370b7.SelectedItems.Count != 1 || x768b6665179efa05 == null || !(xda8bb6fd239370b7.SelectedItems[0].Tag is FavouriteGame favouriteGame))
		{
			return;
		}
		GameEntry xa0380078f0b6cbb = x768b6665179efa05.x45a46c637b44a527(favouriteGame.GameId);
		if (xa0380078f0b6cbb == null)
		{
			return;
		}
		using xfddbe928036d80d4 xfddbe928036d80d5 = new xfddbe928036d80d4(xa0380078f0b6cbb);
		bool favouritesChanged = false;
		xfddbe928036d80d5.x978f28482caa2f52 += delegate
		{
			favouritesChanged = true;
		};
		xfddbe928036d80d5.ShowDialog(this);
		if (favouritesChanged)
		{
			x5662a37e9c62e4ee();
		}
	}

	private void x63755db512d53357(object xe0292b9ed559da7d, KeyEventArgs xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.KeyData != Keys.Delete)
		{
			return;
		}
		xfbf34718e704c6bc.Handled = true;
		List<FavouriteGame> list = new List<FavouriteGame>();
		List<string> list2 = new List<string>();
		foreach (ListViewItem selectedItem in xda8bb6fd239370b7.SelectedItems)
		{
			if (selectedItem.Tag is FavouriteGame favouriteGame)
			{
				list.Add(favouriteGame);
				list2.Add(string.Concat(favouriteGame.Name, " (", favouriteGame.Region, ")"));
			}
		}
		if (list.Count < 1 || MessageBox.Show(this, "Are you sure you want to remove the following game(s) from your list of favourites?\r\n - " + string.Join("\r\n - ", list2.ToArray()), "Delete favourites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
		{
			return;
		}
		foreach (FavouriteGame item in list)
		{
			CodeManagerSettings.Instance.Favourites.Remove(item);
		}
		x5662a37e9c62e4ee();
	}

	private void ExportFavsBtnFn(object sender, EventArgs e)
	{
		if (CodeListData != null)
		{
			CodelistFunctionLibrary.ExportFavsToARMAX(this, CodeListData);
		}
	}

	private void x863eda1ee465de85(object sender, DragEventArgs e)
	{
		if ((e.AllowedEffect & DragDropEffects.Copy) == 0)
		{
			e.Effect = DragDropEffects.None;
		}
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
		else
		{
			e.Effect = DragDropEffects.None;
		}
	}

	private void xd63c7eedbe1f1ad2(object xe0292b9ed559da7d, DragEventArgs xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.Data.GetDataPresent(DataFormats.FileDrop) && xfbf34718e704c6bc.Effect == DragDropEffects.Copy)
		{
			string[] x499b08a184e = (string[])xfbf34718e704c6bc.Data.GetData(DataFormats.FileDrop);
			x3f4b45fa2073b695(x499b08a184e);
		}
		else
		{
			SystemSounds.Beep.Play();
		}
	}

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		if (xb41acd866d5cbca8 && xb7dfc13308b54974 != null)
		{
			xb7dfc13308b54974.Dispose();
		}
		base.Dispose(xb41acd866d5cbca8);
	}

	private void x85601834555fb7d5()
	{
		xb7dfc13308b54974 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(xf266856f631ec016));
		x645415d3d104f12c = new TableLayoutPanel();
		xec01cc607223b2a5 = new Label();
		xf1e74be3b0861edd = new GroupBox();
		x985c922c6fd8031c = new x97cc998483ae0218();
		x3cabd9709ac6c0f8 = new x97cc998483ae0218();
		xad90bf79a283dea6 = new x97cc998483ae0218();
		x2377a0ecadab130a = new Label();
		x9c2b9f5916527061 = new Label();
		x0b02574824d92cc7 = new Button();
		xb7a48894a0af41a5 = new Button();
		xb2f3dc67f47be862 = new Label();
		xa7513da32d6c65f9 = new Button();
		x84d02b28dabdd2b4 = new GroupBox();
		xa06a52b1869d241d = new x3ccd15e4a951572e();
		x6faa1d7ea341a63b = new TableLayoutPanel();
		xdb68d5db35f39c3b = new xef58b78651bbbe4e();
		x5a428ce3753ad1d1 = new ColumnHeader();
		x4f9e88a7f60520ba = new ColumnHeader();
		AddCodeListBtn = new Button();
		RemoveCodeListBtn = new Button();
		NewCodeListBtn = new Button();
		MakeActiveBtn = new Button();
		MoveUpBtn = new Button();
		MoveDownBtn = new Button();
		CompareCodeListsBtn = new Button();
		ViewCodeListBtn = new Button();
		x9be4e52c9a35b583 = new Label();
		x7662eb616ef3d51d = new Panel();
		x7c1870c66bed243f = new GroupBox();
		xda8bb6fd239370b7 = new ListView();
		x5f68d5b5d2980b57 = new ColumnHeader();
		RegionColumnHeader = new ColumnHeader();
		CodesColumnHeader = new ColumnHeader();
		ExportFavsBtn = new Button();
		xd710ac080d58c58d = new x3ccd15e4a951572e();
		xb13e3492976e6435 = new GroupBox();
		x0f289e063dca8ffa = new x3ccd15e4a951572e();
		ViewCombinedBtn = new Button();
		x1c4e58c064fe01db = new Panel();
		SettingsBtn = new Button();
		CodeJunkiesLinkLabel = new LinkLabel();
		MiralityLinkLabel = new LinkLabel();
		x31b6f3a354074bae = new Label();
		x33a6dcc90c5f6721 = new Label();
		xd514546ab3c9516d = new GroupBox();
		ExportActiveBtn = new Button();
		ViewActiveBtn = new Button();
		x7468a31bcc5ded5a = new Label();
		x7702318dbc4bbe4b = new Label();
		x75cfc97b61818036 = new x3ccd15e4a951572e();
		x7bcd86e0772d838f = new ImageList(xb7dfc13308b54974);
		x1d8fb7d81af42349 = new OpenFileDialog();
		xc21543d0206190f3 = new SaveFileDialog();
		xc4c34e75b01b4519 = new ToolTip(xb7dfc13308b54974);
		x2005f29ea96528c1 = new SaveFileDialog();
		xb2f83dca3a2248d7 = new Timer(xb7dfc13308b54974);
		x0626bb430c72c389 = new Timer(xb7dfc13308b54974);
		Label label = new Label();
		x645415d3d104f12c.SuspendLayout();
		xf1e74be3b0861edd.SuspendLayout();
		x84d02b28dabdd2b4.SuspendLayout();
		x6faa1d7ea341a63b.SuspendLayout();
		x7662eb616ef3d51d.SuspendLayout();
		x7c1870c66bed243f.SuspendLayout();
		xb13e3492976e6435.SuspendLayout();
		x1c4e58c064fe01db.SuspendLayout();
		xd514546ab3c9516d.SuspendLayout();
		SuspendLayout();
		label.Location = new Point(6, 17);
		label.Name = "labelActiveNameCaption";
		label.Size = new Size(53, 19);
		label.TabIndex = 1;
		label.Text = "Name:";
		label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		x645415d3d104f12c.BackColor = Color.Transparent;
		x645415d3d104f12c.ColumnCount = 2;
		x645415d3d104f12c.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		x645415d3d104f12c.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		x645415d3d104f12c.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		x645415d3d104f12c.Controls.Add(xec01cc607223b2a5, 0, 3);
		x645415d3d104f12c.Controls.Add(xf1e74be3b0861edd, 0, 0);
		x645415d3d104f12c.Controls.Add(x84d02b28dabdd2b4, 0, 2);
		x645415d3d104f12c.Controls.Add(x7662eb616ef3d51d, 1, 2);
		x645415d3d104f12c.Controls.Add(xd514546ab3c9516d, 0, 1);
		x645415d3d104f12c.Dock = DockStyle.Fill;
		x645415d3d104f12c.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
		x645415d3d104f12c.Location = new Point(4, 4);
		x645415d3d104f12c.Name = "tableLayoutPanelMain";
		x645415d3d104f12c.RowCount = 4;
		x645415d3d104f12c.RowStyles.Add(new RowStyle(SizeType.Absolute, 128f));
		x645415d3d104f12c.RowStyles.Add(new RowStyle(SizeType.Absolute, 76f));
		x645415d3d104f12c.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		x645415d3d104f12c.RowStyles.Add(new RowStyle(SizeType.Absolute, 41f));
		x645415d3d104f12c.Size = new Size(654, 678);
		x645415d3d104f12c.TabIndex = 0;
		x645415d3d104f12c.SetColumnSpan(xec01cc607223b2a5, 2);
		xec01cc607223b2a5.Dock = DockStyle.Fill;
		xec01cc607223b2a5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		xec01cc607223b2a5.Location = new Point(3, 637);
		xec01cc607223b2a5.Name = "labelDisclaimer";
		xec01cc607223b2a5.Size = new Size(648, 41);
		xec01cc607223b2a5.TabIndex = 5;
		xec01cc607223b2a5.Text = componentResourceManager.GetString("labelDisclaimer.Text");
		xec01cc607223b2a5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		x645415d3d104f12c.SetColumnSpan(xf1e74be3b0861edd, 2);
		xf1e74be3b0861edd.Controls.Add(x985c922c6fd8031c);
		xf1e74be3b0861edd.Controls.Add(x3cabd9709ac6c0f8);
		xf1e74be3b0861edd.Controls.Add(xad90bf79a283dea6);
		xf1e74be3b0861edd.Controls.Add(x2377a0ecadab130a);
		xf1e74be3b0861edd.Controls.Add(x9c2b9f5916527061);
		xf1e74be3b0861edd.Controls.Add(x0b02574824d92cc7);
		xf1e74be3b0861edd.Controls.Add(xb7a48894a0af41a5);
		xf1e74be3b0861edd.Controls.Add(xb2f3dc67f47be862);
		xf1e74be3b0861edd.Controls.Add(xa7513da32d6c65f9);
		xf1e74be3b0861edd.Dock = DockStyle.Fill;
		xf1e74be3b0861edd.Location = new Point(3, 3);
		xf1e74be3b0861edd.Name = "groupBoxOfficial";
		xf1e74be3b0861edd.Size = new Size(648, 122);
		xf1e74be3b0861edd.TabIndex = 0;
		xf1e74be3b0861edd.TabStop = false;
		xf1e74be3b0861edd.Text = "Official Codelists";
		x985c922c6fd8031c.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x985c922c6fd8031c.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x985c922c6fd8031c.Location = new Point(90, 86);
		x985c922c6fd8031c.Name = "codelistInfoInternet";
		x985c922c6fd8031c.Size = new Size(430, 32);
		x985c922c6fd8031c.TabIndex = 7;
		x3cabd9709ac6c0f8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x3cabd9709ac6c0f8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x3cabd9709ac6c0f8.Location = new Point(90, 52);
		x3cabd9709ac6c0f8.Name = "codelistInfoPrevious";
		x3cabd9709ac6c0f8.Size = new Size(430, 32);
		x3cabd9709ac6c0f8.TabIndex = 4;
		xad90bf79a283dea6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xad90bf79a283dea6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xad90bf79a283dea6.Location = new Point(90, 18);
		xad90bf79a283dea6.Name = "codelistInfoOriginal";
		xad90bf79a283dea6.Size = new Size(430, 32);
		xad90bf79a283dea6.TabIndex = 1;
		x2377a0ecadab130a.AutoSize = true;
		x2377a0ecadab130a.Location = new Point(6, 60);
		x2377a0ecadab130a.Name = "labelPreviousCaption";
		x2377a0ecadab130a.Size = new Size(83, 16);
		x2377a0ecadab130a.TabIndex = 3;
		x2377a0ecadab130a.Text = "Previous list:";
		x9c2b9f5916527061.AutoSize = true;
		x9c2b9f5916527061.Location = new Point(6, 94);
		x9c2b9f5916527061.Name = "labelInternetCaption";
		x9c2b9f5916527061.Size = new Size(88, 16);
		x9c2b9f5916527061.TabIndex = 6;
		x9c2b9f5916527061.Text = "From Internet:";
		x0b02574824d92cc7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x0b02574824d92cc7.Location = new Point(522, 91);
		x0b02574824d92cc7.Name = "buttonViewMaster";
		x0b02574824d92cc7.Size = new Size(120, 23);
		x0b02574824d92cc7.TabIndex = 8;
		x0b02574824d92cc7.Text = "View...";
		x0b02574824d92cc7.UseVisualStyleBackColor = true;
		x0b02574824d92cc7.Click += ViewAllCodesBtnFn;
		xb7a48894a0af41a5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		xb7a48894a0af41a5.Location = new Point(522, 57);
		xb7a48894a0af41a5.Name = "buttonWhatsNew";
		xb7a48894a0af41a5.Size = new Size(120, 23);
		xb7a48894a0af41a5.TabIndex = 5;
		xb7a48894a0af41a5.Text = "What's New?";
		xb7a48894a0af41a5.UseVisualStyleBackColor = true;
		xb7a48894a0af41a5.Click += WhatsNewBtnFn;
		xb2f3dc67f47be862.AutoSize = true;
		xb2f3dc67f47be862.Location = new Point(6, 26);
		xb2f3dc67f47be862.Name = "labelCDCaption";
		xb2f3dc67f47be862.Size = new Size(64, 16);
		xb2f3dc67f47be862.TabIndex = 0;
		xb2f3dc67f47be862.Text = "From CD:";
		xa7513da32d6c65f9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		xa7513da32d6c65f9.Location = new Point(522, 23);
		xa7513da32d6c65f9.Name = "buttonDownload";
		xa7513da32d6c65f9.Size = new Size(120, 23);
		xa7513da32d6c65f9.TabIndex = 2;
		xa7513da32d6c65f9.Text = "Download...";
		xa7513da32d6c65f9.UseVisualStyleBackColor = true;
		xa7513da32d6c65f9.Click += DownloadBtnFn;
		x84d02b28dabdd2b4.Controls.Add(xa06a52b1869d241d);
		x84d02b28dabdd2b4.Controls.Add(x6faa1d7ea341a63b);
		x84d02b28dabdd2b4.Dock = DockStyle.Fill;
		x84d02b28dabdd2b4.Location = new Point(3, 207);
		x84d02b28dabdd2b4.Name = "groupBoxOther";
		x84d02b28dabdd2b4.Size = new Size(321, 427);
		x84d02b28dabdd2b4.TabIndex = 2;
		x84d02b28dabdd2b4.TabStop = false;
		x84d02b28dabdd2b4.Text = "Other Codelists";
		xa06a52b1869d241d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xa06a52b1869d241d.Font = new Font("Microsoft Sans Serif", 8.25f);
		xa06a52b1869d241d.Location = new Point(3, 18);
		xa06a52b1869d241d.Name = "codelistInfoOther";
		xa06a52b1869d241d.Size = new Size(315, 24);
		xa06a52b1869d241d.TabIndex = 0;
		x6faa1d7ea341a63b.ColumnCount = 2;
		x6faa1d7ea341a63b.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		x6faa1d7ea341a63b.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		x6faa1d7ea341a63b.Controls.Add(xdb68d5db35f39c3b, 0, 0);
		x6faa1d7ea341a63b.Controls.Add(AddCodeListBtn, 0, 4);
		x6faa1d7ea341a63b.Controls.Add(RemoveCodeListBtn, 1, 4);
		x6faa1d7ea341a63b.Controls.Add(NewCodeListBtn, 0, 5);
		x6faa1d7ea341a63b.Controls.Add(MakeActiveBtn, 1, 5);
		x6faa1d7ea341a63b.Controls.Add(MoveUpBtn, 0, 2);
		x6faa1d7ea341a63b.Controls.Add(MoveDownBtn, 1, 2);
		x6faa1d7ea341a63b.Controls.Add(CompareCodeListsBtn, 1, 3);
		x6faa1d7ea341a63b.Controls.Add(ViewCodeListBtn, 0, 3);
		x6faa1d7ea341a63b.Controls.Add(x9be4e52c9a35b583, 0, 1);
		x6faa1d7ea341a63b.Location = new Point(3, 50);
		x6faa1d7ea341a63b.Name = "tableLayoutPanelCodelists";
		x6faa1d7ea341a63b.RowCount = 6;
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
		x6faa1d7ea341a63b.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		x6faa1d7ea341a63b.Size = new Size(315, 374);
		x6faa1d7ea341a63b.TabIndex = 0;
		xdb68d5db35f39c3b.AllowDrop = true;
		xdb68d5db35f39c3b.Columns.AddRange(new ColumnHeader[2] { x5a428ce3753ad1d1, x4f9e88a7f60520ba });
		x6faa1d7ea341a63b.SetColumnSpan(xdb68d5db35f39c3b, 2);
		xdb68d5db35f39c3b.Dock = DockStyle.Fill;
		xdb68d5db35f39c3b.FullRowSelect = true;
		xdb68d5db35f39c3b.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		xdb68d5db35f39c3b.HideSelection = false;
		xdb68d5db35f39c3b.Location = new Point(3, 3);
		xdb68d5db35f39c3b.Name = "listViewCodelists";
		xdb68d5db35f39c3b.ShowItemToolTips = true;
		xdb68d5db35f39c3b.Size = new Size(309, 220);
		xdb68d5db35f39c3b.TabIndex = 0;
		xdb68d5db35f39c3b.UseCompatibleStateImageBehavior = false;
        xdb68d5db35f39c3b.View = System.Windows.Forms.View.Details;
		xdb68d5db35f39c3b.ItemActivate += x05d68e95df241fd3;
		xdb68d5db35f39c3b.ClientSizeChanged += x267b27bc4addcd6d;
		xdb68d5db35f39c3b.ItemChecked += xbbd29bd1d5a360f1;
		xdb68d5db35f39c3b.SelectedIndexChanged += x761d57200285bc56;
		xdb68d5db35f39c3b.DragDrop += xd63c7eedbe1f1ad2;
		xdb68d5db35f39c3b.DragOver += x863eda1ee465de85;
		x5a428ce3753ad1d1.Text = "Name";
		x5a428ce3753ad1d1.Width = 229;
		x4f9e88a7f60520ba.Text = "Games";
		AddCodeListBtn.Dock = DockStyle.Fill;
		AddCodeListBtn.Location = new Point(3, 313);
		AddCodeListBtn.Name = "buttonAddCodelist";
		AddCodeListBtn.Size = new Size(151, 26);
		AddCodeListBtn.TabIndex = 5;
		AddCodeListBtn.Text = "Add...";
		AddCodeListBtn.UseVisualStyleBackColor = true;
		AddCodeListBtn.Click += AddBtnFn;
		RemoveCodeListBtn.Dock = DockStyle.Fill;
		RemoveCodeListBtn.Location = new Point(160, 313);
		RemoveCodeListBtn.Name = "buttonRemoveCodelist";
		RemoveCodeListBtn.Size = new Size(152, 26);
		RemoveCodeListBtn.TabIndex = 6;
		RemoveCodeListBtn.Text = "Remove";
		RemoveCodeListBtn.UseVisualStyleBackColor = true;
		RemoveCodeListBtn.Click += RemoveBtnFn;
		NewCodeListBtn.Dock = DockStyle.Fill;
		NewCodeListBtn.Location = new Point(3, 345);
		NewCodeListBtn.Name = "buttonNewCodelist";
		NewCodeListBtn.Size = new Size(151, 26);
		NewCodeListBtn.TabIndex = 7;
		NewCodeListBtn.Text = "New...";
		NewCodeListBtn.UseVisualStyleBackColor = true;
		NewCodeListBtn.Click += NewCodeListBtnFn;
		MakeActiveBtn.Dock = DockStyle.Fill;
		MakeActiveBtn.Location = new Point(160, 345);
		MakeActiveBtn.Name = "buttonMakeActive";
		MakeActiveBtn.Size = new Size(152, 26);
		MakeActiveBtn.TabIndex = 8;
		MakeActiveBtn.Text = "Make Active";
		MakeActiveBtn.UseVisualStyleBackColor = true;
		MakeActiveBtn.Click += MakeActiveBtnFn;
		MoveUpBtn.Dock = DockStyle.Fill;
		MoveUpBtn.Location = new Point(3, 249);
		MoveUpBtn.Name = "buttonMoveUp";
		MoveUpBtn.Size = new Size(151, 26);
		MoveUpBtn.TabIndex = 2;
		MoveUpBtn.Text = "Move Up";
		MoveUpBtn.UseVisualStyleBackColor = true;
		MoveUpBtn.Click += MoveUpBtnFn;
		MoveDownBtn.Dock = DockStyle.Fill;
		MoveDownBtn.Location = new Point(160, 249);
		MoveDownBtn.Name = "buttonMoveDown";
		MoveDownBtn.Size = new Size(152, 26);
		MoveDownBtn.TabIndex = 3;
		MoveDownBtn.Text = "Move Down";
		MoveDownBtn.UseVisualStyleBackColor = true;
		MoveDownBtn.Click += MoveDownBtnFn;
		CompareCodeListsBtn.Dock = DockStyle.Fill;
		CompareCodeListsBtn.Location = new Point(160, 281);
		CompareCodeListsBtn.Name = "buttonCompareCodelists";
		CompareCodeListsBtn.Size = new Size(152, 26);
		CompareCodeListsBtn.TabIndex = 4;
		CompareCodeListsBtn.Text = "Compare...";
		CompareCodeListsBtn.UseVisualStyleBackColor = true;
		CompareCodeListsBtn.Click += CompareCodeListsBtnFn;
		ViewCodeListBtn.Dock = DockStyle.Fill;
		ViewCodeListBtn.Location = new Point(3, 281);
		ViewCodeListBtn.Name = "buttonViewCodelist";
		ViewCodeListBtn.Size = new Size(151, 26);
		ViewCodeListBtn.TabIndex = 3;
		ViewCodeListBtn.Text = "View...";
		ViewCodeListBtn.UseVisualStyleBackColor = true;
		ViewCodeListBtn.Click += ViewCodeListBtnFn;
		x6faa1d7ea341a63b.SetColumnSpan(x9be4e52c9a35b583, 2);
		x9be4e52c9a35b583.Dock = DockStyle.Fill;
		x9be4e52c9a35b583.Location = new Point(3, 226);
		x9be4e52c9a35b583.Name = "labelOtherInfo";
		x9be4e52c9a35b583.Size = new Size(309, 20);
		x9be4e52c9a35b583.TabIndex = 1;
		x9be4e52c9a35b583.Text = "Codes from lists at the top have higher priority.";
		x9be4e52c9a35b583.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		x7662eb616ef3d51d.Controls.Add(x7c1870c66bed243f);
		x7662eb616ef3d51d.Controls.Add(xb13e3492976e6435);
		x7662eb616ef3d51d.Controls.Add(x1c4e58c064fe01db);
		x7662eb616ef3d51d.Dock = DockStyle.Fill;
		x7662eb616ef3d51d.Location = new Point(330, 207);
		x7662eb616ef3d51d.Name = "panelCombinedAndLogo";
		x7662eb616ef3d51d.Size = new Size(321, 427);
		x7662eb616ef3d51d.TabIndex = 6;
		x7c1870c66bed243f.Controls.Add(xda8bb6fd239370b7);
		x7c1870c66bed243f.Controls.Add(ExportFavsBtn);
		x7c1870c66bed243f.Controls.Add(xd710ac080d58c58d);
		x7c1870c66bed243f.Dock = DockStyle.Fill;
		x7c1870c66bed243f.Location = new Point(0, 79);
		x7c1870c66bed243f.Name = "groupBoxUser";
		x7c1870c66bed243f.Size = new Size(321, 254);
		x7c1870c66bed243f.TabIndex = 4;
		x7c1870c66bed243f.TabStop = false;
		x7c1870c66bed243f.Text = "Your Favourites";
		xda8bb6fd239370b7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xda8bb6fd239370b7.Columns.AddRange(new ColumnHeader[3] { x5f68d5b5d2980b57, RegionColumnHeader, CodesColumnHeader });
		xda8bb6fd239370b7.FullRowSelect = true;
		xda8bb6fd239370b7.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		xda8bb6fd239370b7.HideSelection = false;
		xda8bb6fd239370b7.Location = new Point(6, 21);
		xda8bb6fd239370b7.Name = "listViewFavourites";
		xda8bb6fd239370b7.ShowItemToolTips = true;
		xda8bb6fd239370b7.Size = new Size(306, 173);
		xda8bb6fd239370b7.TabIndex = 1;
		xda8bb6fd239370b7.UseCompatibleStateImageBehavior = false;
        xda8bb6fd239370b7.View = System.Windows.Forms.View.Details;
		xda8bb6fd239370b7.ItemActivate += xddf2ff03bc0f8292;
		xda8bb6fd239370b7.ClientSizeChanged += x1aaf83a875993cfd;
		xda8bb6fd239370b7.KeyDown += x63755db512d53357;
		x5f68d5b5d2980b57.Text = "Name";
		x5f68d5b5d2980b57.Width = 181;
		RegionColumnHeader.Text = "Region";
		CodesColumnHeader.Text = "Codes";
		ExportFavsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ExportFavsBtn.Location = new Point(6, 222);
		ExportFavsBtn.Name = "buttonExportUser";
		ExportFavsBtn.Size = new Size(306, 23);
		ExportFavsBtn.TabIndex = 1;
		ExportFavsBtn.Text = "Export favourites to ARMAX";
		ExportFavsBtn.UseVisualStyleBackColor = true;
		ExportFavsBtn.Click += ExportFavsBtnFn;
		xd710ac080d58c58d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xd710ac080d58c58d.Font = new Font("Microsoft Sans Serif", 8.25f);
		xd710ac080d58c58d.Location = new Point(6, 194);
		xd710ac080d58c58d.Name = "codelistInfoUser";
		xd710ac080d58c58d.Size = new Size(306, 24);
		xd710ac080d58c58d.TabIndex = 0;
		xb13e3492976e6435.Controls.Add(x0f289e063dca8ffa);
		xb13e3492976e6435.Controls.Add(ViewCombinedBtn);
		xb13e3492976e6435.Dock = DockStyle.Top;
		xb13e3492976e6435.Location = new Point(0, 0);
		xb13e3492976e6435.Name = "groupBoxCombined";
		xb13e3492976e6435.Size = new Size(321, 79);
		xb13e3492976e6435.TabIndex = 5;
		xb13e3492976e6435.TabStop = false;
		xb13e3492976e6435.Text = "Combined List";
		x0f289e063dca8ffa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x0f289e063dca8ffa.Font = new Font("Microsoft Sans Serif", 8.25f);
		x0f289e063dca8ffa.Location = new Point(6, 18);
		x0f289e063dca8ffa.Name = "codelistInfoCombined";
		x0f289e063dca8ffa.Size = new Size(306, 24);
		x0f289e063dca8ffa.TabIndex = 0;
		ViewCombinedBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ViewCombinedBtn.Location = new Point(6, 50);
		ViewCombinedBtn.Name = "buttonViewCombined";
		ViewCombinedBtn.Size = new Size(306, 23);
		ViewCombinedBtn.TabIndex = 1;
		ViewCombinedBtn.Text = "View full combined codelist...";
		ViewCombinedBtn.UseVisualStyleBackColor = true;
		ViewCombinedBtn.Click += ViewCombinedBtnFn;
		x1c4e58c064fe01db.Controls.Add(SettingsBtn);
		x1c4e58c064fe01db.Controls.Add(CodeJunkiesLinkLabel);
		x1c4e58c064fe01db.Controls.Add(MiralityLinkLabel);
		x1c4e58c064fe01db.Controls.Add(x31b6f3a354074bae);
		x1c4e58c064fe01db.Controls.Add(x33a6dcc90c5f6721);
		x1c4e58c064fe01db.Dock = DockStyle.Bottom;
		x1c4e58c064fe01db.Location = new Point(0, 333);
		x1c4e58c064fe01db.Name = "panelBanner";
		x1c4e58c064fe01db.Size = new Size(321, 94);
		x1c4e58c064fe01db.TabIndex = 1;
		SettingsBtn.Anchor = AnchorStyles.Top;
		SettingsBtn.Location = new Point(94, 48);
		SettingsBtn.Name = "buttonSettings";
		SettingsBtn.Size = new Size(133, 25);
		SettingsBtn.TabIndex = 3;
		SettingsBtn.Text = "Settings";
		SettingsBtn.UseVisualStyleBackColor = true;
		SettingsBtn.Click += SettingsBtnFn;
		CodeJunkiesLinkLabel.Anchor = AnchorStyles.Bottom;
		CodeJunkiesLinkLabel.AutoSize = true;
		CodeJunkiesLinkLabel.Location = new Point(62, 72);
		CodeJunkiesLinkLabel.Name = "linkLabelCodeJunkies";
		CodeJunkiesLinkLabel.Size = new Size(197, 16);
		CodeJunkiesLinkLabel.TabIndex = 4;
		CodeJunkiesLinkLabel.TabStop = true;
		CodeJunkiesLinkLabel.Text = "Datel's official CodeJunkies site";
		CodeJunkiesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CodeJunkiesLinkLabel.LinkClicked += OpenLinkBtnFn;
		MiralityLinkLabel.Anchor = AnchorStyles.Top;
		MiralityLinkLabel.AutoSize = true;
		MiralityLinkLabel.Location = new Point(108, 5);
		MiralityLinkLabel.Name = "linkLabelMirality";
		MiralityLinkLabel.Size = new Size(105, 16);
		MiralityLinkLabel.TabIndex = 4;
		MiralityLinkLabel.TabStop = true;
		MiralityLinkLabel.Text = "Mirality Systems";
		MiralityLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		MiralityLinkLabel.LinkClicked += OpenLinkBtnFn;
		x31b6f3a354074bae.Anchor = AnchorStyles.Top;
		x31b6f3a354074bae.Location = new Point(242, 5);
		x31b6f3a354074bae.Name = "labelVersion";
		x31b6f3a354074bae.Size = new Size(60, 16);
		x31b6f3a354074bae.TabIndex = 1;
		x31b6f3a354074bae.Text = "(version)";
		x31b6f3a354074bae.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		x33a6dcc90c5f6721.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x33a6dcc90c5f6721.Font = new Font("Impact", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x33a6dcc90c5f6721.Location = new Point(2, 17);
		x33a6dcc90c5f6721.Name = "labelBanner";
		x33a6dcc90c5f6721.Size = new Size(317, 36);
		x33a6dcc90c5f6721.TabIndex = 2;
		x33a6dcc90c5f6721.Text = "MAX Codelist Manager v2";
		x33a6dcc90c5f6721.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		x645415d3d104f12c.SetColumnSpan(xd514546ab3c9516d, 2);
		xd514546ab3c9516d.Controls.Add(ExportActiveBtn);
		xd514546ab3c9516d.Controls.Add(ViewActiveBtn);
		xd514546ab3c9516d.Controls.Add(x7468a31bcc5ded5a);
		xd514546ab3c9516d.Controls.Add(x7702318dbc4bbe4b);
		xd514546ab3c9516d.Controls.Add(label);
		xd514546ab3c9516d.Controls.Add(x75cfc97b61818036);
		xd514546ab3c9516d.Dock = DockStyle.Fill;
		xd514546ab3c9516d.Location = new Point(3, 131);
		xd514546ab3c9516d.Name = "groupBoxActiveList";
		xd514546ab3c9516d.Size = new Size(648, 70);
		xd514546ab3c9516d.TabIndex = 7;
		xd514546ab3c9516d.TabStop = false;
		xd514546ab3c9516d.Text = "Active List";
		ExportActiveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ExportActiveBtn.Location = new Point(522, 40);
		ExportActiveBtn.Name = "buttonExportActive";
		ExportActiveBtn.Size = new Size(120, 23);
		ExportActiveBtn.TabIndex = 1;
		ExportActiveBtn.Text = "Export...";
		ExportActiveBtn.UseVisualStyleBackColor = true;
		ExportActiveBtn.Click += ExportActiveBtnFn;
		ViewActiveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ViewActiveBtn.Location = new Point(522, 15);
		ViewActiveBtn.Name = "buttonViewActive";
		ViewActiveBtn.Size = new Size(120, 23);
		ViewActiveBtn.TabIndex = 1;
		ViewActiveBtn.Text = "View...";
		ViewActiveBtn.UseVisualStyleBackColor = true;
		ViewActiveBtn.Click += ViewActiveBtnFn;
		x7468a31bcc5ded5a.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x7468a31bcc5ded5a.Location = new Point(57, 17);
		x7468a31bcc5ded5a.Name = "labelActiveName";
		x7468a31bcc5ded5a.Size = new Size(163, 19);
		x7468a31bcc5ded5a.TabIndex = 1;
		x7468a31bcc5ded5a.Text = "(name)";
		x7468a31bcc5ded5a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		x7702318dbc4bbe4b.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x7702318dbc4bbe4b.AutoEllipsis = true;
		x7702318dbc4bbe4b.Location = new Point(6, 42);
		x7702318dbc4bbe4b.Name = "labelActiveFilename";
		x7702318dbc4bbe4b.Size = new Size(509, 19);
		x7702318dbc4bbe4b.TabIndex = 2;
		x7702318dbc4bbe4b.Text = "(filename)";
		x75cfc97b61818036.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x75cfc97b61818036.Font = new Font("Microsoft Sans Serif", 8.25f);
		x75cfc97b61818036.Location = new Point(226, 17);
		x75cfc97b61818036.Name = "codelistInfoActive";
		x75cfc97b61818036.Size = new Size(290, 19);
		x75cfc97b61818036.TabIndex = 0;
		x7bcd86e0772d838f.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
		x7bcd86e0772d838f.TransparentColor = Color.Transparent;
		x7bcd86e0772d838f.Images.SetKeyName(0, "RadioCode.ico");
		x7bcd86e0772d838f.Images.SetKeyName(1, "RadioOpenFolder.ico");
		x7bcd86e0772d838f.Images.SetKeyName(2, "UnknownCode.ico");
		x1d8fb7d81af42349.DefaultExt = "mcmcode";
		x1d8fb7d81af42349.Multiselect = true;
		x1d8fb7d81af42349.Title = "Select the codelist(s) to add";
		xc21543d0206190f3.DefaultExt = "mcmcode";
		xc21543d0206190f3.Filter = "MCM Codelist (*.mcmcode)|*.mcmcode|All files (*.*)|*.*";
		xc21543d0206190f3.Title = "Specify where you want to save the new codelist file";
		x2005f29ea96528c1.DefaultExt = "txt";
		x2005f29ea96528c1.FileOk += x8b108b69e9a68ccd;
		xb2f83dca3a2248d7.Interval = 1000;
		xb2f83dca3a2248d7.Tick += x361f2cc1e9b948a0;
		x0626bb430c72c389.Interval = 1000;
		x0626bb430c72c389.Tick += xd9e6c62b87227770;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(662, 686);
		base.Controls.Add(x645415d3d104f12c);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		MinimumSize = new Size(670, 720);
		base.Name = "MainForm";
		base.Padding = new Padding(4);
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "MAX Codelist Manager";
		x645415d3d104f12c.ResumeLayout(performLayout: false);
		xf1e74be3b0861edd.ResumeLayout(performLayout: false);
		xf1e74be3b0861edd.PerformLayout();
		x84d02b28dabdd2b4.ResumeLayout(performLayout: false);
		x6faa1d7ea341a63b.ResumeLayout(performLayout: false);
		x7662eb616ef3d51d.ResumeLayout(performLayout: false);
		x7c1870c66bed243f.ResumeLayout(performLayout: false);
		xb13e3492976e6435.ResumeLayout(performLayout: false);
		x1c4e58c064fe01db.ResumeLayout(performLayout: false);
		x1c4e58c064fe01db.PerformLayout();
		xd514546ab3c9516d.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
