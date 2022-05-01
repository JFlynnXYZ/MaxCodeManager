using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.MaxCodes;
using x2ac61696da69bb5f;
using x3a260771fe762331;
using x7fd6e610350f13fb;

namespace x4c5768933ca951f6;

public class x1536525b14cf2192 : Form
{
	private GameEntry _c74ed71dea076128;

	private uint _52b8174788d367f9;

	private uint _b3efee94cf138f44;

	private CodeEntry _b0b4ff1622a01d12;

	private IContainer xb7dfc13308b54974;

	private TextBox x9592d68fcb5ab881;

	private TextBox x5ee38acf34ff0ae3;

	private TextBox xdd8dff12a799aaad;

	private Button x8c7441c6635b5683;

	private Button x77c138625e4a3561;

	private Button x96468a6307eec3e3;

	public CodeEntry xb0b4ff1622a01d12 => _b0b4ff1622a01d12;

	public event CancelEventHandler x33db2684576804ef;

	public x1536525b14cf2192()
	{
		x85601834555fb7d5();
		if (!CodeManagerSettings.Instance.AdvancedEditingEnabled || !x7bb28d9758d19dd0.x3b67f7a0ce62b49b)
		{
			x96468a6307eec3e3.Enabled = false;
			x96468a6307eec3e3.Visible = false;
		}
	}

	public static x1536525b14cf2192 xebcf83b00134300b(GameEntry Form, uint x28011ef2e60e6ef5, uint xba336f6c3ae33222, string x1c2743f354837549, string xc15bd84e01929885, string x77c5a31ec0891f38, params string[] xeb980cfa89af6e46)
	{
		x1536525b14cf2192 x1536525b14cf2193 = new x1536525b14cf2192();
		x1536525b14cf2193._c74ed71dea076128 = Form;
		x1536525b14cf2193._52b8174788d367f9 = x28011ef2e60e6ef5;
		x1536525b14cf2193._b3efee94cf138f44 = xba336f6c3ae33222;
		x1536525b14cf2193.Text = x1c2743f354837549;
		x1536525b14cf2193.x9592d68fcb5ab881.Text = xc15bd84e01929885;
		x1536525b14cf2193.x5ee38acf34ff0ae3.Text = x77c5a31ec0891f38;
		x1536525b14cf2193.xdd8dff12a799aaad.Lines = xeb980cfa89af6e46;
		x1536525b14cf2193.xdd8dff12a799aaad.Enabled = x7bb28d9758d19dd0.x3452082a8fecf97d;
		return x1536525b14cf2193;
	}

	protected virtual void OnAdditionalValidation(CancelEventArgs xfbf34718e704c6bc)
	{
		if (this.x33db2684576804ef != null)
		{
			this.x33db2684576804ef(this, xfbf34718e704c6bc);
		}
	}

