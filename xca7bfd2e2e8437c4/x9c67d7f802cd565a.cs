using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal static class x9c67d7f802cd565a
{
	private static bool x0597213810ee0598()
	{
		if (x842e24ef1160275b.OpenProcessToken(x842e24ef1160275b.GetCurrentProcess(), x238376a23aa938d4.xfffed9ed8b1c1b9e.x06b0e25aa6ad68a9, out var x159f8d10bfb3428d))
		{
			try
			{
				bool x2fef7d841879a;
				return x98d5b12cfac5b235.x53b4834f330a6612(x159f8d10bfb3428d, out x2fef7d841879a) && x2fef7d841879a;
			}
			finally
			{
				x842e24ef1160275b.CloseHandle(x159f8d10bfb3428d);
			}
		}
		return false;
	}

	private static bool x89aa91ce33201c99(bool x2fef7d841879a711)
	{
		if (x842e24ef1160275b.OpenProcessToken(x842e24ef1160275b.GetCurrentProcess(), x238376a23aa938d4.xfffed9ed8b1c1b9e.x06b0e25aa6ad68a9 | x238376a23aa938d4.xfffed9ed8b1c1b9e.x828fe1ecc16bd2f1, out var x159f8d10bfb3428d))
		{
			try
			{
				return x98d5b12cfac5b235.x0a2dbdb05d94b2cc(x159f8d10bfb3428d, x2fef7d841879a711);
			}
			finally
			{
				x842e24ef1160275b.CloseHandle(x159f8d10bfb3428d);
			}
		}
		return false;
	}

	private static bool xa20e07c2365cf8ff(string xb41a802ca5fde63b)
	{
		try
		{
			File.Delete(xb41a802ca5fde63b);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static bool x544ba73126564b71(string x9e7bc246348da76a, string x71855acb428f4f2c)
	{
		try
		{
			File.Move(x9e7bc246348da76a, x71855acb428f4f2c);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static void xa0b5d41efa94698d(string x9e7bc246348da76a, string x71855acb428f4f2c)
	{
		if (File.Exists(x71855acb428f4f2c))
		{
			return;
		}
		string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
		string text = Path.Combine(directoryName, x9e7bc246348da76a);
		bool flag = File.Exists(text);
		x89aa91ce33201c99(x2fef7d841879a711: true);
		try
		{
			if (!File.Exists(text))
			{
				return;
			}
			File.Copy(text, x71855acb428f4f2c);
			if (!x0597213810ee0598())
			{
				return;
			}
			if (!flag)
			{
				xa20e07c2365cf8ff(text);
				return;
			}
			string text2 = Path.Combine(Path.GetDirectoryName(text), "migrate.tmp");
			if (x544ba73126564b71(text, text2) && (!File.Exists(text) || !xa20e07c2365cf8ff(text2)))
			{
				while (!x544ba73126564b71(text2, text))
				{
					Thread.Sleep(1000);
				}
			}
		}
		finally
		{
			x89aa91ce33201c99(x2fef7d841879a711: false);
		}
	}
}
