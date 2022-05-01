using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using x3a260771fe762331;

namespace x4c5768933ca951f6;

public class x85ed94cbab6d08ec : UserControl
{
	private Label xb2b0760149b77e70;

	private Label x31b6f3a354074bae;

	private x3ccd15e4a951572e x88b8d2d314867953;

	private Label x3e886f7a41145fe4;

	private TableLayoutPanel x5ffad42486a6ec63;

	private Container xb7dfc13308b54974;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Codelist x06ca69422bbb7502
	{
		get
		{
			return x88b8d2d314867953.x06ca69422bbb7502;
		}
		set
		{
			x88b8d2d314867953.x06ca69422bbb7502 = value;
			xaaf6bd62666f774b();
		}
	}

	public x85ed94cbab6d08ec()
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
		xb2b0760149b77e70 = new Label();
		x31b6f3a354074bae = new Label();
		x3e886f7a41145fe4 = new Label();
		x5ffad42486a6ec63 = new TableLayoutPanel();
		x88b8d2d314867953 = new x3ccd15e4a951572e();
		x5ffad42486a6ec63.SuspendLayout();
		SuspendLayout();
		xb2b0760149b77e70.Dock = DockStyle.Fill;
		xb2b0760149b77e70.Location = new Point(47, 0);
		xb2b0760149b77e70.Name = "labelVersionCaption";
		xb2b0760149b77e70.Size = new Size(46, 24);
		xb2b0760149b77e70.TabIndex = 2;
		xb2b0760149b77e70.Text = "Version:";
		xb2b0760149b77e70.TextAlign = ContentAlignment.MiddleRight;
		x31b6f3a354074bae.Dock = DockStyle.Fill;
		x31b6f3a354074bae.Location = new Point(99, 0);
		x31b6f3a354074bae.Name = "labelVersion";
		x31b6f3a354074bae.Size = new Size(46, 24);
		x31b6f3a354074bae.TabIndex = 3;
		x31b6f3a354074bae.Text = "(none)";
		x31b6f3a354074bae.TextAlign = ContentAlignment.MiddleRight;
		x3e886f7a41145fe4.Dock = DockStyle.Fill;
		x3e886f7a41145fe4.Location = new Point(3, 0);
		x3e886f7a41145fe4.Name = "labelRegion";
		x3e886f7a41145fe4.Size = new Size(38, 24);
		x3e886f7a41145fe4.TabIndex = 2;
		x3e886f7a41145fe4.Text = "NTSC";
		x3e886f7a41145fe4.TextAlign = ContentAlignment.MiddleLeft;
		x5ffad42486a6ec63.ColumnCount = 4;
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87f));
		x5ffad42486a6ec63.Controls.Add(x88b8d2d314867953, 3, 0);
		x5ffad42486a6ec63.Controls.Add(x3e886f7a41145fe4, 0, 0);
		x5ffad42486a6ec63.Controls.Add(xb2b0760149b77e70, 1, 0);
		x5ffad42486a6ec63.Controls.Add(x31b6f3a354074bae, 2, 0);
		x5ffad42486a6ec63.Dock = DockStyle.Fill;
		x5ffad42486a6ec63.Location = new Point(0, 0);
		x5ffad42486a6ec63.Name = "panelLayout";
		x5ffad42486a6ec63.RowCount = 1;
		x5ffad42486a6ec63.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		x5ffad42486a6ec63.Size = new Size(498, 24);
		x5ffad42486a6ec63.TabIndex = 4;
		x88b8d2d314867953.Dock = DockStyle.Fill;
		x88b8d2d314867953.Location = new Point(151, 0);
		x88b8d2d314867953.Margin = new Padding(3, 0, 3, 0);
		x88b8d2d314867953.Name = "miniCodelistInfoControl";
		x88b8d2d314867953.Size = new Size(344, 24);
		x88b8d2d314867953.TabIndex = 0;
		base.Controls.Add(x5ffad42486a6ec63);
		base.Name = "CodelistInfoControl";
		base.Size = new Size(498, 24);
		x5ffad42486a6ec63.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public void xff4d25013a33450a()
	{
		x88b8d2d314867953.xff4d25013a33450a();
		xaaf6bd62666f774b();
	}

	private void xaaf6bd62666f774b()
	{
		if (x06ca69422bbb7502 == null)
		{
			x3e886f7a41145fe4.Text = "(none)";
			x31b6f3a354074bae.Text = "(none)";
		}
		else
		{
			x3e886f7a41145fe4.Text = x06ca69422bbb7502.Region.ToString();
			x31b6f3a354074bae.Text = x06ca69422bbb7502.x77fa6322561797a0.ToString(CultureInfo.CurrentCulture);
		}
	}
}
