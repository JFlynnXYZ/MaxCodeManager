using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using x2ac61696da69bb5f;
using x3a260771fe762331;

namespace x4c5768933ca951f6;

public class x1bf2d293629a251c : Form
{
	private x9e548743c3f0e895.xf370fda13822d1f9 _0a444d8def87be79;

	private IContainer xb7dfc13308b54974;

	private TableLayoutPanel x7aef9b15a0092547;

	private x99267918b6c5b337 xb92085d6055ca54a;

	private x99267918b6c5b337 xca953237675c5563;

	private x99267918b6c5b337 xc14452863c7de584;

	private x99267918b6c5b337 x231020b33766ffdc;

	private Button x77c138625e4a3561;

	private Button x8c7441c6635b5683;

	public x9e548743c3f0e895.xf370fda13822d1f9 x0a444d8def87be79 => _0a444d8def87be79;

	public x1bf2d293629a251c(x9e548743c3f0e895.xf370fda13822d1f9 xfd6dd6e53b1a26d5)
	{
		x85601834555fb7d5();
		IList<x047611ec9892e059.x7a274f60ab25f2b9> list = xfd6dd6e53b1a26d5.xfb8e025166a358a7();
		switch (list.Count)
		{
		case 1:
		{
			x7aef9b15a0092547.RowStyles[1].Height = 0f;
			x99267918b6c5b337 obj = xca953237675c5563;
			bool enabled = (xb92085d6055ca54a.Enabled = false);
			obj.Enabled = enabled;
			break;
		}
		case 2:
			xca953237675c5563.xd2f68ee6f47e9dfb = list[1].x1d5cfa3bffdfb042;
			xb92085d6055ca54a.xd2f68ee6f47e9dfb = list[1].xd2f68ee6f47e9dfb;
			break;
		default:
			throw new ArgumentException("Specified command resulted in illegal number of raw commands.", "command");
		}
		x231020b33766ffdc.xd2f68ee6f47e9dfb = list[0].x1d5cfa3bffdfb042;
		xc14452863c7de584.xd2f68ee6f47e9dfb = list[0].xd2f68ee6f47e9dfb;
	}

	private void xeebb56e8f7be7895(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (x231020b33766ffdc.x6fdb60dbbbb1352b || xca953237675c5563.x6fdb60dbbbb1352b || xc14452863c7de584.x6fdb60dbbbb1352b || xb92085d6055ca54a.x6fdb60dbbbb1352b)
		{
			base.DialogResult = DialogResult.None;
			MessageBox.Show(this, "One or more values contain an error.  You must fix this before you can save the result.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		List<x047611ec9892e059.x7a274f60ab25f2b9> list = new List<x047611ec9892e059.x7a274f60ab25f2b9>();
		list.Add(new x047611ec9892e059.x7a274f60ab25f2b9(x231020b33766ffdc.xd2f68ee6f47e9dfb, xc14452863c7de584.xd2f68ee6f47e9dfb));
		if (xca953237675c5563.Enabled)
		{
			list.Add(new x047611ec9892e059.x7a274f60ab25f2b9(xca953237675c5563.xd2f68ee6f47e9dfb, xb92085d6055ca54a.xd2f68ee6f47e9dfb));
		}
		List<x9e548743c3f0e895.xf370fda13822d1f9> list2 = x9e548743c3f0e895.xb4638aac69d75ced(list, new List<string>());
		if (list2.Count != 1)
		{
			base.DialogResult = DialogResult.None;
			MessageBox.Show(this, "There was an error parsing the entered code." + (xca953237675c5563.Enabled ? "  (It is not permitted to break up a multi-line code into multiple single-line codes.)" : ""), "Code Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else
		{
			_0a444d8def87be79 = list2[0];
		}
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
		x7aef9b15a0092547 = new TableLayoutPanel();
		xb92085d6055ca54a = new x99267918b6c5b337();
		xca953237675c5563 = new x99267918b6c5b337();
		xc14452863c7de584 = new x99267918b6c5b337();
		x231020b33766ffdc = new x99267918b6c5b337();
		x77c138625e4a3561 = new Button();
		x8c7441c6635b5683 = new Button();
		x7aef9b15a0092547.SuspendLayout();
		SuspendLayout();
		x7aef9b15a0092547.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x7aef9b15a0092547.ColumnCount = 2;
		x7aef9b15a0092547.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		x7aef9b15a0092547.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		x7aef9b15a0092547.Controls.Add(xb92085d6055ca54a, 1, 1);
		x7aef9b15a0092547.Controls.Add(xca953237675c5563, 0, 1);
		x7aef9b15a0092547.Controls.Add(xc14452863c7de584, 1, 0);
		x7aef9b15a0092547.Controls.Add(x231020b33766ffdc, 0, 0);
		x7aef9b15a0092547.Location = new Point(12, 12);
		x7aef9b15a0092547.Name = "tableLayoutPanel1";
		x7aef9b15a0092547.RowCount = 2;
		x7aef9b15a0092547.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		x7aef9b15a0092547.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		x7aef9b15a0092547.Size = new Size(158, 56);
		x7aef9b15a0092547.TabIndex = 0;
		xb92085d6055ca54a.Location = new Point(82, 31);
		xb92085d6055ca54a.Name = "hexValue2";
		xb92085d6055ca54a.Size = new Size(73, 22);
		xb92085d6055ca54a.TabIndex = 3;
		xca953237675c5563.Location = new Point(3, 31);
		xca953237675c5563.Name = "hexAddress2";
		xca953237675c5563.Size = new Size(73, 22);
		xca953237675c5563.TabIndex = 2;
		xc14452863c7de584.Location = new Point(82, 3);
		xc14452863c7de584.Name = "hexValue1";
		xc14452863c7de584.Size = new Size(73, 22);
		xc14452863c7de584.TabIndex = 1;
		x231020b33766ffdc.Location = new Point(3, 3);
		x231020b33766ffdc.Name = "hexAddress1";
		x231020b33766ffdc.Size = new Size(73, 22);
		x231020b33766ffdc.TabIndex = 0;
		x77c138625e4a3561.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x77c138625e4a3561.DialogResult = DialogResult.OK;
		x77c138625e4a3561.Location = new Point(14, 74);
		x77c138625e4a3561.Name = "buttonOk";
		x77c138625e4a3561.Size = new Size(75, 23);
		x77c138625e4a3561.TabIndex = 1;
		x77c138625e4a3561.Text = "OK";
		x77c138625e4a3561.UseVisualStyleBackColor = true;
		x77c138625e4a3561.Click += xeebb56e8f7be7895;
		x8c7441c6635b5683.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x8c7441c6635b5683.DialogResult = DialogResult.Cancel;
		x8c7441c6635b5683.Location = new Point(94, 74);
		x8c7441c6635b5683.Name = "buttonCancel";
		x8c7441c6635b5683.Size = new Size(75, 23);
		x8c7441c6635b5683.TabIndex = 2;
		x8c7441c6635b5683.Text = "Cancel";
		x8c7441c6635b5683.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(182, 110);
		base.ControlBox = false;
		base.Controls.Add(x8c7441c6635b5683);
		base.Controls.Add(x77c138625e4a3561);
		base.Controls.Add(x7aef9b15a0092547);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "MaxCommandRawEditorForm";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Raw Command Editor";
		x7aef9b15a0092547.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