	private CodeEntry xc9e97689bb4a5102()
	{
		CodeEntry codeEntry = new CodeEntry();
		codeEntry.Name = x9592d68fcb5ab881.Text.Trim();
		codeEntry.x4e020dae918bd2ce = x5ee38acf34ff0ae3.Text.Trim();
		try
		{
			codeEntry.CheatCodes = new Codes(xdd8dff12a799aaad.Lines);
		}
		catch (CodeLineException ex)
		{
			base.ActiveControl = xdd8dff12a799aaad;
			xdd8dff12a799aaad.Select(xdd8dff12a799aaad.GetFirstCharIndexFromLine(ex.LineIndex), ex.Line.Length);
			MessageBox.Show(this, "Code line invalid.", "Code error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			base.DialogResult = DialogResult.None;
			return null;
		}
		if (x7bb28d9758d19dd0.x3452082a8fecf97d)
		{
			List<string> list = x7bb28d9758d19dd0.x2731b90dfbad5cbc(new List<CodeEntry>(new CodeEntry[1] { codeEntry }));
			if (list.Count > 0)
			{
				base.ActiveControl = xdd8dff12a799aaad;
				MessageBox.Show(this, "There seems to be a problem with the code you've entered.\r\n\r\n" + string.Join("\r\n", list.ToArray()), "Code error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.DialogResult = DialogResult.None;
				return null;
			}
			if (codeEntry.xbe23edc82b0342c0 == null)
			{
				MessageBox.Show(this, "No error was reported, but something went wrong while trying to read the code you've entered.", "Code error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.DialogResult = DialogResult.None;
				return null;
			}
			if (codeEntry.xbe23edc82b0342c0.xd0431a295f2ed35f)
			{
				MessageBox.Show(this, "This code appears to have the Freaky Unknown Bit set.  Since we have no idea what that's for, we're not sure how to deal with it.  Please contact Mirality Systems providing details of the code in question and where you obtained it from.", "We don't know what that means", MessageBoxButtons.OK, MessageBoxIcon.Question);
				base.DialogResult = DialogResult.None;
				return null;
			}
			codeEntry.x548b1e187be884eb();
		}
		return codeEntry;
	}

	private void xeebb56e8f7be7895(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (x9592d68fcb5ab881.Text.Length == 0)
		{
			MessageBox.Show(this, "You must enter a name.", "Unnamed code", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			base.ActiveControl = x9592d68fcb5ab881;
			base.DialogResult = DialogResult.None;
			return;
		}
		if (xdd8dff12a799aaad.Text.Length == 0)
		{
			MessageBox.Show(this, "You must enter some code lines.", "No code lines", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			base.ActiveControl = xdd8dff12a799aaad;
			base.DialogResult = DialogResult.None;
			return;
		}
		CodeEntry codeEntry = xc9e97689bb4a5102();
		if (codeEntry != null)
		{
			_b0b4ff1622a01d12 = codeEntry;
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			OnAdditionalValidation(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
				base.DialogResult = DialogResult.None;
			}
		}
	}

	private void xdc66bf225631b236(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		CodeEntry codeEntry = null;
		if (xdd8dff12a799aaad.Text.Trim() != "")
		{
			codeEntry = xc9e97689bb4a5102();
			if (codeEntry == null)
			{
				return;
			}
		}
		using x1e80b3bb288f59a1 x1e80b3bb288f59a2 = new x1e80b3bb288f59a1(_c74ed71dea076128, codeEntry);
		x1e80b3bb288f59a2.Owner = this;
		if (x1e80b3bb288f59a2.ShowDialog() == DialogResult.OK)
		{
			xdd8dff12a799aaad.Lines = x1e80b3bb288f59a2.xe55cfc2215257397.CheatCodes.xa9edb3b115d067da();
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
		x9592d68fcb5ab881 = new TextBox();
		x5ee38acf34ff0ae3 = new TextBox();
		xdd8dff12a799aaad = new TextBox();
		x8c7441c6635b5683 = new Button();
		x77c138625e4a3561 = new Button();
		x96468a6307eec3e3 = new Button();
		Label label = new Label();
		Label label2 = new Label();
		Label label3 = new Label();
		Label label4 = new Label();
		SuspendLayout();
		label.Location = new Point(16, 11);
		label.Margin = new Padding(4, 0, 4, 0);
		label.Name = "label1";
		label.Size = new Size(79, 16);
		label.TabIndex = 0;
		label.Text = "Name:";
		label.TextAlign = ContentAlignment.MiddleRight;
		label2.Location = new Point(16, 43);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(79, 16);
		label2.TabIndex = 2;
		label2.Text = "Comments:";
		label2.TextAlign = ContentAlignment.MiddleRight;
		label3.Location = new Point(16, 75);
		label3.Margin = new Padding(4, 0, 4, 0);
		label3.Name = "label3";
		label3.Size = new Size(79, 16);
		label3.TabIndex = 4;
		label3.Text = "Code lines:";
		label3.TextAlign = ContentAlignment.MiddleRight;
		label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		label4.Location = new Point(99, 265);
		label4.Margin = new Padding(4, 0, 4, 0);
		label4.Name = "label4";
		label4.Size = new Size(357, 16);
		label4.TabIndex = 6;
		label4.Text = "(One codegroup [eg. RK6H-QTBZ-Z1AQJ] per line.)";
		x9592d68fcb5ab881.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x9592d68fcb5ab881.Location = new Point(103, 7);
		x9592d68fcb5ab881.Margin = new Padding(4);
		x9592d68fcb5ab881.Name = "textBoxName";
		x9592d68fcb5ab881.Size = new Size(356, 22);
		x9592d68fcb5ab881.TabIndex = 1;
		x5ee38acf34ff0ae3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x5ee38acf34ff0ae3.Location = new Point(103, 39);
		x5ee38acf34ff0ae3.Margin = new Padding(4);
		x5ee38acf34ff0ae3.Name = "textBoxComments";
		x5ee38acf34ff0ae3.Size = new Size(356, 22);
		x5ee38acf34ff0ae3.TabIndex = 3;
		xdd8dff12a799aaad.AcceptsReturn = true;
		xdd8dff12a799aaad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xdd8dff12a799aaad.CharacterCasing = CharacterCasing.Upper;
		xdd8dff12a799aaad.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xdd8dff12a799aaad.Location = new Point(103, 71);
		xdd8dff12a799aaad.Margin = new Padding(4);
		xdd8dff12a799aaad.Multiline = true;
		xdd8dff12a799aaad.Name = "textBoxLines";
		xdd8dff12a799aaad.Size = new Size(356, 189);
		xdd8dff12a799aaad.TabIndex = 5;
		x8c7441c6635b5683.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x8c7441c6635b5683.DialogResult = DialogResult.Cancel;
		x8c7441c6635b5683.Location = new Point(359, 286);
		x8c7441c6635b5683.Margin = new Padding(4);
		x8c7441c6635b5683.Name = "buttonCancel";
		x8c7441c6635b5683.Size = new Size(100, 28);
		x8c7441c6635b5683.TabIndex = 8;
		x8c7441c6635b5683.Text = "Cancel";
		x8c7441c6635b5683.UseVisualStyleBackColor = true;
		x77c138625e4a3561.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x77c138625e4a3561.DialogResult = DialogResult.OK;
		x77c138625e4a3561.Location = new Point(251, 286);
		x77c138625e4a3561.Margin = new Padding(4);
		x77c138625e4a3561.Name = "buttonOk";
		x77c138625e4a3561.Size = new Size(100, 28);
		x77c138625e4a3561.TabIndex = 7;
		x77c138625e4a3561.Text = "OK";
		x77c138625e4a3561.UseVisualStyleBackColor = true;
		x77c138625e4a3561.Click += xeebb56e8f7be7895;
		x96468a6307eec3e3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x96468a6307eec3e3.Location = new Point(102, 285);
		x96468a6307eec3e3.Margin = new Padding(4);
		x96468a6307eec3e3.Name = "buttonAdvanced";
		x96468a6307eec3e3.Size = new Size(100, 28);
		x96468a6307eec3e3.TabIndex = 9;
		x96468a6307eec3e3.Text = "Advanced...";
		x96468a6307eec3e3.UseVisualStyleBackColor = true;
		x96468a6307eec3e3.Click += xdc66bf225631b236;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = x8c7441c6635b5683;
		base.ClientSize = new Size(472, 327);
		base.Controls.Add(x96468a6307eec3e3);
		base.Controls.Add(x77c138625e4a3561);
		base.Controls.Add(x8c7441c6635b5683);
		base.Controls.Add(label4);
		base.Controls.Add(xdd8dff12a799aaad);
		base.Controls.Add(label3);
		base.Controls.Add(x5ee38acf34ff0ae3);
		base.Controls.Add(label2);
		base.Controls.Add(x9592d68fcb5ab881);
		base.Controls.Add(label);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "CodeEditorForm";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Code Editor";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
