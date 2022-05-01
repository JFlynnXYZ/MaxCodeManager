using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace xca7bfd2e2e8437c4;

internal static class x842e24ef1160275b
{
	public struct x53cb129830509e4d
	{
		public IntPtr xfd38ecc6963c683b;

		public IntPtr x4f3b221b51385ccd;

		public int code;
	}

	public struct x8dd4b7a13a696a09
	{
		public int xa447fc54e41dfe06;

		public int xc941868c59399d3e;

		public int xfc2074a859a5db8c;

		public int xaf9a0436a70689de;

		public x8dd4b7a13a696a09(Rectangle xb55b340ae3a3e4e0)
		{
			xa447fc54e41dfe06 = xb55b340ae3a3e4e0.Left;
			xc941868c59399d3e = xb55b340ae3a3e4e0.Top;
			xfc2074a859a5db8c = xb55b340ae3a3e4e0.Right;
			xaf9a0436a70689de = xb55b340ae3a3e4e0.Bottom;
		}

		public static implicit operator Rectangle(x8dd4b7a13a696a09 x26545669838eb36e)
		{
			return Rectangle.FromLTRB(x26545669838eb36e.xa447fc54e41dfe06, x26545669838eb36e.xc941868c59399d3e, x26545669838eb36e.xfc2074a859a5db8c, x26545669838eb36e.xaf9a0436a70689de);
		}
	}

	public struct x4b429ae161669a9e
	{
		public x8dd4b7a13a696a09 x4c5f240eee47c6c5;

		public x8dd4b7a13a696a09 x8d2b5827b12e2b27;

		public x8dd4b7a13a696a09 x75dca67d9eb0cf28;

		public xa47eed6ec2af88ef x9a8d03fb9b4f9db1;
	}

	public struct xa47eed6ec2af88ef
	{
		public IntPtr x7cc24662a4086c94;

		public IntPtr x6e24aa13fbf6cd45;

		public int x08db3aeabb253cb1;

		public int x1e218ceaee1bb583;

		public int xdb1e70b17dab62a5;

		public int xb8619098041280e9;

		public uint xebf45bdcaa1fd1e1;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(HandleRef x7cc24662a4086c94, int x8a41fbc87a3fb305, IntPtr x716e0bc3eafdded2, IntPtr x130fbcecf32fe781);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr x7cc24662a4086c94);

	[DllImport("user32.dll")]
	public static extern int ReleaseDC(IntPtr x7cc24662a4086c94, IntPtr x193c07eb730b30a4);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(IntPtr x7cc24662a4086c94, out x8dd4b7a13a696a09 x84b201b219db0d6f);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.U4)]
	public static extern x238376a23aa938d4.xdbb3b44e59f3022c GetDriveType(string xc8d9f08d1faa75f8);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumeInformation(string xc8d9f08d1faa75f8, StringBuilder xe2e9ecbeb5ebccb8, int xe1cf656739a09f43, IntPtr x0e8c726a749eac0b, IntPtr x324cca6db181000b, IntPtr x4b39add6fce8dc27, StringBuilder x157ed6b3aed04b2d, int xc5883314dba8e86d);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void SHChangeNotify(x238376a23aa938d4.x5802bd9c5cc04456 xa7ad1f751e1c4893, x238376a23aa938d4.xab86832616e9a6ab x65e70cabb0b3496f, IntPtr x83cd0a8f1e664cc8, IntPtr x2c13a4cc820351eb);

	[DllImport("AdvApi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int RegOpenKeyEx(x9695cd4b47f35ccb xae8460f5cc831ec2, string x65ed8e5ee84483a5, uint x81a4b82900819d78, x238376a23aa938d4.xaf679febdab5ba2b x6c30737606448883, out x9695cd4b47f35ccb x202c94d1e030f821);

	[DllImport("AdvApi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int RegQueryValueEx(x9695cd4b47f35ccb xae8460f5cc831ec2, string x42ca22afb3d9ef66, IntPtr x7ac087166e688561, out int x43163d22e8cd5a71, StringBuilder x3407f7a7a28fe91f, ref int x261e0948ef9763b2);

	[DllImport("AdvApi32.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int RegCloseKey(IntPtr x2249083040e86769);

	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("Kernel32.dll")]
	public static extern void CloseHandle(IntPtr x45cb9c0352055524);

	[DllImport("AdvApi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool OpenProcessToken(IntPtr x6cffe4e65de0c045, x238376a23aa938d4.xfffed9ed8b1c1b9e x7700d45f0491efb1, out IntPtr x159f8d10bfb3428d);

	[DllImport("AdvApi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetTokenInformation(IntPtr x159f8d10bfb3428d, x238376a23aa938d4.xb8cab4e3b6a3986c x43163d22e8cd5a71, IntPtr info, uint x961016a387451f05, out uint xf8c51ced30acecd9);

	[DllImport("AdvApi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetTokenInformation(IntPtr x159f8d10bfb3428d, x238376a23aa938d4.xb8cab4e3b6a3986c x43163d22e8cd5a71, IntPtr info, uint x961016a387451f05);
}
