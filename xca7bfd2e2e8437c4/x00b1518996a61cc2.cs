using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

[DesignerCategory("code")]
internal class x00b1518996a61cc2 : xef58b78651bbbe4e
{
	[ReadOnly(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool x584ba2e98f91dd4d => base.VirtualMode;

	public x00b1518996a61cc2()
	{
		base.VirtualMode = true;
	}

	protected override void OnRetrieveVirtualItem(RetrieveVirtualItemEventArgs xfbf34718e704c6bc)
	{
		base.OnRetrieveVirtualItem(xfbf34718e704c6bc);
		if (base.xc71b0ff69cab0443 && xfbf34718e704c6bc.Item != null && xfbf34718e704c6bc.Item.StateImageIndex < 0)
		{
			xfbf34718e704c6bc.Item.StateImageIndex = 0;
		}
	}

	protected override void OnMouseClick(MouseEventArgs xfbf34718e704c6bc)
	{
		if (x584ba2e98f91dd4d && base.xc71b0ff69cab0443)
		{
			ListViewHitTestInfo listViewHitTestInfo = HitTest(xfbf34718e704c6bc.Location);
			if (listViewHitTestInfo.Item != null && (listViewHitTestInfo.Location & ListViewHitTestLocations.StateImage) != 0)
			{
				if (listViewHitTestInfo.Item.Selected)
				{
					x8c28666b5a3ed554(listViewHitTestInfo.Item.Checked);
				}
				else
				{
					base.SelectedIndices.Clear();
					listViewHitTestInfo.Item.Selected = true;
					x8c28666b5a3ed554(listViewHitTestInfo.Item.Checked);
				}
			}
		}
		base.OnMouseClick(xfbf34718e704c6bc);
	}

	protected override void OnKeyDown(KeyEventArgs xfbf34718e704c6bc)
	{
		if (x584ba2e98f91dd4d && base.xc71b0ff69cab0443 && xfbf34718e704c6bc.KeyData == Keys.Space && base.SelectedIndices.Count > 0)
		{
			int itemIndex = base.SelectedIndices[0];
			RetrieveVirtualItemEventArgs retrieveVirtualItemEventArgs = new RetrieveVirtualItemEventArgs(itemIndex);
			OnRetrieveVirtualItem(retrieveVirtualItemEventArgs);
			if (retrieveVirtualItemEventArgs.Item == null)
			{
				throw new InvalidOperationException("RetrieveVirtualItem must return a valid item");
			}
			x8c28666b5a3ed554(retrieveVirtualItemEventArgs.Item.Checked);
		}
		base.OnKeyDown(xfbf34718e704c6bc);
	}

	private void x8c28666b5a3ed554(bool x3bd62873fafa6252)
	{
		BeginUpdate();
		try
		{
			foreach (int selectedIndex in base.SelectedIndices)
			{
				CheckState currentValue = (x3bd62873fafa6252 ? CheckState.Checked : CheckState.Unchecked);
				CheckState newCheckValue = ((!x3bd62873fafa6252) ? CheckState.Checked : CheckState.Unchecked);
				ItemCheckEventArgs ice = new ItemCheckEventArgs(selectedIndex, newCheckValue, currentValue);
				OnItemCheck(ice);
				Invalidate(GetItemRect(selectedIndex));
			}
		}
		finally
		{
			EndUpdate();
		}
	}
}
