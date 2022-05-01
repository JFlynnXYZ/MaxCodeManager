using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using x3a260771fe762331;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class x3ccd15e4a951572e : UserControl
{
	private Label xd8a0f8fa2d879daf;

	private Label x067fe27a7e18f024;

	private Label x87d653370928e1af;

	private Label xcf64cee21cb1cdcb;

	private Label x11078fd40e0d74a2;

	private Label xa00c02155abf689e;

	private TableLayoutPanel x5ffad42486a6ec63;

	private Container xb7dfc13308b54974;

	private Codelist _06ca69422bbb7502;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Codelist x06ca69422bbb7502
	{
		get
		{
			return _06ca69422bbb7502;
		}
		set
		{
			_06ca69422bbb7502 = value;
			xff4d25013a33450a();
		}
	}

	public x3ccd15e4a951572e()
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
		xd8a0f8fa2d879daf = new Label();
		x067fe27a7e18f024 = new Label();
		x87d653370928e1af = new Label();
		xcf64cee21cb1cdcb = new Label();
		x11078fd40e0d74a2 = new Label();
		xa00c02155abf689e = new Label();
		x5ffad42486a6ec63 = new TableLayoutPanel();
		x5ffad42486a6ec63.SuspendLayout();
		SuspendLayout();
		xd8a0f8fa2d879daf.Dock = DockStyle.Fill;
		xd8a0f8fa2d879daf.Location = new Point(253, 0);
		xd8a0f8fa2d879daf.Name = "labelSize";
		xd8a0f8fa2d879daf.Size = new Size(71, 24);
		xd8a0f8fa2d879daf.TabIndex = 12;
		xd8a0f8fa2d879daf.Text = "(none)";
		xd8a0f8fa2d879daf.TextAlign = ContentAlignment.MiddleRight;
		x067fe27a7e18f024.Dock = DockStyle.Fill;
		x067fe27a7e18f024.Location = new Point(217, 0);
		x067fe27a7e18f024.Name = "labelSizeCaption";
		x067fe27a7e18f024.Size = new Size(30, 24);
		x067fe27a7e18f024.TabIndex = 11;
		x067fe27a7e18f024.Text = "Size:";
		x067fe27a7e18f024.TextAlign = ContentAlignment.MiddleRight;
		x87d653370928e1af.Dock = DockStyle.Fill;
		x87d653370928e1af.Location = new Point(3, 0);
		x87d653370928e1af.Name = "labelGamesCaption";
		x87d653370928e1af.Size = new Size(46, 24);
		x87d653370928e1af.TabIndex = 7;
		x87d653370928e1af.Text = "Games:";
		x87d653370928e1af.TextAlign = ContentAlignment.MiddleRight;
		xcf64cee21cb1cdcb.Dock = DockStyle.Fill;
		xcf64cee21cb1cdcb.Location = new Point(55, 0);
		xcf64cee21cb1cdcb.Name = "labelGames";
		xcf64cee21cb1cdcb.Size = new Size(51, 24);
		xcf64cee21cb1cdcb.TabIndex = 8;
		xcf64cee21cb1cdcb.Text = "(none)";
		xcf64cee21cb1cdcb.TextAlign = ContentAlignment.MiddleRight;
		x11078fd40e0d74a2.Dock = DockStyle.Fill;
		x11078fd40e0d74a2.Location = new Point(112, 0);
		x11078fd40e0d74a2.Name = "labelCodesCaption";
		x11078fd40e0d74a2.Size = new Size(42, 24);
		x11078fd40e0d74a2.TabIndex = 9;
		x11078fd40e0d74a2.Text = "Codes:";
		x11078fd40e0d74a2.TextAlign = ContentAlignment.MiddleRight;
		xa00c02155abf689e.Dock = DockStyle.Fill;
		xa00c02155abf689e.Location = new Point(160, 0);
		xa00c02155abf689e.Name = "labelCodes";
		xa00c02155abf689e.Size = new Size(51, 24);
		xa00c02155abf689e.TabIndex = 10;
		xa00c02155abf689e.Text = "(none)";
		xa00c02155abf689e.TextAlign = ContentAlignment.MiddleRight;
		x5ffad42486a6ec63.ColumnCount = 6;
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36f));
		x5ffad42486a6ec63.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
		x5ffad42486a6ec63.Controls.Add(x87d653370928e1af, 0, 0);
		x5ffad42486a6ec63.Controls.Add(xd8a0f8fa2d879daf, 5, 0);
		x5ffad42486a6ec63.Controls.Add(xcf64cee21cb1cdcb, 1, 0);
		x5ffad42486a6ec63.Controls.Add(x067fe27a7e18f024, 4, 0);
		x5ffad42486a6ec63.Controls.Add(x11078fd40e0d74a2, 2, 0);
		x5ffad42486a6ec63.Controls.Add(xa00c02155abf689e, 3, 0);
		x5ffad42486a6ec63.Dock = DockStyle.Fill;
		x5ffad42486a6ec63.Location = new Point(0, 0);
		x5ffad42486a6ec63.Name = "panelLayout";
		x5ffad42486a6ec63.RowCount = 1;
		x5ffad42486a6ec63.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		x5ffad42486a6ec63.Size = new Size(327, 24);
		x5ffad42486a6ec63.TabIndex = 13;
		base.Controls.Add(x5ffad42486a6ec63);
		base.Name = "MiniCodelistInfoControl";
		base.Size = new Size(327, 24);
		x5ffad42486a6ec63.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public void xff4d25013a33450a()
	{
		if (x06ca69422bbb7502 == null)
		{
			xcf64cee21cb1cdcb.Text = "(none)";
			xa00c02155abf689e.Text = "(none)";
			xd8a0f8fa2d879daf.Text = "(none)";
		}
		else
		{
			xcf64cee21cb1cdcb.Text = x06ca69422bbb7502.x69e1830021be7f93.ToString(CultureInfo.CurrentCulture);
			xa00c02155abf689e.Text = x06ca69422bbb7502.xbeb7785012fbaf09.ToString(CultureInfo.CurrentCulture);
			xd8a0f8fa2d879daf.Text = x289f1a0ee2f795a7.xf0dac06e79e03a32((x06ca69422bbb7502.x69e1830021be7f93 != 0) ? x06ca69422bbb7502.xd38f244fb61873da : 0u);
		}
	}
}
