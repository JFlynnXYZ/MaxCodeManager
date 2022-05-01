using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal class MainWindow : Form
{
	private Label x2bf08061840d07cb;

	private Container xb7dfc13308b54974;

	public bool x5c9e4e2dc9b12067
	{
		get
		{
			return base.Visible;
		}
		set
		{
			if (value)
			{
				x35579b297303ed43();
			}
			else
			{
				x5486e0b5e830d25c();
			}
		}
	}

	public string xd397bb1e465ce45e
	{
		get
		{
			return x2bf08061840d07cb.Text;
		}
		set
		{
			x2bf08061840d07cb.Text = value;
		}
	}

	public static MainWindow CreateMessageBox(Form Parent, string Message)
	{
		MainWindow x0ad6e0a9d6b71dfc2 = new MainWindow();
		x0ad6e0a9d6b71dfc2.x20aee281977480cf(Parent, Message);
		return x0ad6e0a9d6b71dfc2;
	}

	protected void x53b7203e935fcc6d()
	{
		if (Application.MessageLoop)
		{
			Application.DoEvents();
		}
	}

	protected void x20aee281977480cf(Form owner, string x399bfb4377fa76d2)
	{
		base.Owner = owner;
		xd397bb1e465ce45e = x399bfb4377fa76d2;
		x35579b297303ed43();
		x53b7203e935fcc6d();
	}

	protected MainWindow()
	{
		x85601834555fb7d5();
	}

	public void x35579b297303ed43()
	{
		Show();
		if (base.Owner != null)
		{
			base.Owner.Enabled = false;
		}
	}

	public void x5486e0b5e830d25c()
	{
		if (base.Owner != null)
		{
			base.Owner.Enabled = true;
		}
		Hide();
	}

	public void Message(string x5786461d089b10a0, params object[] xce8d8c7e3c2c2426)
	{
		xd397bb1e465ce45e = string.Format(CultureInfo.CurrentCulture, x5786461d089b10a0, xce8d8c7e3c2c2426);
		x53b7203e935fcc6d();
	}

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		x5486e0b5e830d25c();
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
		SuspendLayout();
		x2bf08061840d07cb.Dock = DockStyle.Fill;
		x2bf08061840d07cb.Location = new Point(0, 0);
		x2bf08061840d07cb.Name = "labelMessage";
		x2bf08061840d07cb.Size = new Size(442, 50);
		x2bf08061840d07cb.TabIndex = 0;
		x2bf08061840d07cb.Text = "(message)";
		x2bf08061840d07cb.TextAlign = ContentAlignment.MiddleCenter;
		AutoScaleBaseSize = new Size(8, 19);
		base.ClientSize = new Size(442, 50);
		base.ControlBox = false;
		base.Controls.Add(x2bf08061840d07cb);
		Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Name = "StatusForm";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		ResumeLayout(performLayout: false);
	}
}
