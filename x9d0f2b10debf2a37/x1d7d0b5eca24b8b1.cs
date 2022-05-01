using System;
using System.IO;

namespace x9d0f2b10debf2a37;

public class x1d7d0b5eca24b8b1
{
	private static string x1026f06ebc8da858;

	static x1d7d0b5eca24b8b1()
	{
		x1026f06ebc8da858 = "x:\\vmroot";
	}

	public static Stream x04e6edcbcc514fa1(string x96b4f4dbfe298194)
	{
		return File.OpenRead(Environment.ExpandEnvironmentVariables(Path.Combine(x1026f06ebc8da858, x96b4f4dbfe298194)));
	}
}
