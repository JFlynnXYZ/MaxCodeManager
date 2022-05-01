using System;
using System.Drawing;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal class x7d218f2528893f5a : MainWindow
{
	private Button x4d62cc522d2d5538;

	private bool _319ab2d89dd113ab;

	public bool x319ab2d89dd113ab => _319ab2d89dd113ab;

	private void x85601834555fb7d5()
	{
		x4d62cc522d2d5538 = new Button();
		SuspendLayout();
		x4d62cc522d2d5538.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x4d62cc522d2d5538.DialogResult = DialogResult.Cancel;
		x4d62cc522d2d5538.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x4d62cc522d2d5538.Location = new Point(422, 0);
		x4d62cc522d2d5538.Name = "buttonAbort";
		x4d62cc522d2d5538.Size = new Size(20, 19);
		x4d62cc522d2d5538.TabIndex = 1;
		x4d62cc522d2d5538.Text = "X";
		x4d62cc522d2d5538.UseCompatibleTextRendering = true;
		x4d62cc522d2d5538.Visible = false;
		x4d62cc522d2d5538.Click += xd26d40f1aa5e2441;
		AutoScaleBaseSize = new Size(8, 19);
		base.CancelButton = x4d62cc522d2d5538;
		base.ClientSize = new Size(442, 50);
		base.Controls.Add(x4d62cc522d2d5538);
		base.Name = "AbortableStatusForm";
		base.Controls.SetChildIndex(x4d62cc522d2d5538, 0);
		ResumeLayout(performLayout: false);
	}

	protected x7d218f2528893f5a()
	{
		x85601834555fb7d5();
	}

	public new static x7d218f2528893f5a xebcf83b00134300b(Form x071bde1041617fce, string x399bfb4377fa76d2)
	{
		x7d218f2528893f5a x7d218f2528893f5a2 = new x7d218f2528893f5a();
		x7d218f2528893f5a2.x20aee281977480cf(x071bde1041617fce, x399bfb4377fa76d2);
		x7d218f2528893f5a2.x4d62cc522d2d5538.Visible = true;
		return x7d218f2528893f5a2;
	}

	private void xd26d40f1aa5e2441(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		_319ab2d89dd113ab = true;
	}
}
