using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

public class xfc646a3e9e0998cd : MouseEventArgs
{
	private x95fcf261e3011b00 _40212106aad8a8b0;

	public x95fcf261e3011b00 x40212106aad8a8b0 => _40212106aad8a8b0;

	public xfc646a3e9e0998cd(x95fcf261e3011b00 xda5bf54deb817e37, MouseButtons x128517d7ded59312, int x695a5d3567caaeb6, int x08db3aeabb253cb1, int x1e218ceaee1bb583)
		: base(x128517d7ded59312, x695a5d3567caaeb6, x08db3aeabb253cb1, x1e218ceaee1bb583, 0)
	{
		_40212106aad8a8b0 = xda5bf54deb817e37;
	}

	public xfc646a3e9e0998cd(x95fcf261e3011b00 xda5bf54deb817e37, MouseEventArgs xce8d8c7e3c2c2426)
		: base(xce8d8c7e3c2c2426.Button, xce8d8c7e3c2c2426.Clicks, xce8d8c7e3c2c2426.X, xce8d8c7e3c2c2426.Y, xce8d8c7e3c2c2426.Delta)
	{
		_40212106aad8a8b0 = xda5bf54deb817e37;
	}
}
