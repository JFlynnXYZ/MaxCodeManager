using System.ComponentModel;
using System.Security.Permissions;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

[DesignerCategory("code")]
internal class xef58b78651bbbe4e : ListView
{
	[ReadOnly(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool xc71b0ff69cab0443 => base.CheckBoxes;

	public xef58b78651bbbe4e()
	{
		base.CheckBoxes = true;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected override void WndProc(ref Message x6088325dec1baa2a)
	{
		if (x6088325dec1baa2a.Msg == 8270)
		{
			x3dabed07063b41e9(ref x6088325dec1baa2a);
		}
		else
		{
			base.WndProc(ref x6088325dec1baa2a);
		}
	}

	private void x3dabed07063b41e9(ref Message x6088325dec1baa2a)
	{
		x842e24ef1160275b.x53cb129830509e4d x53cb129830509e4d = (x842e24ef1160275b.x53cb129830509e4d)x6088325dec1baa2a.GetLParam(typeof(x842e24ef1160275b.x53cb129830509e4d));
		if (x53cb129830509e4d.x9035cf16181332fc == -2 || x53cb129830509e4d.x9035cf16181332fc == -3)
		{
			ListViewHitTestInfo listViewHitTestInfo = HitTest(PointToClient(Cursor.Position));
			if (listViewHitTestInfo.Location != ListViewHitTestLocations.StateImage)
			{
				return;
			}
		}
		base.WndProc(ref x6088325dec1baa2a);
	}
}
