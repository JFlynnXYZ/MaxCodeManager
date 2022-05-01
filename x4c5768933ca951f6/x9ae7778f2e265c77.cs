using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.CodeManager.Properties;
using x3a260771fe762331;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class x9ae7778f2e265c77 : Form
{
	private Codelist xdbc26f54a18218e3;

	private Codelist xa072dfe9d0c72dab;

	private string xc4bf01dcdcfd7401;

	private string x5e8a99a389658183;

	private IContainer xb7dfc13308b54974;

	private TableLayoutPanel x7aef9b15a0092547;

	private Label x6c4228bd06b8af15;

	private Label x43cbdb48c56562ea;

	private xea5e4be807a4597b xc5cb9a9162810cac;

	private ImageList x379f3a3a3ed7e970;

	private ContextMenuStrip x168202ac0d494d83;

	private ToolStripMenuItem x0669d5d07a437ffb;

	private ToolStripMenuItem x81905070f8d5174e;

	public event EventHandler x978f28482caa2f52;

	public x9ae7778f2e265c77(string x13c3fb0565df0a72, Codelist x88efcf2300e59dda, string xac95817976f27543, Codelist x59d51a66ee1aa871)
	{
		x85601834555fb7d5();
		x379f3a3a3ed7e970.Images.Add("Game", Resources.Game);
		x379f3a3a3ed7e970.Images.Add("Code", Resources.UnknownCode);
		xc4bf01dcdcfd7401 = x13c3fb0565df0a72;
		xdbc26f54a18218e3 = x88efcf2300e59dda;
		x5e8a99a389658183 = xac95817976f27543;
		xa072dfe9d0c72dab = x59d51a66ee1aa871;
	}

	protected virtual void OnFavouriteGamesChanged(EventArgs xfbf34718e704c6bc)
	{
		if (this.x978f28482caa2f52 != null)
		{
			this.x978f28482caa2f52(this, xfbf34718e704c6bc);
		}
	}

	protected override void OnLoad(EventArgs xfbf34718e704c6bc)
	{
		x6c4228bd06b8af15.Text = xc4bf01dcdcfd7401;
		x43cbdb48c56562ea.Text = x5e8a99a389658183;
		base.OnLoad(xfbf34718e704c6bc);
	}

	protected override void OnShown(EventArgs xfbf34718e704c6bc)
	{
		base.OnShown(xfbf34718e704c6bc);
		x2990768153581b80();
	}

	private void x2990768153581b80()
	{
		xebcb243b84cc11d7 xebcb243b84cc11d;
		using (MainWindow.CreateMessageBox(this, "Calculating differences between codelists..."))
		{
			xebcb243b84cc11d = new xebcb243b84cc11d7(xdbc26f54a18218e3, xa072dfe9d0c72dab);
		}
		if (xebcb243b84cc11d.x5a80eb62c0d7189e.Count + xebcb243b84cc11d.x6a78f14f880171ac.Count > 200)
		{
			xc5cb9a9162810cac.Dispose();
			Label label = new Label();
			label.Font = new Font(label.Font.FontFamily, 10f);
			label.Text = "More than 200 games are different between the two codelists.\r\n\r\nMost likely this is because you're comparing two very different (and long) lists, such as comparing the official list with a custom or exported list.\r\n\r\nDisplaying that many changes would take an extremely long time, so we're not going to do it.";
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.ForeColor = Color.Red;
			x7aef9b15a0092547.Controls.Add(label, 0, 2);
			x7aef9b15a0092547.SetColumnSpan(label, 2);
			label.Dock = DockStyle.Fill;
			return;
		}
		xc5cb9a9162810cac.x5577363cc650aaeb();
		try
		{
			foreach (GameEntry item in xebcb243b84cc11d.x6a78f14f880171ac)
			{
				xccb35d3fb7874b48(xebcb243b84cc11d, item, Color.Red);
			}
			foreach (GameEntry item2 in xebcb243b84cc11d.xac7b02fee8234bcf)
			{
				xccb35d3fb7874b48(xebcb243b84cc11d, item2, Color.Orange);
			}
			foreach (GameEntry item3 in xebcb243b84cc11d.x5a80eb62c0d7189e)
			{
				xccb35d3fb7874b48(xebcb243b84cc11d, item3, Color.Green);
			}
		}
		finally
		{
			xc5cb9a9162810cac.x3ae2e4d73c7847ae();
		}
	}

	private void xccb35d3fb7874b48(xebcb243b84cc11d7 x778cad6dac263160, GameEntry game, Color x253107b6f4b9adf6)
	{
		x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00();
		x95fcf261e3011b.xf9ad6fb78355fe13 = string.Concat(game.Name, " (", game.Region, ")");
		x95fcf261e3011b.x7dd793a62d047456 = x253107b6f4b9adf6;
		x95fcf261e3011b.xc439cbba6c00a3a0 = "Game";
		x95fcf261e3011b.xd229d86af0f16fb0 = game;
		xc5cb9a9162810cac.x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
		foreach (CodeEntry item in game)
		{
			if (x778cad6dac263160.xc50b25ead802c791(item))
			{
				x38333c9abee64106(x95fcf261e3011b, item, Color.Green);
			}
			else if (x778cad6dac263160.x201282ef5b887ec3(item))
			{
				x38333c9abee64106(x95fcf261e3011b, item, Color.Red);
			}
			else if (x778cad6dac263160.xc4e77da306e0ec75(item))
			{
				x38333c9abee64106(x95fcf261e3011b, item, Color.Orange);
			}
			else
			{
				x38333c9abee64106(x95fcf261e3011b, item, SystemColors.ControlText);
			}
		}
	}

	private static void x38333c9abee64106(x95fcf261e3011b00 x9915c1f5b6422c36, CodeEntry code, Color xb24c2669665f2488)
	{
		x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00();
		x95fcf261e3011b.xf9ad6fb78355fe13 = code.Name;
		x95fcf261e3011b.x7dd793a62d047456 = xb24c2669665f2488;
		x95fcf261e3011b.xc439cbba6c00a3a0 = "Code";
		x95fcf261e3011b.xd229d86af0f16fb0 = code;
		x9915c1f5b6422c36.x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
	}

	private void x9a0c15b0be4688da(object xe0292b9ed559da7d, xfc646a3e9e0998cd xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.Button == MouseButtons.Right && xfbf34718e704c6bc.Clicks == 1)
		{
			x168202ac0d494d83.Show(xc5cb9a9162810cac, xfbf34718e704c6bc.Location);
		}
	}

	private static GameEntry x8169d08a2892e676(x95fcf261e3011b00 node)
	{
		GameEntry xa0380078f0b6cbb = node.xd229d86af0f16fb0 as GameEntry;
		if (xa0380078f0b6cbb == null && node.xd229d86af0f16fb0 is CodeEntry xbabc9feec6f641db)
		{
			xa0380078f0b6cbb = xbabc9feec6f641db.GameEntry;
		}
		return xa0380078f0b6cbb;
	}

	private void x96042277d364c6fa(object xe0292b9ed559da7d, CancelEventArgs xfbf34718e704c6bc)
	{
		if (xc5cb9a9162810cac.xc82eff4818ce3f25.Count != 1)
		{
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		x95fcf261e3011b00 xda5bf54deb817e = xc5cb9a9162810cac.xc82eff4818ce3f25[0];
		GameEntry xa0380078f0b6cbb = x8169d08a2892e676(xda5bf54deb817e);
		if (xa0380078f0b6cbb == null)
		{
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		bool flag = CodeManagerSettings.Instance.Favourites.Contains(xa0380078f0b6cbb.x52b8174788d367f9);
		x0669d5d07a437ffb.Enabled = !flag;
		x81905070f8d5174e.Enabled = flag;
	}

	private void x4b125779b5d1e26a(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (xc5cb9a9162810cac.xc82eff4818ce3f25.Count == 1)
		{
			x95fcf261e3011b00 xda5bf54deb817e = xc5cb9a9162810cac.xc82eff4818ce3f25[0];
			GameEntry xa0380078f0b6cbb = x8169d08a2892e676(xda5bf54deb817e);
			if (xa0380078f0b6cbb != null)
			{
				CodeManagerSettings.Instance.Favourites.Add(new FavouriteGame(xa0380078f0b6cbb.x52b8174788d367f9, xa0380078f0b6cbb.Name, xa0380078f0b6cbb.Region));
				OnFavouriteGamesChanged(EventArgs.Empty);
			}
		}
	}

	private void xb19046d3f84ca3f3(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (xc5cb9a9162810cac.xc82eff4818ce3f25.Count == 1)
		{
			x95fcf261e3011b00 xda5bf54deb817e = xc5cb9a9162810cac.xc82eff4818ce3f25[0];
			GameEntry xa0380078f0b6cbb = x8169d08a2892e676(xda5bf54deb817e);
			if (xa0380078f0b6cbb != null)
			{
				CodeManagerSettings.Instance.Favourites.Remove(xa0380078f0b6cbb.x52b8174788d367f9);
				OnFavouriteGamesChanged(EventArgs.Empty);
			}
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
		xb7dfc13308b54974 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(x9ae7778f2e265c77));
		x6c4228bd06b8af15 = new Label();
		x43cbdb48c56562ea = new Label();
		x7aef9b15a0092547 = new TableLayoutPanel();
		xc5cb9a9162810cac = new xea5e4be807a4597b();
		x379f3a3a3ed7e970 = new ImageList(xb7dfc13308b54974);
		x168202ac0d494d83 = new ContextMenuStrip(xb7dfc13308b54974);
		x0669d5d07a437ffb = new ToolStripMenuItem();
		x81905070f8d5174e = new ToolStripMenuItem();
		Label label = new Label();
		Label label2 = new Label();
		Button button = new Button();
		x7aef9b15a0092547.SuspendLayout();
		x168202ac0d494d83.SuspendLayout();
		SuspendLayout();
		label.Dock = DockStyle.Fill;
		label.Location = new Point(3, 0);
		label.Name = "label1";
		label.Size = new Size(54, 20);
		label.TabIndex = 1;
		label.Text = "From:";
		label.TextAlign = ContentAlignment.MiddleRight;
		label2.Dock = DockStyle.Fill;
		label2.Location = new Point(3, 20);
		label2.Name = "label3";
		label2.Size = new Size(54, 20);
		label2.TabIndex = 3;
		label2.Text = "To:";
		label2.TextAlign = ContentAlignment.MiddleRight;
		button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button.DialogResult = DialogResult.Cancel;
		button.Location = new Point(424, 309);
		button.Name = "buttonClose";
		button.Size = new Size(75, 23);
		button.TabIndex = 0;
		button.Text = "Close";
		button.UseVisualStyleBackColor = true;
		x6c4228bd06b8af15.Dock = DockStyle.Fill;
		x6c4228bd06b8af15.Location = new Point(63, 0);
		x6c4228bd06b8af15.Name = "labelFrom";
		x6c4228bd06b8af15.Size = new Size(436, 20);
		x6c4228bd06b8af15.TabIndex = 2;
		x6c4228bd06b8af15.Text = "(first list)";
		x6c4228bd06b8af15.TextAlign = ContentAlignment.MiddleLeft;
		x43cbdb48c56562ea.Dock = DockStyle.Fill;
		x43cbdb48c56562ea.Location = new Point(63, 20);
		x43cbdb48c56562ea.Name = "labelTo";
		x43cbdb48c56562ea.Size = new Size(436, 20);
		x43cbdb48c56562ea.TabIndex = 4;
		x43cbdb48c56562ea.Text = "(second list)";
		x43cbdb48c56562ea.TextAlign = ContentAlignment.MiddleLeft;
		x7aef9b15a0092547.ColumnCount = 2;
		x7aef9b15a0092547.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60f));
		x7aef9b15a0092547.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		x7aef9b15a0092547.Controls.Add(x43cbdb48c56562ea, 1, 1);
		x7aef9b15a0092547.Controls.Add(label2, 0, 1);
		x7aef9b15a0092547.Controls.Add(x6c4228bd06b8af15, 1, 0);
		x7aef9b15a0092547.Controls.Add(label, 0, 0);
		x7aef9b15a0092547.Controls.Add(xc5cb9a9162810cac, 0, 2);
		x7aef9b15a0092547.Controls.Add(button, 1, 3);
		x7aef9b15a0092547.Dock = DockStyle.Fill;
		x7aef9b15a0092547.Location = new Point(4, 4);
		x7aef9b15a0092547.Name = "tableLayoutPanel1";
		x7aef9b15a0092547.RowCount = 4;
		x7aef9b15a0092547.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		x7aef9b15a0092547.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		x7aef9b15a0092547.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		x7aef9b15a0092547.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
		x7aef9b15a0092547.Size = new Size(502, 336);
		x7aef9b15a0092547.TabIndex = 0;
		x7aef9b15a0092547.SetColumnSpan(xc5cb9a9162810cac, 2);
		xc5cb9a9162810cac.x5b1e6d73a61cb6dc = 18;
		xc5cb9a9162810cac.Dock = DockStyle.Fill;
		xc5cb9a9162810cac.x7bc501a48fc6524b = x379f3a3a3ed7e970;
		xc5cb9a9162810cac.Location = new Point(3, 43);
		xc5cb9a9162810cac.Name = "treeViewDifferences";
		xc5cb9a9162810cac.Size = new Size(496, 260);
		xc5cb9a9162810cac.TabIndex = 5;
		xc5cb9a9162810cac.xa1547aa59dafcb58 += x9a0c15b0be4688da;
		x379f3a3a3ed7e970.ColorDepth = ColorDepth.Depth8Bit;
		x379f3a3a3ed7e970.ImageSize = new Size(16, 16);
		x379f3a3a3ed7e970.TransparentColor = Color.Transparent;
		x168202ac0d494d83.Items.AddRange(new ToolStripItem[2] { x0669d5d07a437ffb, x81905070f8d5174e });
		x168202ac0d494d83.Name = "contextMenuDifferences";
		x168202ac0d494d83.Size = new Size(223, 70);
		x168202ac0d494d83.Opening += x96042277d364c6fa;
		x0669d5d07a437ffb.Name = "menuItemAddToFavourites";
		x0669d5d07a437ffb.Size = new Size(222, 22);
		x0669d5d07a437ffb.Text = "Add to Favourite Games";
		x0669d5d07a437ffb.Click += x4b125779b5d1e26a;
		x81905070f8d5174e.Name = "menuItemRemoveFromFavourites";
		x81905070f8d5174e.Size = new Size(222, 22);
		x81905070f8d5174e.Text = "Remove from Favourite Games";
		x81905070f8d5174e.Click += xb19046d3f84ca3f3;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = button;
		base.ClientSize = new Size(510, 344);
		base.Controls.Add(x7aef9b15a0092547);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		MinimumSize = new Size(518, 378);
		base.Name = "CodelistDifferencesForm";
		base.Padding = new Padding(4);
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Codelist Differences";
		x7aef9b15a0092547.ResumeLayout(performLayout: false);
		x168202ac0d494d83.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
