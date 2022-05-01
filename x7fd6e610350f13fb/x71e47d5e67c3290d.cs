using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.MaxCodes;
using xca7bfd2e2e8437c4;

namespace x7fd6e610350f13fb;

public static class x71e47d5e67c3290d
{
	private class xa868f38828e95534
	{
		public readonly RegionCode x4b94e58155458175;

		public string xe24ab952271f0e04;

		public xa868f38828e95534(RegionCode xa4d52e34b62b5495)
		{
			x4b94e58155458175 = xa4d52e34b62b5495;
		}
	}

	private const string x1071e25b15b008cc = "http://www.maximummemory.co.uk/maxdrive_settings.asp";

	private const string x415b74007dfc4e46 = "http://www.maximummemory.com/maxdrive_settings.asp";

	private const string xe0d54ddae2090832 = "http://www,mirality.co.nz/max/codelist_eu.bin";

	private const string x8f1bf3840c55149e = "http://www.mirality.co.nz/max/codelist_us.bin";

	private static xa868f38828e95534 x5bfeada7f32c1f46 = new xa868f38828e95534(RegionCode.PAL);

	private static xa868f38828e95534 xf245af98a82629dc = new xa868f38828e95534(RegionCode.NTSC);

	private static string x903c64a4d469ba23 => string.Format(CultureInfo.InvariantCulture, "MiralityCodeManager/{0}", x867eb3246b182488.x77fa6322561797a0.ToString(2));

	private static string xa4f453043ad7b64a(RegionCode xa4d52e34b62b5495)
	{
		if (xa4d52e34b62b5495 == RegionCode.NTSC)
		{
			return "http://www.maximummemory.com/maxdrive_settings.asp";
		}
		return "http://www.maximummemory.co.uk/maxdrive_settings.asp";
	}

	private static xa868f38828e95534 xe85ce58ca29f3f6e(RegionCode xa4d52e34b62b5495)
	{
		if (xa4d52e34b62b5495 == RegionCode.NTSC)
		{
			return xf245af98a82629dc;
		}
		return x5bfeada7f32c1f46;
	}

	private static xa868f38828e95534 x2b6a0fc67d65d74b(RegionCode xa4d52e34b62b5495)
	{
		xa868f38828e95534 xa868f38828e = new xa868f38828e95534(xa4d52e34b62b5495);
		if (xa4d52e34b62b5495 == RegionCode.NTSC)
		{
			xa868f38828e.xe24ab952271f0e04 = "http://www.mirality.co.nz/max/codelist_us.bin";
		}
		else
		{
			xa868f38828e.xe24ab952271f0e04 = "http://www,mirality.co.nz/max/codelist_eu.bin";
		}
		return xa868f38828e;
	}

	private static bool xde424771bec64340(RegionCode xa4d52e34b62b5495)
	{
		return xe85ce58ca29f3f6e(xa4d52e34b62b5495).xe24ab952271f0e04 == null;
	}

	private static IWebProxy x543946f68ef21fdb()
	{
		switch (CodeManagerSettings.Instance.Proxy)
		{
		case CodeManagerSettings.ProxyType.None:
			return null;
		case CodeManagerSettings.ProxyType.Specific:
		{
			WebProxy webProxy = new WebProxy(CodeManagerSettings.Instance.SpecificProxyHost, CodeManagerSettings.Instance.SpecificProxyPort);
			if (!string.IsNullOrEmpty(CodeManagerSettings.Instance.SpecificProxyUsername))
			{
				webProxy.Credentials = new NetworkCredential(CodeManagerSettings.Instance.SpecificProxyUsername, CodeManagerSettings.Instance.SpecificProxyPassword);
			}
			return webProxy;
		}
		default:
			return WebRequest.DefaultWebProxy;
		}
	}

	private static void x9f86708238d8f12d(WebClient xc30cd6401e231d63)
	{
		xc30cd6401e231d63.Proxy = x543946f68ef21fdb();
	}

