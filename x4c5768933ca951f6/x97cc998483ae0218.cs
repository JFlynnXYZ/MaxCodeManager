using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Mirality.Max.MaxCodes;
using x7fd6e610350f13fb;

namespace x4c5768933ca951f6;

public class x97cc998483ae0218 : UserControl
{
	private x85ed94cbab6d08ec xa44ee460ebe99463;

	private x85ed94cbab6d08ec x1993418c2bb5dfea;

	private Container xb7dfc13308b54974;

	public x97cc998483ae0218()
	{
		x85601834555fb7d5();
	}

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		if (xb41acd866d5cbca8 && xb7dfc13308b54974 != null)
		{
			xb7dfc13308b54974.Dispose();
		}
		base.Dispose(xb41acd866d5cbca8);
	}

	private void x85601834555fb7d5()
	{
		xa44ee460ebe99463 = new x85ed94cbab6d08ec();
		x1993418c2bb5dfea = new x85ed94cbab6d08ec();
		SuspendLayout();
		xa44ee460ebe99463.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xa44ee460ebe99463.Location = new Point(0, 0);
		xa44ee460ebe99463.Name = "codelistInfoPal";
		xa44ee460ebe99463.Size = new Size(438, 16);
		xa44ee460ebe99463.TabIndex = 0;
		x1993418c2bb5dfea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x1993418c2bb5dfea.Location = new Point(0, 16);
		x1993418c2bb5dfea.Name = "codelistInfoNtsc";
		x1993418c2bb5dfea.Size = new Size(438, 16);
		x1993418c2bb5dfea.TabIndex = 0;
		base.Controls.Add(xa44ee460ebe99463);
		base.Controls.Add(x1993418c2bb5dfea);
		base.Name = "MultiRegionCodelistInfoControl";
		base.Size = new Size(438, 32);
		ResumeLayout(performLayout: false);
	}

	public void x451c5ee2445ffafd(x131eae80bdcb392e x7d45a69b707b1582)
	{
		xa44ee460ebe99463.x06ca69422bbb7502 = x7d45a69b707b1582.x38758cbbee49e4cb(RegionCode.PAL);
		x1993418c2bb5dfea.x06ca69422bbb7502 = x7d45a69b707b1582.x38758cbbee49e4cb(RegionCode.NTSC);
		xae19a615b411c9fa();
	}

	protected override void OnSizeChanged(EventArgs xfbf34718e704c6bc)
	{
		xae19a615b411c9fa();
		base.OnSizeChanged(xfbf34718e704c6bc);
	}

	private void xae19a615b411c9fa()
	{
		bool flag = xa44ee460ebe99463.x06ca69422bbb7502 != null;
		bool flag2 = x1993418c2bb5dfea.x06ca69422bbb7502 != null;
		if (flag && flag2)
		{
			xa44ee460ebe99463.Show();
			x1993418c2bb5dfea.Show();
			xa44ee460ebe99463.Location = new Point(0, 0);
			xa44ee460ebe99463.Size = new Size(base.ClientSize.Width, base.ClientSize.Height / 2);
			x1993418c2bb5dfea.Location = new Point(0, xa44ee460ebe99463.Bottom);
			x1993418c2bb5dfea.Size = new Size(base.ClientSize.Width, base.ClientSize.Height - xa44ee460ebe99463.Height);
		}
		else if (flag2)
		{
			xa44ee460ebe99463.Hide();
			x1993418c2bb5dfea.Show();
			x1993418c2bb5dfea.Location = new Point(0, 0);
			x1993418c2bb5dfea.Size = base.ClientSize;
		}
		else
		{
			x1993418c2bb5dfea.Hide();
			xa44ee460ebe99463.Show();
			xa44ee460ebe99463.Location = new Point(0, 0);
			xa44ee460ebe99463.Size = base.ClientSize;
		}
	}
}
