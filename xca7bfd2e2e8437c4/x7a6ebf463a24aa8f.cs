using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal class x7a6ebf463a24aa8f : Form
{
	public class x7ea5d7f562ca5f90
	{
		private readonly ProgressBar xced856c17df679c5;

		private int _d2f68ee6f47e9dfb;

		private int _2c167a39cabc8d00;

		public int xd2f68ee6f47e9dfb
		{
			get
			{
				return _d2f68ee6f47e9dfb;
			}
			set
			{
				if (value == _d2f68ee6f47e9dfb)
				{
					return;
				}
				_d2f68ee6f47e9dfb = value;
				if (xced856c17df679c5.InvokeRequired)
				{
					xced856c17df679c5.BeginInvoke((xc26a6690a33cd29d)delegate
					{
						xced856c17df679c5.Value = _d2f68ee6f47e9dfb;
					});
				}
				else
				{
					xced856c17df679c5.Value = _d2f68ee6f47e9dfb;
				}
			}
		}

		public int x2c167a39cabc8d00
		{
			get
			{
				return _2c167a39cabc8d00;
			}
			set
			{
				if (value == _2c167a39cabc8d00)
				{
					return;
				}
				_2c167a39cabc8d00 = value;
				if (xced856c17df679c5.InvokeRequired)
				{
					xced856c17df679c5.BeginInvoke((xc26a6690a33cd29d)delegate
					{
						xced856c17df679c5.Maximum = _2c167a39cabc8d00;
					});
				}
				else
				{
					xced856c17df679c5.Maximum = _2c167a39cabc8d00;
				}
			}
		}

		internal x7ea5d7f562ca5f90(ProgressBar x2ee8392f53a01b93)
		{
			xced856c17df679c5 = x2ee8392f53a01b93;
			_d2f68ee6f47e9dfb = x2ee8392f53a01b93.Value;
			_2c167a39cabc8d00 = x2ee8392f53a01b93.Maximum;
		}

		[CompilerGenerated]
		private void x5877505d50f07f01()
		{
			xced856c17df679c5.Value = _d2f68ee6f47e9dfb;
		}

		[CompilerGenerated]
		private void x7baeb2fa51ba2b38()
		{
			xced856c17df679c5.Maximum = _2c167a39cabc8d00;
		}
	}

	private Label x2bf08061840d07cb;

	private Container xb7dfc13308b54974;

	private Panel xe30a9ee77ac9ec35;

	private Button x8c7441c6635b5683;

	public string xd397bb1e465ce45e
	{
		get
		{
			return x2bf08061840d07cb.Text;
		}
		set
		{
			x2bf08061840d07cb.Text = value;
			xae19a615b411c9fa();
		}
	}

	public event EventHandler xd674415062c2b55f;

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		Hide();
		Application.DoEvents();
		if (xb41acd866d5cbca8 && xb7dfc13308b54974 != null)
		{
			xb7dfc13308b54974.Dispose();
		}
		base.Dispose(xb41acd866d5cbca8);
	}

	private void x85601834555fb7d5()
	{
		x2bf08061840d07cb = new Label();
		xe30a9ee77ac9ec35 = new Panel();
		x8c7441c6635b5683 = new Button();
		SuspendLayout();
		x2bf08061840d07cb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x2bf08061840d07cb.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x2bf08061840d07cb.Location = new Point(0, 0);
		x2bf08061840d07cb.Name = "labelMessage";
		x2bf08061840d07cb.Size = new Size(442, 31);
		x2bf08061840d07cb.TabIndex = 0;
		x2bf08061840d07cb.Text = "(message)";
		x2bf08061840d07cb.TextAlign = ContentAlignment.MiddleCenter;
		xe30a9ee77ac9ec35.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xe30a9ee77ac9ec35.Location = new Point(4, 34);
		xe30a9ee77ac9ec35.Name = "panelProgress";
		xe30a9ee77ac9ec35.Size = new Size(440, 0);
		xe30a9ee77ac9ec35.TabIndex = 1;
		x8c7441c6635b5683.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x8c7441c6635b5683.DialogResult = DialogResult.Cancel;
		x8c7441c6635b5683.Location = new Point(367, 40);
		x8c7441c6635b5683.Name = "buttonCancel";
		x8c7441c6635b5683.Size = new Size(75, 23);
		x8c7441c6635b5683.TabIndex = 2;
		x8c7441c6635b5683.Text = "Cancel";
		x8c7441c6635b5683.UseVisualStyleBackColor = true;
		x8c7441c6635b5683.Click += xa81c0d545d0b9cd5;
		AutoScaleBaseSize = new Size(5, 13);
		base.ClientSize = new Size(442, 65);
		base.ControlBox = false;
		base.Controls.Add(x8c7441c6635b5683);
		base.Controls.Add(xe30a9ee77ac9ec35);
		base.Controls.Add(x2bf08061840d07cb);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Name = "ProgressForm";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		ResumeLayout(performLayout: false);
	}

	public x7a6ebf463a24aa8f(Form owner, string x399bfb4377fa76d2, bool xfb54ea78556e1909)
	{
		x85601834555fb7d5();
		xe30a9ee77ac9ec35.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x8c7441c6635b5683.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x8c7441c6635b5683.Visible = xfb54ea78556e1909;
		base.CancelButton = (xfb54ea78556e1909 ? x8c7441c6635b5683 : null);
		base.Owner = owner;
		xd397bb1e465ce45e = x399bfb4377fa76d2;
	}

	protected virtual void OnCancel(EventArgs xfbf34718e704c6bc)
	{
		this.xd674415062c2b55f?.Invoke(this, xfbf34718e704c6bc);
	}

	private void xa81c0d545d0b9cd5(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		OnCancel(EventArgs.Empty);
	}

	private void xae19a615b411c9fa()
	{
		int num;
		using (Graphics graphics = x2bf08061840d07cb.CreateGraphics())
		{
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.HotkeyPrefix = HotkeyPrefix.None;
			num = (int)Math.Ceiling(graphics.MeasureString(xd397bb1e465ce45e, x2bf08061840d07cb.Font, int.MaxValue, stringFormat).Width) + 4;
		}
		Size clientSize = base.ClientSize;
		if (num > x2bf08061840d07cb.ClientSize.Width)
		{
			clientSize.Width = num + (clientSize.Width - x2bf08061840d07cb.ClientSize.Width);
		}
		clientSize.Height = (x8c7441c6635b5683.Visible ? (x8c7441c6635b5683.Bottom + 4) : x8c7441c6635b5683.Top);
		base.ClientSize = clientSize;
		Point point;
		if (base.Owner == null)
		{
			Rectangle workingArea = Screen.FromControl(this).WorkingArea;
			point = new Point((workingArea.Left + workingArea.Right) / 2, (workingArea.Top + workingArea.Bottom) / 2);
		}
		else
		{
			point = new Point((base.Owner.Left + base.Owner.Right) / 2, (base.Owner.Top + base.Owner.Bottom) / 2);
		}
		base.Location = new Point(point.X - base.Width / 2, point.Y - base.Height / 2);
	}

	public x7ea5d7f562ca5f90 xcf539de674423889()
	{
		if (base.InvokeRequired)
		{
			throw new InvalidOperationException("Can only add progress bars on the creating thread.");
		}
		ProgressBar progressBar = new ProgressBar();
		progressBar.SetBounds(xe30a9ee77ac9ec35.ClientRectangle.Left + 4, xe30a9ee77ac9ec35.ClientRectangle.Bottom, xe30a9ee77ac9ec35.ClientSize.Width - 8, 16);
		int num = x8c7441c6635b5683.Top - xe30a9ee77ac9ec35.Bottom;
		xe30a9ee77ac9ec35.Height += 20;
		x8c7441c6635b5683.Top = xe30a9ee77ac9ec35.Bottom + num;
		xe30a9ee77ac9ec35.Controls.Add(progressBar);
		xae19a615b411c9fa();
		return new x7ea5d7f562ca5f90(progressBar);
	}
}
