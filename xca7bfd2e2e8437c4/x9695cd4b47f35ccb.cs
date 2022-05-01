using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace xca7bfd2e2e8437c4;

internal sealed class x9695cd4b47f35ccb : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal x9695cd4b47f35ccb()
		: base(ownsHandle: true)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal x9695cd4b47f35ccb(IntPtr x25fc5e25c5187c3d, bool xd2397283414d6649)
		: base(xd2397283414d6649)
	{
		SetHandle(x25fc5e25c5187c3d);
	}

	protected override bool ReleaseHandle()
	{
		return x842e24ef1160275b.RegCloseKey(handle) == 0;
	}
}
