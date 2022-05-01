using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.MaxCodes;
using x2ac61696da69bb5f;
using x3a260771fe762331;
using x7fd6e610350f13fb;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class xfddbe928036d80d4 : Form
{
	private Button xded04841844e5e10;

	private Label xa5a110d1e71b7f6a;

	private Button x7c91dc8a087702ad;

	private x70c0f08fb6e896c2 xb12f33985116d9ca;

	private Label x33eb426bf00ce1b7;

	private Container xb7dfc13308b54974;

	private TableLayoutPanel x343a9040949ce860;

	private Button xa0496d56d1df92be;

	private Button x2d3c483898413ee9;

	private Button xe0ba4dbbbfffc0cd;

	private Button xf9c9e64e6f6c5f22;

	private Button x895e4a971b163d02;

	private GameEntry _a0380078f0b6cbb7;

	private GameEntry _34ec3a293021c833;

	private Codelist _2e26bc427243234e;

	private Codelist _93c06c96f0e1cbb2;

	private bool _953c89447b7e8f96;

	private CodeEntry _98d83af30fd99cf7;

	[CompilerGenerated]
	private static Converter<xfd5dc9a89edfa955, string> xb52cc720056569fd;

	public event EventHandler x978f28482caa2f52;

	public event EventHandler xcded22aefe17fee1;

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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(xfddbe928036d80d4));
		xded04841844e5e10 = new Button();
		xa5a110d1e71b7f6a = new Label();
		x7c91dc8a087702ad = new Button();
		x33eb426bf00ce1b7 = new Label();
		x343a9040949ce860 = new TableLayoutPanel();
		x895e4a971b163d02 = new Button();
		xf9c9e64e6f6c5f22 = new Button();
		x2d3c483898413ee9 = new Button();
		xe0ba4dbbbfffc0cd = new Button();
		xa0496d56d1df92be = new Button();
		xb12f33985116d9ca = new x70c0f08fb6e896c2();
		x343a9040949ce860.SuspendLayout();
		SuspendLayout();
		xded04841844e5e10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		xded04841844e5e10.DialogResult = DialogResult.OK;
		xded04841844e5e10.Location = new Point(664, 472);
		xded04841844e5e10.Name = "buttonClose";
		xded04841844e5e10.Size = new Size(75, 23);
		xded04841844e5e10.TabIndex = 1;
		xded04841844e5e10.Text = "Close";
		xa5a110d1e71b7f6a.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		xa5a110d1e71b7f6a.Location = new Point(8, 472);
		xa5a110d1e71b7f6a.Name = "labelIsFavourite";
		xa5a110d1e71b7f6a.Size = new Size(220, 23);
		xa5a110d1e71b7f6a.TabIndex = 2;
		xa5a110d1e71b7f6a.Text = "(is this one of your favourite games?)";
		xa5a110d1e71b7f6a.TextAlign = ContentAlignment.MiddleLeft;
		x7c91dc8a087702ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x7c91dc8a087702ad.Location = new Point(232, 472);
		x7c91dc8a087702ad.Name = "buttonAddRemoveFavourite";
		x7c91dc8a087702ad.Size = new Size(192, 23);
		x7c91dc8a087702ad.TabIndex = 3;
		x7c91dc8a087702ad.Text = "A/R from Favourite Games";
		x7c91dc8a087702ad.Click += x5b27566a149ba07b;
		x33eb426bf00ce1b7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x33eb426bf00ce1b7.Location = new Point(12, 9);
		x33eb426bf00ce1b7.Name = "labelInfo";
		x33eb426bf00ce1b7.Size = new Size(732, 18);
		x33eb426bf00ce1b7.TabIndex = 5;
		x33eb426bf00ce1b7.Text = "(information)";
		x33eb426bf00ce1b7.TextAlign = ContentAlignment.MiddleCenter;
		x343a9040949ce860.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x343a9040949ce860.ColumnCount = 6;
		x343a9040949ce860.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.06266f));
		x343a9040949ce860.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.06265f));
		x343a9040949ce860.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.06265f));
		x343a9040949ce860.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.962406f));
		x343a9040949ce860.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.924811f));
		x343a9040949ce860.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.924811f));
		x343a9040949ce860.Controls.Add(x895e4a971b163d02, 5, 0);
		x343a9040949ce860.Controls.Add(xf9c9e64e6f6c5f22, 4, 0);
		x343a9040949ce860.Controls.Add(x2d3c483898413ee9, 2, 0);
		x343a9040949ce860.Controls.Add(xe0ba4dbbbfffc0cd, 1, 0);
		x343a9040949ce860.Controls.Add(xa0496d56d1df92be, 0, 0);
		x343a9040949ce860.Location = new Point(8, 436);
		x343a9040949ce860.Name = "tableLayoutPanelEditButtons";
		x343a9040949ce860.RowCount = 1;
		x343a9040949ce860.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		x343a9040949ce860.Size = new Size(736, 29);
		x343a9040949ce860.TabIndex = 6;
		x895e4a971b163d02.Dock = DockStyle.Fill;
		x895e4a971b163d02.Location = new Point(664, 3);
		x895e4a971b163d02.Name = "buttonMoveDown";
		x895e4a971b163d02.Size = new Size(69, 23);
		x895e4a971b163d02.TabIndex = 4;
		x895e4a971b163d02.Text = "Down";
		x895e4a971b163d02.UseVisualStyleBackColor = true;
		x895e4a971b163d02.Click += x1e969d802d5c3926;
		xf9c9e64e6f6c5f22.Dock = DockStyle.Fill;
		xf9c9e64e6f6c5f22.Location = new Point(591, 3);
		xf9c9e64e6f6c5f22.Name = "buttonMoveUp";
		xf9c9e64e6f6c5f22.Size = new Size(67, 23);
		xf9c9e64e6f6c5f22.TabIndex = 3;
		xf9c9e64e6f6c5f22.Text = "Up";
		xf9c9e64e6f6c5f22.UseVisualStyleBackColor = true;
		xf9c9e64e6f6c5f22.Click += x9e027a2f29b8fa57;
		x2d3c483898413ee9.Dock = DockStyle.Fill;
		x2d3c483898413ee9.Location = new Point(371, 3);
		x2d3c483898413ee9.Name = "buttonDeleteCode";
		x2d3c483898413ee9.Size = new Size(178, 23);
		x2d3c483898413ee9.TabIndex = 2;
		x2d3c483898413ee9.Text = "Delete Code";
		x2d3c483898413ee9.UseVisualStyleBackColor = true;
		x2d3c483898413ee9.Click += xfe4cd7a960520cf8;
		xe0ba4dbbbfffc0cd.Dock = DockStyle.Fill;
		xe0ba4dbbbfffc0cd.Location = new Point(187, 3);
		xe0ba4dbbbfffc0cd.Name = "buttonEditCode";
		xe0ba4dbbbfffc0cd.Size = new Size(178, 23);
		xe0ba4dbbbfffc0cd.TabIndex = 1;
		xe0ba4dbbbfffc0cd.Text = "Edit Code...";
		xe0ba4dbbbfffc0cd.UseVisualStyleBackColor = true;
		xe0ba4dbbbfffc0cd.Click += xe6160cc5c4b1e084;
		xa0496d56d1df92be.Dock = DockStyle.Fill;
		xa0496d56d1df92be.Location = new Point(3, 3);
		xa0496d56d1df92be.Name = "buttonAddCode";
		xa0496d56d1df92be.Size = new Size(178, 23);
		xa0496d56d1df92be.TabIndex = 0;
		xa0496d56d1df92be.Text = "Add Code...";
		xa0496d56d1df92be.UseVisualStyleBackColor = true;
		xa0496d56d1df92be.Click += xf9db0d756e7ece95;
		xb12f33985116d9ca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xb12f33985116d9ca.x5b1e6d73a61cb6dc = 34;
		xb12f33985116d9ca.Location = new Point(8, 30);
		xb12f33985116d9ca.Name = "gameCodeListControl";
		xb12f33985116d9ca.Size = new Size(736, 400);
		xb12f33985116d9ca.TabIndex = 4;
		xb12f33985116d9ca.x4d9c819fe95edefe += x6cf04c1511939d4f;
		xb12f33985116d9ca.x1087ddccf8f41e6f += x7433f389cf415367;
		AutoScaleBaseSize = new Size(5, 13);
		base.ClientSize = new Size(752, 506);
		base.Controls.Add(x343a9040949ce860);
		base.Controls.Add(x33eb426bf00ce1b7);
		base.Controls.Add(xb12f33985116d9ca);
		base.Controls.Add(x7c91dc8a087702ad);
		base.Controls.Add(xa5a110d1e71b7f6a);
		base.Controls.Add(xded04841844e5e10);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		MinimumSize = new Size(528, 380);
		base.Name = "GameViewerForm";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Game Viewer";
		x343a9040949ce860.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public xfddbe928036d80d4(GameEntry game, bool xb2838c57f7b8cd66, Codelist xd75e60e5e359bba6, Codelist x674c7a44ab7af2f3, GameEntry x44f5de605a235763)
		: this(game)
	{
		_953c89447b7e8f96 = xb2838c57f7b8cd66;
		_2e26bc427243234e = xd75e60e5e359bba6;
		_93c06c96f0e1cbb2 = x674c7a44ab7af2f3;
		_34ec3a293021c833 = x44f5de605a235763;
	}

	public xfddbe928036d80d4(GameEntry game)
	{
		x85601834555fb7d5();
		_a0380078f0b6cbb7 = game;
	}

	protected override void OnLoad(EventArgs xfbf34718e704c6bc)
	{
		base.OnLoad(xfbf34718e704c6bc);
		x64ab53689bd4a83f();
		x73a8c99fbebc78cc();
		x4de6baa257d6560c();
		if (!_953c89447b7e8f96)
		{
			x343a9040949ce860.Enabled = false;
			x343a9040949ce860.Visible = false;
			xb12f33985116d9ca.Height += x343a9040949ce860.Bottom - xb12f33985116d9ca.Bottom;
		}
	}

	private void x64ab53689bd4a83f()
	{
		xb12f33985116d9ca.xa0380078f0b6cbb7 = new x717219df0ea9ffd3(_a0380078f0b6cbb7, _34ec3a293021c833);
		x33eb426bf00ce1b7.Text = string.Format(CultureInfo.CurrentCulture, "ID: {0}   Region: {1}        Code count: {2}        Memory used: {3}", _a0380078f0b6cbb7.x52b8174788d367f9, _a0380078f0b6cbb7.Region, _a0380078f0b6cbb7.xd44988f225497f3a, x289f1a0ee2f795a7.xf0dac06e79e03a32(_a0380078f0b6cbb7.xd38f244fb61873da));
	}

	private void x73a8c99fbebc78cc()
	{
		if (CodeManagerSettings.Instance.Favourites.Contains(_a0380078f0b6cbb7.x52b8174788d367f9))
		{
			xa5a110d1e71b7f6a.Text = "This game is one of your favourites.";
			xa5a110d1e71b7f6a.ForeColor = Color.Green;
			x7c91dc8a087702ad.Text = "Remove from favourites";
		}
		else
		{
			xa5a110d1e71b7f6a.Text = "This game is NOT one of your favourites.";
			xa5a110d1e71b7f6a.ForeColor = Color.Red;
			x7c91dc8a087702ad.Text = "Add to favourites";
		}
	}

	private void x5b27566a149ba07b(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (CodeManagerSettings.Instance.Favourites.Contains(_a0380078f0b6cbb7.x52b8174788d367f9))
		{
			CodeManagerSettings.Instance.Favourites.Remove(_a0380078f0b6cbb7.x52b8174788d367f9);
		}
		else
		{
			CodeManagerSettings.Instance.Favourites.Add(new FavouriteGame(_a0380078f0b6cbb7.x52b8174788d367f9, _a0380078f0b6cbb7.Name, _a0380078f0b6cbb7.Region));
		}
		OnFavouriteGamesChanged(EventArgs.Empty);
		x73a8c99fbebc78cc();
	}

	protected virtual void OnFavouriteGamesChanged(EventArgs xfbf34718e704c6bc)
	{
		if (this.x978f28482caa2f52 != null)
		{
			this.x978f28482caa2f52(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnActiveListChanged(EventArgs xfbf34718e704c6bc)
	{
		if (this.xcded22aefe17fee1 != null)
		{
			this.xcded22aefe17fee1(this, xfbf34718e704c6bc);
		}
	}

	private void x7433f389cf415367(object xe0292b9ed559da7d, x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		x4de6baa257d6560c();
	}

	private void x4de6baa257d6560c()
	{
		xa0496d56d1df92be.Enabled = x7bb28d9758d19dd0.x3452082a8fecf97d;
		if (_953c89447b7e8f96)
		{
			bool enabled = xb12f33985116d9ca.x30a02e7cd22d73f3.Count == 1;
			xe0ba4dbbbfffc0cd.Enabled = enabled;
			x2d3c483898413ee9.Enabled = x9300b78fd2ea73c9();
			xf9c9e64e6f6c5f22.Enabled = xb12f33985116d9ca.x9a39398ee4ef5b5f();
			x895e4a971b163d02.Enabled = xb12f33985116d9ca.xb46e47a96f30797b();
		}
		else
		{
			xa0496d56d1df92be.Enabled = false;
			xe0ba4dbbbfffc0cd.Enabled = false;
			x2d3c483898413ee9.Enabled = false;
			xf9c9e64e6f6c5f22.Enabled = false;
			x895e4a971b163d02.Enabled = false;
		}
	}

	private bool x9300b78fd2ea73c9()
	{
		foreach (xfd5dc9a89edfa955 item in xb12f33985116d9ca.x30a02e7cd22d73f3)
		{
			if (item.x8c84b6fad60c11f5 && !item.xb0b4ff1622a01d12.xda8f238d1a051872)
			{
				return true;
			}
		}
		return false;
	}

	private void xf0cf3100aca6f962()
	{
		_a0380078f0b6cbb7.x93b8c3e46ffd8a96();
		x64ab53689bd4a83f();
		x4de6baa257d6560c();
		if (CodeManagerSettings.Instance.Favourites.Contains(_a0380078f0b6cbb7.x52b8174788d367f9))
		{
			OnFavouriteGamesChanged(EventArgs.Empty);
		}
	}

	private void x9e027a2f29b8fa57(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xb12f33985116d9ca.x30e215f891925def();
		OnActiveListChanged(EventArgs.Empty);
	}

	private void x1e969d802d5c3926(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xb12f33985116d9ca.x6f0363886d340825();
		OnActiveListChanged(EventArgs.Empty);
	}

	private void xf9db0d756e7ece95(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		_98d83af30fd99cf7 = null;
		using x1536525b14cf2192 x1536525b14cf2193 = x1536525b14cf2192.xebcf83b00134300b(_a0380078f0b6cbb7, _a0380078f0b6cbb7.x52b8174788d367f9, 0u, "Add Code", "(code name)", "");
		x1536525b14cf2193.x33db2684576804ef += x43bf237084b5d838;
		if (x1536525b14cf2193.ShowDialog(this) == DialogResult.OK)
		{
			_a0380078f0b6cbb7.xd6b6ed77479ef68c(x1536525b14cf2193.xb0b4ff1622a01d12);
			OnActiveListChanged(EventArgs.Empty);
			xf0cf3100aca6f962();
		}
	}

	private void xe6160cc5c4b1e084(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xfd5dc9a89edfa955 xce39df0ea08992be = xb12f33985116d9ca.x30a02e7cd22d73f3[0];
		if (xce39df0ea08992be.xa157de8185757b11)
		{
			if (MessageBox.Show(this, "Since the code \"" + xce39df0ea08992be.xb0b4ff1622a01d12.Name + "\" is currently being inherited from another list, it will have to be imported to this list before you can edit it.\r\n\r\nDo you want to import the code?", "Edit inherited code", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			xe23f53c058cd6a76(ref xce39df0ea08992be);
		}
		_98d83af30fd99cf7 = xce39df0ea08992be.xb0b4ff1622a01d12;
		if (_98d83af30fd99cf7.xda8f238d1a051872)
		{
			using (x1536525b14cf2192 x1536525b14cf2193 = x1536525b14cf2192.xebcf83b00134300b(null, _a0380078f0b6cbb7.x52b8174788d367f9, _98d83af30fd99cf7.xb3efee94cf138f44, "Edit Game", _a0380078f0b6cbb7.Name, _a0380078f0b6cbb7.x4e020dae918bd2ce, _98d83af30fd99cf7.CheatCodes.xa9edb3b115d067da()))
			{
				x1536525b14cf2193.x33db2684576804ef += x73dea472e6eda521;
				if (x1536525b14cf2193.ShowDialog(this) == DialogResult.OK)
				{
					_a0380078f0b6cbb7.Name = x1536525b14cf2193.xb0b4ff1622a01d12.Name;
					_a0380078f0b6cbb7.x4e020dae918bd2ce = x1536525b14cf2193.xb0b4ff1622a01d12.x4e020dae918bd2ce;
					if (x7bb28d9758d19dd0.x3452082a8fecf97d)
					{
						x1536525b14cf2193.xb0b4ff1622a01d12.Name = "(M)";
						x1536525b14cf2193.xb0b4ff1622a01d12.x4e020dae918bd2ce = "";
						_a0380078f0b6cbb7.x57bf52bb3d1c2d43(_98d83af30fd99cf7, x1536525b14cf2193.xb0b4ff1622a01d12);
					}
					OnActiveListChanged(EventArgs.Empty);
					xf0cf3100aca6f962();
				}
				return;
			}
		}
		using x1536525b14cf2192 x1536525b14cf2194 = x1536525b14cf2192.xebcf83b00134300b(_a0380078f0b6cbb7, _a0380078f0b6cbb7.x52b8174788d367f9, _98d83af30fd99cf7.xb3efee94cf138f44, "Edit Code", _98d83af30fd99cf7.Name, _98d83af30fd99cf7.x4e020dae918bd2ce, _98d83af30fd99cf7.CheatCodes.xa9edb3b115d067da());
		x1536525b14cf2194.x33db2684576804ef += x43bf237084b5d838;
		if (x1536525b14cf2194.ShowDialog(this) == DialogResult.OK)
		{
			if (x7bb28d9758d19dd0.x3452082a8fecf97d)
			{
				_a0380078f0b6cbb7.x57bf52bb3d1c2d43(_98d83af30fd99cf7, x1536525b14cf2194.xb0b4ff1622a01d12);
			}
			else
			{
				_98d83af30fd99cf7.Name = x1536525b14cf2194.xb0b4ff1622a01d12.Name;
				_98d83af30fd99cf7.x4e020dae918bd2ce = x1536525b14cf2194.xb0b4ff1622a01d12.x4e020dae918bd2ce;
			}
			OnActiveListChanged(EventArgs.Empty);
			xf0cf3100aca6f962();
		}
	}

	private void xe23f53c058cd6a76(ref xfd5dc9a89edfa955 xce39df0ea08992be)
	{
		for (x95fcf261e3011b00 x95fcf261e3011b = xb12f33985116d9ca.x394a3caa61f59fc1(xce39df0ea08992be); x95fcf261e3011b != null; x95fcf261e3011b = x95fcf261e3011b.x332a8eedb847940d)
		{
			xfd5dc9a89edfa955 xfd5dc9a89edfa = xb12f33985116d9ca.x9559a72e127afe45(x95fcf261e3011b);
			if (xfd5dc9a89edfa.xa157de8185757b11)
			{
				_a0380078f0b6cbb7.xd6b6ed77479ef68c(xfd5dc9a89edfa.xb0b4ff1622a01d12.Clone());
			}
		}
		OnActiveListChanged(EventArgs.Empty);
		xf0cf3100aca6f962();
		xce39df0ea08992be = xb12f33985116d9ca.x9559a72e127afe45(xb12f33985116d9ca.x394a3caa61f59fc1(xce39df0ea08992be));
	}

	private void x6cf04c1511939d4f(object xe0292b9ed559da7d, xfc646a3e9e0998cd xfbf34718e704c6bc)
	{
		xe0ba4dbbbfffc0cd.PerformClick();
	}

	private List<xfd5dc9a89edfa955> x80673b11884fe0df()
	{
		List<xfd5dc9a89edfa955> list = new List<xfd5dc9a89edfa955>();
		foreach (xfd5dc9a89edfa955 item in xb12f33985116d9ca.x30a02e7cd22d73f3)
		{
			x117337ce27d4fd1d(list, item);
		}
		return list;
	}

	private void x117337ce27d4fd1d(List<xfd5dc9a89edfa955> codes, xfd5dc9a89edfa955 code)
	{
		codes.Add(code);
		x95fcf261e3011b00 x95fcf261e3011b = xb12f33985116d9ca.x394a3caa61f59fc1(code);
		foreach (x95fcf261e3011b00 item in x95fcf261e3011b.x63b0f7fed3f5bd88)
		{
			x117337ce27d4fd1d(codes, xb12f33985116d9ca.x9559a72e127afe45(item));
		}
	}

	private void xfe4cd7a960520cf8(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		List<xfd5dc9a89edfa955> list = new List<xfd5dc9a89edfa955>();
		List<xfd5dc9a89edfa955> list2 = new List<xfd5dc9a89edfa955>();
		foreach (xfd5dc9a89edfa955 item in x80673b11884fe0df())
		{
			if (item.x8c84b6fad60c11f5)
			{
				if (item.xad1420ffae650ce4)
				{
					list2.Add(item);
				}
				else
				{
					list.Add(item);
				}
			}
		}
		if (!xd8d81183209e6ec2(list, "Are you sure you want to delete the code \"{0}\"?  If you haven't saved it somewhere else, you won't be able to get it back.", "Are you sure you want to delete the following codes?  If you haven't saved them somewhere else, you won't be able to get them back.") || !xd8d81183209e6ec2(list2, "Are you sure you want to delete the code \"{0}\"?  This will remove any changes you've made to the code and revert it to the inherited state.", "Are you sure you want to delete the following codes?  This will remove any changes you've made to the codes and revert them to the inherited state."))
		{
			return;
		}
		list.AddRange(list2);
		if (list.Count == 0)
		{
			return;
		}
		foreach (xfd5dc9a89edfa955 item2 in list)
		{
			_a0380078f0b6cbb7.x52b190e626f65140(item2.x5744d14068b65123);
		}
		OnActiveListChanged(EventArgs.Empty);
		xf0cf3100aca6f962();
	}

	private bool xd8d81183209e6ec2(List<xfd5dc9a89edfa955> codes, string xefcf7129d727243c, string x9966935a0d195c56)
	{
		if (codes.Count == 1)
		{
			switch (MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, xefcf7129d727243c, codes[0].xb0b4ff1622a01d12.Name), "Confirm deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
			{
			case DialogResult.Cancel:
				return false;
			case DialogResult.No:
				codes.Clear();
				break;
			}
		}
		else if (codes.Count > 1)
		{
			string[] array = codes.ConvertAll((xfd5dc9a89edfa955 code) => code.xb0b4ff1622a01d12.Name).ToArray();
			if (array.Length > 25)
			{
				array[20] = "( + " + (array.Length - 20) + " other codes )";
				Array.Resize(ref array, 21);
			}
			switch (MessageBox.Show(this, x9966935a0d195c56 + "\r\n  " + string.Join("\r\n  ", array), "Confirm deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
			{
			case DialogResult.Cancel:
				return false;
			case DialogResult.No:
				codes.Clear();
				break;
			}
		}
		return true;
	}

	private void x73dea472e6eda521(object xe0292b9ed559da7d, CancelEventArgs xfbf34718e704c6bc)
	{
		x1536525b14cf2192 x1536525b14cf2193 = (x1536525b14cf2192)xe0292b9ed559da7d;
		CodeEntry xb0b4ff1622a01d = x1536525b14cf2193.xb0b4ff1622a01d12;
		if (!xb0b4ff1622a01d.xda8f238d1a051872)
		{
			MessageBox.Show(x1536525b14cf2193, "This does not appear to be a master (M) code.  Make sure you're entering the (M) code.", "Need master code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		if (x289f1a0ee2f795a7.x4f90d54847434178(xb0b4ff1622a01d.Name, "(M)") || x289f1a0ee2f795a7.x4f90d54847434178(xb0b4ff1622a01d.Name, "M"))
		{
			MessageBox.Show(x1536525b14cf2193, "Please use the game's name, not (M).", "Need game name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		if (_a0380078f0b6cbb7.x52b8174788d367f9 != xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9)
		{
			MessageBox.Show(x1536525b14cf2193, "The game's id has changed.  Either you've accidentally entered the wrong code or the code authors have changed the id for some reason (perhaps to prevent a clash).  However it is not possible for MCM to change the id of an existing game -- if you are certain you're using the correct code you will need to add a new game (and possibly remove the old one).", "Game id changed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		if (_98d83af30fd99cf7.xb3efee94cf138f44 != xb0b4ff1622a01d.xbe23edc82b0342c0.xb3efee94cf138f44)
		{
			if (MessageBox.Show(x1536525b14cf2193, "The code's id has changed.  Either you've accidentally entered the wrong code or the code authors have changed the id for some reason (perhaps to prevent a clash).  If this was not intentional, then this could result in a clash with another game or code.\r\n\r\nAre you sure you've entered the correct code?", "Code id changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				xfbf34718e704c6bc.Cancel = true;
				return;
			}
			CodeEntry codeEntry = _93c06c96f0e1cbb2.x13d95bb225c01867(xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9, xb0b4ff1622a01d.xbe23edc82b0342c0.xb3efee94cf138f44);
			if (codeEntry != null)
			{
				MessageBox.Show(x1536525b14cf2193, "The game already contains another code (\"" + codeEntry.Name + "\") with the same id.  Clashes between code ids within a single game are not permitted; you will need to either remove the other code or change the ids.", "Code id clash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				xfbf34718e704c6bc.Cancel = true;
				return;
			}
		}
		if (_98d83af30fd99cf7.xb1d0737e4174a713 != xb0b4ff1622a01d.xb1d0737e4174a713 && MessageBox.Show(x1536525b14cf2193, string.Concat("The game's region has changed (from ", _98d83af30fd99cf7.xb1d0737e4174a713, " to ", xb0b4ff1622a01d.xb1d0737e4174a713, ").\r\n\r\n(If that's really correct, you will probably need to update all the codes within the game as well.)\r\n\r\nAre you sure you've entered the right code?"), "Different game region", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			xfbf34718e704c6bc.Cancel = true;
		}
	}

	private void x43bf237084b5d838(object xe0292b9ed559da7d, CancelEventArgs xfbf34718e704c6bc)
	{
		x1536525b14cf2192 x1536525b14cf2193 = (x1536525b14cf2192)xe0292b9ed559da7d;
		CodeEntry xb0b4ff1622a01d = x1536525b14cf2193.xb0b4ff1622a01d12;
		if (xb0b4ff1622a01d.xda8f238d1a051872)
		{
			MessageBox.Show(x1536525b14cf2193, "This appears to be a master (M) code.  Master codes should be added as games, not as codes within a game.", "Can't be master code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		if (x289f1a0ee2f795a7.x4f90d54847434178(xb0b4ff1622a01d.Name, "(M)") || x289f1a0ee2f795a7.x4f90d54847434178(xb0b4ff1622a01d.Name, "M"))
		{
			MessageBox.Show(x1536525b14cf2193, "Game codes cannot be called '(M)' -- that's reserved for the master code.", "Invalid code name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		if (xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9 != _a0380078f0b6cbb7.x52b8174788d367f9)
		{
			GameEntry xa0380078f0b6cbb = _93c06c96f0e1cbb2.x45a46c637b44a527(xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9);
			if (xa0380078f0b6cbb != null)
			{
				MessageBox.Show(x1536525b14cf2193, "This code appears to be for the game \"" + xa0380078f0b6cbb.Name + "\", not this one.  You should add it to that game instead.", "Different game", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				MessageBox.Show(x1536525b14cf2193, "This code appears to be for a game not currently in any of your loaded codelists.  You will need to add that game before you can use this code.", "Unknown game", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		bool flag = _98d83af30fd99cf7 != null && _98d83af30fd99cf7.xb3efee94cf138f44 != xb0b4ff1622a01d.xbe23edc82b0342c0.xb3efee94cf138f44;
		if (flag && MessageBox.Show(x1536525b14cf2193, "The code's id has changed.  Either you've accidentally entered the wrong code or the code authors have changed the id for some reason (perhaps to prevent a clash).  If this was not intentional, then this could result in code duplication.\r\n\r\nAre you sure you've entered the correct code?", "Code id changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		if (_98d83af30fd99cf7 == null || flag)
		{
			CodeEntry codeEntry = _93c06c96f0e1cbb2.x13d95bb225c01867(xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9, xb0b4ff1622a01d.xbe23edc82b0342c0.xb3efee94cf138f44);
			if (codeEntry != null)
			{
				MessageBox.Show(x1536525b14cf2193, "The game already contains another code (\"" + codeEntry.Name + "\") with the same id.  Clashes between code ids within a single game are not permitted; you will need to either remove the other code or change the ids.", "Code id clash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				xfbf34718e704c6bc.Cancel = true;
				return;
			}
		}
		if (_98d83af30fd99cf7 == null)
		{
			x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc = xb0b4ff1622a01d.xbe23edc82b0342c0.x4521e8bf4ec2b6be(4);
			if (x8f4d4d97dd0fc != null)
			{
				CodeEntry xbabc9feec6f641db2 = _a0380078f0b6cbb7.x13d95bb225c01867(x8f4d4d97dd0fc.x6b73aa01aa019d3a);
				if (xbabc9feec6f641db2 == null && MessageBox.Show(x1536525b14cf2193, "The code you're adding is supposed to be contained within a 'folder' code, which doesn't appear to be in the list.  While you can proceed regardless, it's better to add the missing folder -- especially for mutually-exclusive (radio button style) codes.  (Note that a folder inherited from another codelist is not 'good enough' in this case, as there is no guarantee that it will stick around.)\r\n\r\nDo you still want to add this code?", "Missing parent code", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					xfbf34718e704c6bc.Cancel = true;
					return;
				}
			}
		}
		if (_a0380078f0b6cbb7.Region != RegionCode.Mixed && xb0b4ff1622a01d.xb1d0737e4174a713 != _a0380078f0b6cbb7.Region && MessageBox.Show(x1536525b14cf2193, string.Concat("You are trying to add a ", xb0b4ff1622a01d.xb1d0737e4174a713, " code to a ", _a0380078f0b6cbb7.Region, " game.  We're not actually sure what that'll do (so we'll let you try it if you really want to), but it doesn't seem like a particularly good idea.\r\n\r\nDo you still want to add this code?"), "Different region", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			xfbf34718e704c6bc.Cancel = true;
		}
	}

	[CompilerGenerated]
	private static string xcb8fcf8c1b111736(xfd5dc9a89edfa955 code)
	{
		return code.xb0b4ff1622a01d12.Name;
	}
}