	private static void x9f86708238d8f12d(WebRequest x6a4d36d60e4f5261)
	{
		x6a4d36d60e4f5261.Proxy = x543946f68ef21fdb();
	}

	public static bool xe7e13de667c703d7(Form xb6a159a84cb992d6, RegionCode xa4d52e34b62b5495)
	{
		xa868f38828e95534 xa868f38828e = xe85ce58ca29f3f6e(xa4d52e34b62b5495);
		xa868f38828e.xe24ab952271f0e04 = null;
		try
		{
			using (MainWindow.xebcf83b00134300b(xb6a159a84cb992d6, string.Concat("Retrieving configuration details from ", xa4d52e34b62b5495, " server...")))
			{
				string text = null;
				try
				{
					using WebClient webClient = new WebClient();
					x9f86708238d8f12d(webClient);
					byte[] bytes = webClient.DownloadData(xa4f453043ad7b64a(xa4d52e34b62b5495));
					text = Encoding.ASCII.GetString(bytes);
				}
				catch (WebException)
				{
					return false;
				}
				string[] array = text.Split('\r', '\n');
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					string[] array3 = text2.Split(new char[1] { '=' }, 2);
					if (array3.Length == 2)
					{
						switch (array3[0].ToUpper(CultureInfo.InvariantCulture))
						{
						case "CODELIST_URL":
							xa868f38828e.xe24ab952271f0e04 = array3[1];
							break;
						}
					}
				}
			}
		}
		finally
		{
			Application.DoEvents();
		}
		return true;
	}

	private static bool xae676c12288031ee(Form xb6a159a84cb992d6, RegionCode xa4d52e34b62b5495)
	{
		if (xde424771bec64340(xa4d52e34b62b5495))
		{
			if (!xe7e13de667c703d7(xb6a159a84cb992d6, xa4d52e34b62b5495))
			{
				return false;
			}
			if (xde424771bec64340(xa4d52e34b62b5495))
			{
				return false;
			}
		}
		return true;
	}

	private static int x6b4ab96d3f02e9d7(xa868f38828e95534 xb6b3da7953a69f26)
	{
		byte[] array = new byte[16];
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(xb6b3da7953a69f26.xe24ab952271f0e04));
			x9f86708238d8f12d(httpWebRequest);
			httpWebRequest.UserAgent = x903c64a4d469ba23;
			httpWebRequest.AddRange(0, 15);
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.PartialContent)
			{
				using Stream stream = httpWebResponse.GetResponseStream();
				if (stream.Read(array, 0, 16) != 16)
				{
					throw new IOException("Unexpectedly unable to read from codelist network data stream.  The connection may have failed; try again later.");
				}
			}
		}
		catch (WebException ex)
		{
			throw new IOException(string.Concat("Unable to retrieve ", xb6b3da7953a69f26.x4b94e58155458175, " codelist from server:\r\n  ", ex.Message));
		}
		string @string = Encoding.ASCII.GetString(array, 0, 12);
		if (@string != "PS2_CODELIST")
		{
			throw new IOException(string.Concat("The file retrieved from the ", xb6b3da7953a69f26.x4b94e58155458175, " server does not appear to be a valid ARMAX codelist!"));
		}
		return BitConverter.ToInt32(array, 12);
	}

	public static int x3952158a13fc61b9(Form xb6a159a84cb992d6, RegionCode xa4d52e34b62b5495)
	{
		if (!xae676c12288031ee(xb6a159a84cb992d6, xa4d52e34b62b5495))
		{
			throw new IOException(string.Concat("Unable to read ", xa4d52e34b62b5495, " server configuration."));
		}
		try
		{
			using (MainWindow.xebcf83b00134300b(xb6a159a84cb992d6, string.Concat("Querying ", xa4d52e34b62b5495, " server for latest codelist version...")))
			{
				xa868f38828e95534 xb6b3da7953a69f = xe85ce58ca29f3f6e(xa4d52e34b62b5495);
				return x6b4ab96d3f02e9d7(xb6b3da7953a69f);
			}
		}
		finally
		{
			Application.DoEvents();
		}
	}

	public static int xf097174157e3d00e(Form xb6a159a84cb992d6, RegionCode xa4d52e34b62b5495)
	{
		try
		{
			using (MainWindow.xebcf83b00134300b(xb6a159a84cb992d6, string.Concat("Querying backup server for latest ", xa4d52e34b62b5495, " codelist version...")))
			{
				xa868f38828e95534 xb6b3da7953a69f = x2b6a0fc67d65d74b(xa4d52e34b62b5495);
				return x6b4ab96d3f02e9d7(xb6b3da7953a69f);
			}
		}
		finally
		{
			Application.DoEvents();
		}
	}

	private static bool xb1fade4398e4ef6c(x7d218f2528893f5a xa6607dfd4b3038ad, xa868f38828e95534 xb6b3da7953a69f26, string xb41a802ca5fde63b)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(xb6b3da7953a69f26.xe24ab952271f0e04));
			x9f86708238d8f12d(httpWebRequest);
			httpWebRequest.UserAgent = x903c64a4d469ba23;
			httpWebRequest.KeepAlive = false;
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				return false;
			}
			using Stream stream = httpWebResponse.GetResponseStream();
			using Stream stream2 = File.Create(xb41a802ca5fde63b);
			byte[] array = new byte[2048];
			for (int num = stream.Read(array, 0, array.Length); num > 0; num = stream.Read(array, 0, array.Length))
			{
				stream2.Write(array, 0, num);
				if (httpWebResponse.ContentLength == -1)
				{
					xa6607dfd4b3038ad.x4147aa1c4fe3686a(string.Concat("Downloading ", xb6b3da7953a69f26.x4b94e58155458175, " codelist... {0} bytes done..."), stream2.Position);
				}
				else
				{
					long num2 = stream2.Position * 10000 / httpWebResponse.ContentLength;
					xa6607dfd4b3038ad.x4147aa1c4fe3686a(string.Concat("Downloading ", xb6b3da7953a69f26.x4b94e58155458175, " codelist... {0}.{1:00}% done..."), num2 / 100, num2 % 100);
				}
				if (xa6607dfd4b3038ad.x319ab2d89dd113ab)
				{
					return false;
				}
			}
			return true;
		}
		catch (WebException)
		{
			return false;
		}
	}

	public static bool xb1fade4398e4ef6c(Form xb6a159a84cb992d6, RegionCode xa4d52e34b62b5495, string xb41a802ca5fde63b)
	{
		if (!xae676c12288031ee(xb6a159a84cb992d6, xa4d52e34b62b5495))
		{
			return false;
		}
		try
		{
			using x7d218f2528893f5a xa6607dfd4b3038ad = x7d218f2528893f5a.xebcf83b00134300b(xb6a159a84cb992d6, string.Concat("Requesting ", xa4d52e34b62b5495, " codelist from server..."));
			xa868f38828e95534 xb6b3da7953a69f = xe85ce58ca29f3f6e(xa4d52e34b62b5495);
			return xb1fade4398e4ef6c(xa6607dfd4b3038ad, xb6b3da7953a69f, xb41a802ca5fde63b);
		}
		finally
		{
			Application.DoEvents();
		}
	}

	public static bool x3b4eb5505a678b12(Form xb6a159a84cb992d6, RegionCode xa4d52e34b62b5495, string xb41a802ca5fde63b)
	{
		try
		{
			using x7d218f2528893f5a xa6607dfd4b3038ad = x7d218f2528893f5a.xebcf83b00134300b(xb6a159a84cb992d6, string.Concat("Requesting ", xa4d52e34b62b5495, " codelist from backup server..."));
			xa868f38828e95534 xb6b3da7953a69f = x2b6a0fc67d65d74b(xa4d52e34b62b5495);
			return xb1fade4398e4ef6c(xa6607dfd4b3038ad, xb6b3da7953a69f, xb41a802ca5fde63b);
		}
		finally
		{
			Application.DoEvents();
		}
	}
}
