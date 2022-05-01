using System;
using System.IO;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using x3a260771fe762331;
using xca7bfd2e2e8437c4;

namespace x7fd6e610350f13fb;

public static class xa7a034bfe24cb1a9
{
	public static void x6bf418b1d79a537d(Form xa6607dfd4b3038ad, x33636090f73cdcbf x8a0b266419f09a55)
	{
		if (xa6607dfd4b3038ad == null)
		{
			throw new ArgumentNullException("form");
		}
		if (x8a0b266419f09a55 == null)
		{
			throw new ArgumentNullException("list");
		}
		xa6607dfd4b3038ad.Cursor = Cursors.WaitCursor;
		try
		{
			using MainWindow x346ddb85fad09a = MainWindow.xebcf83b00134300b(xa6607dfd4b3038ad, "Preparing codelist...");
			string tempFileName = Path.GetTempFileName();
			x8a0b266419f09a55.x0acd3c2012ea2ee8(tempFileName);
			try
			{
				xe92eaef26a93933b(x346ddb85fad09a, tempFileName);
				x60b3f492385436d4(x346ddb85fad09a, tempFileName);
				x462da9949a72fb3b(x346ddb85fad09a, tempFileName);
			}
			finally
			{
				File.Delete(tempFileName);
			}
		}
		finally
		{
			xa6607dfd4b3038ad.Cursor = Cursors.Default;
		}
	}

	private static void CopyingExportedCodelist(Form xb6a159a84cb992d6, string TmpFilePath, string SaveFolder, string ErrorPathMsg)
	{
		string DestinationPath = Path.Combine(SaveFolder, "codelist.bin");
		try
		{
			File.Copy(TmpFilePath, DestinationPath, overwrite: true);
		}
		catch (Exception ex)
		{
			MessageBox.Show(xb6a159a84cb992d6, "An error occurred while trying to copy the exported codelist to " + ErrorPathMsg + ".  Skipping export to that path.\r\n\r\n" + DestinationPath + "\r\n" + ex.Message, "Skipping export to folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private static bool xfcbd6b77a1432fc6(Form xb6a159a84cb992d6, string x91191f25fc1df376, string xb690589fc3d0a275)
	{
		if (string.IsNullOrEmpty(x91191f25fc1df376) || !Directory.Exists(x91191f25fc1df376))
		{
			MessageBox.Show(xb6a159a84cb992d6, xb690589fc3d0a275 + " has either not been specified or does not exist.  Skipping export to that path.\r\n\r\nConfigured path: \"" + x91191f25fc1df376 + "\".", "Skipping export to folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		return true;
	}

	private static void xe92eaef26a93933b(MainWindow x346ddb85fad09a98, string xf876ccbecc0c7f1f)
	{
		if (CodeManagerSettings.Instance.ExportToSaves)
		{
			x346ddb85fad09a98.x4147aa1c4fe3686a("Exporting to Saves folder...");
			if (xfcbd6b77a1432fc6(x346ddb85fad09a98, CodeManagerSettings.Instance.SavesFolder, "The MaxDrive application Saves folder"))
			{
				CopyingExportedCodelist(x346ddb85fad09a98, xf876ccbecc0c7f1f, CodeManagerSettings.Instance.SavesFolder, "the MaxDrive application Saves folder");
			}
		}
	}

	private static void x60b3f492385436d4(MainWindow x346ddb85fad09a98, string xf876ccbecc0c7f1f)
	{
		if (CodeManagerSettings.Instance.ExportToUSB)
		{
			x346ddb85fad09a98.x4147aa1c4fe3686a("Exporting to specific drive...");
			if (xfcbd6b77a1432fc6(x346ddb85fad09a98, CodeManagerSettings.Instance.USBFolder, "The USB drive"))
			{
				CopyingExportedCodelist(x346ddb85fad09a98, xf876ccbecc0c7f1f, CodeManagerSettings.Instance.USBFolder, "the specified USB drive");
			}
		}
	}

	private static void x462da9949a72fb3b(MainWindow x346ddb85fad09a98, string xf876ccbecc0c7f1f)
	{
		if (CodeManagerSettings.Instance.ExportToRemovables)
		{
			x346ddb85fad09a98.x4147aa1c4fe3686a("Exporting to all removeable drives...");
			string[] array = xf89ffa2d75dd08c6.x85dcc4807ea67141();
			string[] array2 = array;
			foreach (string x91191f25fc1df in array2)
			{
				CopyingExportedCodelist(x346ddb85fad09a98, xf876ccbecc0c7f1f, x91191f25fc1df, "a removable drive");
			}
		}
	}
}
