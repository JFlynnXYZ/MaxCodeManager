using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Win32;
using Mirality.Max.MaxCodes;
using x7fd6e610350f13fb;

namespace Mirality.Max.CodeManager;

[XmlRoot("Settings")]
public class CodeManagerSettings
{
	public enum ProxyType
	{
		None,
		Automatic,
		Specific
	}

	public bool CheckServerOnStartup;

	public bool CheckAssociations = true;

	public bool AdvancedEditingEnabled;

	public string SavesFolder = "";

	public string USBFolder = "";

	public bool ExportToSaves = true;

	public bool ExportToUSB;

	public bool ExportToRemovables = true;

	public RegionCode RegionCode = RegionCode.PAL;

	public ProxyType Proxy = ProxyType.Automatic;

	public string SpecificProxyHost = "";

	public int SpecificProxyPort = 8080;

	[XmlIgnore]
	public string SpecificProxyUsername = "";

	[XmlIgnore]
	public string SpecificProxyPassword = "";

	public FavouriteGames Favourites = new FavouriteGames();

	public CodelistFileCollection Codelists = new CodelistFileCollection();

	public string ActiveCodelistFile;

	private static CodeManagerSettings _Instance = new CodeManagerSettings();

	public string SpecificProxyCredentials
	{
		get
		{
			string s = SpecificProxyUsername + ':' + SpecificProxyPassword;
			return Convert.ToBase64String(Encoding.Unicode.GetBytes(s));
		}
		set
		{
			string @string = Encoding.Unicode.GetString(Convert.FromBase64String(value));
			string[] array = @string.Split(new char[1] { ':' }, 2);
			SpecificProxyUsername = ((array.Length >= 1) ? array[0] : "");
			SpecificProxyPassword = ((array.Length >= 2) ? array[1] : "");
		}
	}

	[XmlIgnore]
	public static CodeManagerSettings Instance => _Instance;

	public CodeManagerSettings()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\MaxDrive.exe");
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\MaxDrive.exe");
		}
		if (registryKey == null)
		{
			ExportToSaves = false;
			return;
		}
		using (registryKey)
		{
			string path = (string)registryKey.GetValue(null);
			SavesFolder = Path.Combine(Path.GetDirectoryName(path), "Saves");
		}
	}

	public static void Load()
	{
		if (File.Exists(x77dccad1db69a78f.x022e8703da0b9737))
		{
			using (FileStream stream = File.OpenRead(x77dccad1db69a78f.x022e8703da0b9737))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(CodeManagerSettings));
				_Instance = (CodeManagerSettings)xmlSerializer.Deserialize(stream);
			}
		}
	}

	public static void Save()
	{
		Directory.CreateDirectory(Path.GetDirectoryName(x77dccad1db69a78f.x022e8703da0b9737));
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(CodeManagerSettings));
		using FileStream stream = File.Create(x77dccad1db69a78f.x022e8703da0b9737);
		xmlSerializer.Serialize(stream, Instance);
	}
}
