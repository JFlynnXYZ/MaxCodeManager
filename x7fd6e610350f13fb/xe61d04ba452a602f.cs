using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using x3a260771fe762331;
using xca7bfd2e2e8437c4;

namespace x7fd6e610350f13fb;

public static class xe61d04ba452a602f
{
	private const string xa062a601a9c3c2aa = "Import codelist from original CD";

	public static bool xeb24bb06e5c302f8(Form Form)
	{
		string[] array = xf89ffa2d75dd08c6.x15ed2829418ba79b(xe3b13379c7058411: false);
		if (array.Length == 0)
		{
			MessageBox.Show(Form, "Unable to detect any CD-ROM drives attached to your computer.  You will not be able to use this function without a CD-ROM drive.", "Import codelist from original CD", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		if (!xeffa8bf1dba48dda(Form, array))
		{
			return false;
		}
		string text = x2be66d07e8c032ce(Form, array);
		if (text == null)
		{
			MessageBox.Show(Form, "Unable to locate Action Replay MAX CD.  Either you forgot to insert it, didn't allow enough time for it to spin up, or you have an unrecognised version of AR MAX.\r\n\r\nIf it is the latter, please leave some Feedback at the Mirality Systems website and we'll contact you regarding supporting your version in a later release.", "Import codelist from original CD", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		Directory.CreateDirectory(Path.GetDirectoryName(x77dccad1db69a78f.x93bd97d3afddf842));
		bool flag = x7e6266fd418decf0(Form, text, "PAL", "EU_CODELIST.BIN", x77dccad1db69a78f.x93bd97d3afddf842);
		bool flag2 = x7e6266fd418decf0(Form, text, "NTSC", "US_CODELIST.BIN", x77dccad1db69a78f.x411b38a624544322);
		if (flag && flag2)
		{
			MessageBox.Show(Form, "Import successful.", "Import codelist from original CD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else if (flag)
		{
			x576c0fe41010e277(Form, "PAL", "NTSC");
		}
		else
		{
			if (!flag2)
			{
				MessageBox.Show(Form, "The codelists could not be imported.  Either your CD contains invalid codelists (or is otherwise unreadable), or they were not named as expected.\r\n\r\nIf you are sure your CD is good, then please send some Feedback at the Mirality Systems website so that we can try to sort it out.", "Import codelist from original CD", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			x576c0fe41010e277(Form, "NTSC", "PAL");
		}
		return true;
	}

	private static bool xeffa8bf1dba48dda(Form Form, string[] x82c915295d3c0ebf)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string value in x82c915295d3c0ebf)
		{
			stringBuilder.Append(", ");
			stringBuilder.Append(value);
		}
		stringBuilder.Remove(0, 2);
		stringBuilder.Insert(0, "Please insert your original Action Replay MAX CD into any CD-ROM (or DVD-ROM) drive in your computer.\r\n\r\nAllow a few seconds for it to spin up before clicking OK.\r\n\r\nDetected drives: ");
		return MessageBox.Show(Form, stringBuilder.ToString(), "Import codelist from original CD", MessageBoxButtons.OKCancel) == DialogResult.OK;
	}

	private static string x2be66d07e8c032ce(Form Form, string[] x82c915295d3c0ebf)
	{
		using (MainWindow.CreateMessageBox(Form, "Looking for Action Reply MAX CD..."))
		{
			foreach (string path in x82c915295d3c0ebf)
			{
				string text = Path.Combine(path, "RES\\CODELIST");
				if (Directory.Exists(text))
				{
					return text;
				}
			}
			return null;
		}
	}

	private static void x576c0fe41010e277(Form Form, string xffe1ae747f88a4e6, string x148339b4d956d747)
	{
		MessageBox.Show(Form, string.Format(CultureInfo.InvariantCulture, "The {0} codelist was imported successfully.  However, the {1} codelist was not.  Either your CD contains an invalid codelist, or they were not named as expected.\r\n\r\nIf you wish to use the {1} codelist, then please send some Feedback at the Mirality Systems website so that we can try to sort it out.  If you only use {0}, then there's no need to worry about this.", xffe1ae747f88a4e6, x148339b4d956d747), "Import codelist from original CD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private static bool x7e6266fd418decf0(Form Form, string x8ce0629ba2384818, string x1f38a4025689d317, string x49965cb749d9d331, string x45f092f4a84cb8d3)
	{
		using (MainWindow.CreateMessageBox(Form, "Importing " + x1f38a4025689d317 + " codelist..."))
		{
			string text = Path.Combine(x8ce0629ba2384818, x49965cb749d9d331);
			if (!File.Exists(text))
			{
				return false;
			}
			try
			{
				Codelist.x5d95f5f98c940295(text);
				File.Copy(text, x45f092f4a84cb8d3, overwrite: true);
				File.SetAttributes(x45f092f4a84cb8d3, FileAttributes.Archive);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
