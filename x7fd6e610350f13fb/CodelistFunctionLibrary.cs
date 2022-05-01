using System;
using System.IO;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using x3a260771fe762331;
using xca7bfd2e2e8437c4;

namespace x7fd6e610350f13fb;

public static class CodelistFunctionLibrary
{
	public static void ExportFavsToARMAX(Form form, Codelist list)
	{
		if (form == null)
		{
			throw new ArgumentNullException(nameof(form));
		}
		if (list == null)
		{
			throw new ArgumentNullException(nameof(list));
		}
		form.Cursor = Cursors.WaitCursor;
		try
		{
			using MainWindow MessageBox = MainWindow.CreateMessageBox(form, "Preparing codelist...");
			string tempFileName = Path.GetTempFileName();
			string tempFileNameText = Path.GetTempFileName();
			list.ExportCodelist(tempFileName);
			list.ExportCodelist(tempFileNameText, true);
			try
			{
				ExportToSavesFolder(MessageBox, tempFileName);
				ExportToSpecificDrive(MessageBox, tempFileName);
				ExportToAllAreRemoveableDrives(MessageBox, tempFileName);
				
				ExportToSavesFolder(MessageBox, tempFileNameText, true);
				ExportToSpecificDrive(MessageBox, tempFileNameText);
				ExportToAllAreRemoveableDrives(MessageBox, tempFileNameText);
			}
			finally
			{
				File.Delete(tempFileName);
				File.Delete(tempFileNameText);
			}
		}
		finally
		{
			form.Cursor = Cursors.Default;
		}
	}

	private static void CopyingExportedCodelist(Form Form, string TmpFilePath, string SaveFolder, string ErrorPathMsg,
		bool IsText = false)
	{
		string DestinationPath = Path.Combine(SaveFolder, "codelist");
		if (IsText)
		{
			DestinationPath += ".txt";
		}
		else
		{
			DestinationPath += ".bin";
		}
		try
		{
			File.Copy(TmpFilePath, DestinationPath, overwrite: true);
		}
		catch (Exception ex)
		{
			MessageBox.Show(Form, "An error occurred while trying to copy the exported codelist to " + ErrorPathMsg + ".  Skipping export to that path.\r\n\r\n" + DestinationPath + "\r\n" + ex.Message, "Skipping export to folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private static bool ValidSaveFolder(Form Form, string Directory, string ErrorMessage)
	{
		if (string.IsNullOrEmpty(Directory) || !System.IO.Directory.Exists(Directory))
		{
			MessageBox.Show(Form, ErrorMessage + " has either not been specified or does not exist.  Skipping export to that path.\r\n\r\nConfigured path: \"" + Directory + "\".", "Skipping export to folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		return true;
	}

	private static void ExportToSavesFolder(MainWindow MainWindow, string TmpFilePath, bool IsText = false)
	{
		if (CodeManagerSettings.Instance.ExportToSaves)
		{
			MainWindow.Message("Exporting to Saves folder...");
			if (ValidSaveFolder(MainWindow, CodeManagerSettings.Instance.SavesFolder, "The MaxDrive application Saves folder"))
			{
				CopyingExportedCodelist(MainWindow, TmpFilePath, CodeManagerSettings.Instance.SavesFolder, "the MaxDrive application Saves folder", IsText);
			}
		}
	}

	private static void ExportToSpecificDrive(MainWindow MainWindow, string xf876ccbecc0c7f1f)
	{
		if (CodeManagerSettings.Instance.ExportToUSB)
		{
			MainWindow.Message("Exporting to specific drive...");
			if (ValidSaveFolder(MainWindow, CodeManagerSettings.Instance.USBFolder, "The USB drive"))
			{
				CopyingExportedCodelist(MainWindow, xf876ccbecc0c7f1f, CodeManagerSettings.Instance.USBFolder, "the specified USB drive");
			}
		}
	}

	private static void ExportToAllAreRemoveableDrives(MainWindow MainWindow, string xf876ccbecc0c7f1f)
	{
		if (CodeManagerSettings.Instance.ExportToRemovables)
		{
			MainWindow.Message("Exporting to all removeable drives...");
			string[] array = xf89ffa2d75dd08c6.x85dcc4807ea67141();
			string[] array2 = array;
			foreach (string x91191f25fc1df in array2)
			{
				CopyingExportedCodelist(MainWindow, xf876ccbecc0c7f1f, x91191f25fc1df, "a removable drive");
			}
		}
	}
}
