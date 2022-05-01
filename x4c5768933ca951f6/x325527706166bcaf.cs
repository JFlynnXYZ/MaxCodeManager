using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.MaxCodes;
using x3a260771fe762331;
using x7fd6e610350f13fb;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class x325527706166bcaf : Form
{
	private x00b1518996a61cc2 xa5a29a37143fc578;

	private Button xbb070a43c5ead4e9;

	private ColumnHeader x2ad481aace84dd1e;

	private ColumnHeader x465c11980f143cc7;

	private Button x9775fbc4eca3e0a0;

	private Button x8c0d5fb1879dbfdf;

	private Button xff1540116e532b2a;

	private ColumnHeader xb598d2f391288f75;

	private TableLayoutPanel xd509706c45b0e823;

	private Button xaa89b17faa79e847;

	private TableLayoutPanel xa05d4981b3d7b24a;

	private ImageList x7bcd86e0772d838f;

	private IContainer xb7dfc13308b54974;

	private Button x281f16001976e01a;

	private Button x7097d5175052e4bb;

	private x33636090f73cdcbf x06ca69422bbb7502;

	private List<xa0380078f0b6cbb7> xe858f6a4b95d2b29;

	private x33636090f73cdcbf x2e26bc427243234e;

	private x33636090f73cdcbf x93c06c96f0e1cbb2;

	private x33636090f73cdcbf x0916a2b56e31172c;

	private FavouriteGames x7f7aa52be0bee831;

	[CompilerGenerated]
	private static Comparison<xa0380078f0b6cbb7> xb52cc720056569fd;

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
		xb7dfc13308b54974 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(x325527706166bcaf));
		xbb070a43c5ead4e9 = new Button();
		x8c0d5fb1879dbfdf = new Button();
		xff1540116e532b2a = new Button();
		xd509706c45b0e823 = new TableLayoutPanel();
		x7097d5175052e4bb = new Button();
		xa5a29a37143fc578 = new x00b1518996a61cc2();
		x2ad481aace84dd1e = new ColumnHeader();
		x465c11980f143cc7 = new ColumnHeader();
		xb598d2f391288f75 = new ColumnHeader();
		x7bcd86e0772d838f = new ImageList(xb7dfc13308b54974);
		xaa89b17faa79e847 = new Button();
		xa05d4981b3d7b24a = new TableLayoutPanel();
		xd509706c45b0e823.SuspendLayout();
		xa05d4981b3d7b24a.SuspendLayout();
		SuspendLayout();
		xbb070a43c5ead4e9.DialogResult = DialogResult.OK;
		xbb070a43c5ead4e9.Dock = DockStyle.Fill;
		xbb070a43c5ead4e9.Location = new Point(503, 3);
		xbb070a43c5ead4e9.Name = "buttonDone";
		xbb070a43c5ead4e9.Size = new Size(95, 32);
		xbb070a43c5ead4e9.TabIndex = 2;
		xbb070a43c5ead4e9.Text = "Done";
		xbb070a43c5ead4e9.Click += xa8ac9af298b48c37;
		x8c0d5fb1879dbfdf.Dock = DockStyle.Fill;
		x8c0d5fb1879dbfdf.Location = new Point(203, 3);
		x8c0d5fb1879dbfdf.Name = "buttonSelectAll";
		x8c0d5fb1879dbfdf.Size = new Size(194, 30);
		x8c0d5fb1879dbfdf.TabIndex = 1;
		x8c0d5fb1879dbfdf.Text = "Select All";
		x8c0d5fb1879dbfdf.Click += xbf6696985aa3fc38;
		xff1540116e532b2a.Dock = DockStyle.Fill;
		xff1540116e532b2a.Location = new Point(403, 3);
		xff1540116e532b2a.Name = "buttonSelectNone";
		xff1540116e532b2a.Size = new Size(195, 30);
		xff1540116e532b2a.TabIndex = 2;
		xff1540116e532b2a.Text = "Select None";
		xff1540116e532b2a.Click += x997c42cad5f4f4e2;
		xd509706c45b0e823.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xd509706c45b0e823.ColumnCount = 3;
		xd509706c45b0e823.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		xd509706c45b0e823.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		xd509706c45b0e823.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		xd509706c45b0e823.Controls.Add(x7097d5175052e4bb, 0, 0);
		xd509706c45b0e823.Controls.Add(x8c0d5fb1879dbfdf, 1, 0);
		xd509706c45b0e823.Controls.Add(xff1540116e532b2a, 2, 0);
		xd509706c45b0e823.Location = new Point(4, 584);
		xd509706c45b0e823.Name = "tableLayoutPanelSelection";
		xd509706c45b0e823.RowCount = 1;
		xd509706c45b0e823.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
		xd509706c45b0e823.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
		xd509706c45b0e823.Size = new Size(601, 36);
		xd509706c45b0e823.TabIndex = 1;
		x7097d5175052e4bb.Dock = DockStyle.Fill;
		x7097d5175052e4bb.Location = new Point(3, 3);
		x7097d5175052e4bb.Name = "buttonAddGame";
		x7097d5175052e4bb.Size = new Size(194, 30);
		x7097d5175052e4bb.TabIndex = 0;
		x7097d5175052e4bb.Text = "Add Game";
		x7097d5175052e4bb.Click += xdb99f6f19adece6d;
		xa5a29a37143fc578.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xa5a29a37143fc578.Columns.AddRange(new ColumnHeader[3] { x2ad481aace84dd1e, x465c11980f143cc7, xb598d2f391288f75 });
		xa5a29a37143fc578.FullRowSelect = true;
		xa5a29a37143fc578.GridLines = true;
		xa5a29a37143fc578.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		xa5a29a37143fc578.HideSelection = false;
		xa5a29a37143fc578.Location = new Point(7, 4);
		xa5a29a37143fc578.Name = "listViewGames";
		xa5a29a37143fc578.Size = new Size(595, 577);
		xa5a29a37143fc578.Sorting = SortOrder.Ascending;
		xa5a29a37143fc578.TabIndex = 0;
		xa5a29a37143fc578.UseCompatibleStateImageBehavior = false;
		xa5a29a37143fc578.View = View.Details;
		xa5a29a37143fc578.ItemActivate += x3a38ce109ba7ad0e;
		xa5a29a37143fc578.SearchForVirtualItem += x1ac0a57fa7fa7e92;
		xa5a29a37143fc578.VirtualItemsSelectionRangeChanged += x31548d68ae2e9293;
		xa5a29a37143fc578.SelectedIndexChanged += x8ca59e11877f89fb;
		xa5a29a37143fc578.SizeChanged += xf531e2459bf79e0b;
		xa5a29a37143fc578.ItemCheck += xe559648d5a3fe0d7;
		xa5a29a37143fc578.RetrieveVirtualItem += xbb5f9d22e4195c2a;
		x2ad481aace84dd1e.Text = "Game";
		x2ad481aace84dd1e.Width = 441;
		x465c11980f143cc7.Text = "Codes";
		x465c11980f143cc7.Width = 62;
		xb598d2f391288f75.Text = "Region";
		xb598d2f391288f75.Width = 66;
		x7bcd86e0772d838f.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
		x7bcd86e0772d838f.TransparentColor = Color.Transparent;
		x7bcd86e0772d838f.Images.SetKeyName(0, "CheckboxClosedFolder.ico");
		x7bcd86e0772d838f.Images.SetKeyName(1, "CheckboxOpenFolder.ico");
		xaa89b17faa79e847.Dock = DockStyle.Fill;
		xaa89b17faa79e847.Location = new Point(253, 3);
		xaa89b17faa79e847.Name = "buttonUpdateFavouriteGames";
		xaa89b17faa79e847.Size = new Size(244, 32);
		xaa89b17faa79e847.TabIndex = 1;
		xaa89b17faa79e847.Text = "Update favourite games";
		xaa89b17faa79e847.Click += x59a3d57a480fbfcd;
		xa05d4981b3d7b24a.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xa05d4981b3d7b24a.ColumnCount = 3;
		xa05d4981b3d7b24a.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		xa05d4981b3d7b24a.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		xa05d4981b3d7b24a.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101f));
		xa05d4981b3d7b24a.Controls.Add(xaa89b17faa79e847, 1, 0);
		xa05d4981b3d7b24a.Controls.Add(xbb070a43c5ead4e9, 2, 0);
		xa05d4981b3d7b24a.Location = new Point(4, 626);
		xa05d4981b3d7b24a.Name = "tableLayoutPanelBottom";
		xa05d4981b3d7b24a.RowCount = 1;
		xa05d4981b3d7b24a.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		xa05d4981b3d7b24a.Size = new Size(601, 38);
		xa05d4981b3d7b24a.TabIndex = 2;
		AutoScaleBaseSize = new Size(8, 19);
		base.ClientSize = new Size(609, 666);
		base.Controls.Add(xa05d4981b3d7b24a);
		base.Controls.Add(xa5a29a37143fc578);
		base.Controls.Add(xd509706c45b0e823);
		Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		MinimumSize = new Size(507, 268);
		base.Name = "CodelistBrowserForm";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Codelist Browser";
		xd509706c45b0e823.ResumeLayout(performLayout: false);
		xa05d4981b3d7b24a.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public x325527706166bcaf(string xc15bd84e01929885, x33636090f73cdcbf x8a0b266419f09a55, x33636090f73cdcbf xd75e60e5e359bba6, x33636090f73cdcbf x674c7a44ab7af2f3, x33636090f73cdcbf x9bb25319cdbbd9cc)
	{
		x85601834555fb7d5();
		Text = string.Format(CultureInfo.CurrentCulture, "{0} ({1})", Text, xc15bd84e01929885);
		x06ca69422bbb7502 = x8a0b266419f09a55;
		x2e26bc427243234e = xd75e60e5e359bba6;
		x93c06c96f0e1cbb2 = x674c7a44ab7af2f3;
		x0916a2b56e31172c = x9bb25319cdbbd9cc;
		x7f7aa52be0bee831 = CodeManagerSettings.Instance.Favourites.Clone();
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

	protected override void OnLoad(EventArgs xfbf34718e704c6bc)
	{
		base.OnLoad(xfbf34718e704c6bc);
		x3ea284dd30b54d79();
		x9b2b090f5a117b24();
		xeb0bb1fd8b3dbf7b();
	}

	private void x3ea284dd30b54d79()
	{
		Button button;
		if (x06ca69422bbb7502 == x2e26bc427243234e)
		{
			button = (x281f16001976e01a = new Button());
			button.Text = "Remove from active codelist";
			button.Click += x5ba87f6bea7c94f7;
		}
		else
		{
			button = (x9775fbc4eca3e0a0 = new Button());
			button.Text = "Add to active codelist";
			button.Click += xc72ea7635237e180;
		}
		button.Dock = DockStyle.Fill;
		button.Location = new Point(3, 3);
		button.Size = new Size(244, 32);
		button.TabIndex = 0;
		xa05d4981b3d7b24a.Controls.Add(button, 0, 0);
	}

	private void x9b2b090f5a117b24()
	{
		if (x06ca69422bbb7502 == x2e26bc427243234e && x7bb28d9758d19dd0.x3452082a8fecf97d)
		{
			return;
		}
		xd509706c45b0e823.SuspendLayout();
		try
		{
			Button button = x7097d5175052e4bb;
			bool enabled = (x7097d5175052e4bb.Visible = false);
			button.Enabled = enabled;
			xd509706c45b0e823.ColumnStyles[0].SizeType = SizeType.Absolute;
			xd509706c45b0e823.ColumnStyles[0].Width = 0f;
			xd509706c45b0e823.ColumnStyles[1].Width = 50f;
			xd509706c45b0e823.ColumnStyles[2].Width = 50f;
		}
		finally
		{
			xd509706c45b0e823.ResumeLayout();
		}
	}

	private void xeb0bb1fd8b3dbf7b()
	{
		xe858f6a4b95d2b29 = new List<xa0380078f0b6cbb7>(x06ca69422bbb7502);
		xe858f6a4b95d2b29.Sort(delegate(xa0380078f0b6cbb7 x08db3aeabb253cb1, xa0380078f0b6cbb7 x1e218ceaee1bb583)
		{
			if (x08db3aeabb253cb1 == null && x1e218ceaee1bb583 == null)
			{
				return 0;
			}
			if (x08db3aeabb253cb1 == null)
			{
				return -1;
			}
			return (x1e218ceaee1bb583 == null) ? 1 : string.Compare(x08db3aeabb253cb1.x759aa16c2016a289, x1e218ceaee1bb583.x759aa16c2016a289, ignoreCase: true);
		});
		xa5a29a37143fc578.VirtualListSize = xe858f6a4b95d2b29.Count;
		x8ca59e11877f89fb(this, EventArgs.Empty);
	}

	private void xbb5f9d22e4195c2a(object xe0292b9ed559da7d, RetrieveVirtualItemEventArgs xfbf34718e704c6bc)
	{
		xa0380078f0b6cbb7 xa0380078f0b6cbb = xe858f6a4b95d2b29[xfbf34718e704c6bc.ItemIndex];
		xfbf34718e704c6bc.Item = new ListViewItem(new string[xa5a29a37143fc578.Columns.Count]);
		xfbf34718e704c6bc.Item.SubItems[x2ad481aace84dd1e.Index].Text = xa0380078f0b6cbb.x759aa16c2016a289;
		xfbf34718e704c6bc.Item.SubItems[x465c11980f143cc7.Index].Text = xa0380078f0b6cbb.xd44988f225497f3a.ToString(CultureInfo.CurrentCulture);
		xfbf34718e704c6bc.Item.SubItems[xb598d2f391288f75.Index].Text = xa0380078f0b6cbb.x9b7a81a8f32a1422.ToString();
		xfbf34718e704c6bc.Item.Checked = x7f7aa52be0bee831.Contains(xa0380078f0b6cbb.x52b8174788d367f9);
		xfbf34718e704c6bc.Item.Tag = xa0380078f0b6cbb;
	}

	private void x1ac0a57fa7fa7e92(object xe0292b9ed559da7d, SearchForVirtualItemEventArgs xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.IsTextSearch)
		{
			string text = xfbf34718e704c6bc.Text;
			Predicate<xa0380078f0b6cbb7> match = (xa0380078f0b6cbb7 x6849540e228fbc76) => x6849540e228fbc76.x759aa16c2016a289.StartsWith(text, StringComparison.CurrentCultureIgnoreCase);
			xfbf34718e704c6bc.Index = xe858f6a4b95d2b29.FindIndex(xfbf34718e704c6bc.StartIndex, match);
			if (xfbf34718e704c6bc.Index == -1 && xfbf34718e704c6bc.StartIndex > 0)
			{
				xfbf34718e704c6bc.Index = xe858f6a4b95d2b29.FindIndex(0, xfbf34718e704c6bc.StartIndex, match);
			}
		}
	}

	private void xe559648d5a3fe0d7(object xe0292b9ed559da7d, ItemCheckEventArgs xfbf34718e704c6bc)
	{
		xa0380078f0b6cbb7 xa0380078f0b6cbb = xe858f6a4b95d2b29[xfbf34718e704c6bc.Index];
		if (xfbf34718e704c6bc.NewValue == CheckState.Checked)
		{
			x7f7aa52be0bee831.Add(FavouriteGame.x7fb4a4853286849b(xa0380078f0b6cbb));
		}
		else
		{
			x7f7aa52be0bee831.Remove(xa0380078f0b6cbb.x52b8174788d367f9);
		}
	}

	private void xf531e2459bf79e0b(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		int num = xa5a29a37143fc578.ClientSize.Width;
		num -= xb598d2f391288f75.Width + x465c11980f143cc7.Width;
		x2ad481aace84dd1e.Width = num;
	}

	private bool xd65fb623169e7ad7(xa0380078f0b6cbb7 x6849540e228fbc76)
	{
		return x2e26bc427243234e.x45a46c637b44a527(x6849540e228fbc76.x52b8174788d367f9) != null;
	}

	private void xf4bf1d9cb637d533()
	{
		bool flag = xa5a29a37143fc578.SelectedIndices.Count > 0;
		if (x9775fbc4eca3e0a0 != null)
		{
			bool flag2 = false;
			if (x2e26bc427243234e != null && flag)
			{
				foreach (int selectedIndex in xa5a29a37143fc578.SelectedIndices)
				{
					flag2 |= !xd65fb623169e7ad7(xe858f6a4b95d2b29[selectedIndex]);
				}
			}
			x9775fbc4eca3e0a0.Enabled = flag2;
		}
		if (x281f16001976e01a != null)
		{
			x281f16001976e01a.Enabled = flag;
		}
	}

	private void x8ca59e11877f89fb(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xf4bf1d9cb637d533();
	}

	private void x31548d68ae2e9293(object xe0292b9ed559da7d, ListViewVirtualItemsSelectionRangeChangedEventArgs xfbf34718e704c6bc)
	{
		xf4bf1d9cb637d533();
	}

	private void xc72ea7635237e180(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (x2e26bc427243234e == null || xa5a29a37143fc578.SelectedIndices.Count < 1)
		{
			return;
		}
		bool flag = false;
		foreach (int selectedIndex in xa5a29a37143fc578.SelectedIndices)
		{
			xa0380078f0b6cbb7 xa0380078f0b6cbb = xe858f6a4b95d2b29[selectedIndex];
			if (!xd65fb623169e7ad7(xa0380078f0b6cbb))
			{
				x2e26bc427243234e.xd6b6ed77479ef68c(xa0380078f0b6cbb.Clone());
				x2e26bc427243234e.x77fa6322561797a0 = Math.Max(x2e26bc427243234e.x77fa6322561797a0, x06ca69422bbb7502.x77fa6322561797a0);
				flag = true;
			}
		}
		if (flag)
		{
			OnActiveListChanged(EventArgs.Empty);
		}
		xeb0bb1fd8b3dbf7b();
	}

	private void x5ba87f6bea7c94f7(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		int count = xa5a29a37143fc578.SelectedIndices.Count;
		if (x2e26bc427243234e == x06ca69422bbb7502 && count >= 1 && MessageBox.Show(this, "Are you sure you want to remove the selected game(s) from the active codelist?\r\n\r\n(If you don't have them in another list, you won't be able to get them back.)", "Confirm game removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		{
			int[] array = new int[count];
			xa5a29a37143fc578.SelectedIndices.CopyTo(array, 0);
			xa5a29a37143fc578.SelectedIndices.Clear();
			for (int num = count - 1; num >= 0; num--)
			{
				xa0380078f0b6cbb7 x6849540e228fbc = xe858f6a4b95d2b29[array[num]];
				x06ca69422bbb7502.x52b190e626f65140(x6849540e228fbc);
			}
			OnActiveListChanged(EventArgs.Empty);
			xeb0bb1fd8b3dbf7b();
		}
	}

	private void x59a3d57a480fbfcd(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		CodeManagerSettings.Instance.Favourites = x7f7aa52be0bee831.Clone();
		OnFavouriteGamesChanged(EventArgs.Empty);
	}

	private void xa8ac9af298b48c37(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (!CodeManagerSettings.Instance.Favourites.IsEquivalentTo(x7f7aa52be0bee831))
		{
			switch (MessageBox.Show(this, "You have changed the 'favourite games' checkboxes without (or since) clicking the 'Update Favourite Games' button.\r\n\r\nDid you want to save changes to your favourite games?", "Favourite games changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
			{
			case DialogResult.Yes:
				x59a3d57a480fbfcd(xaa89b17faa79e847, EventArgs.Empty);
				break;
			default:
				base.DialogResult = DialogResult.None;
				break;
			case DialogResult.No:
				break;
			}
		}
	}

	private void xbf6696985aa3fc38(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xa5a29a37143fc578.BeginUpdate();
		try
		{
			for (int i = 0; i < xe858f6a4b95d2b29.Count; i++)
			{
				xa5a29a37143fc578.SelectedIndices.Add(i);
			}
		}
		finally
		{
			xa5a29a37143fc578.EndUpdate();
		}
	}

	private void x997c42cad5f4f4e2(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xa5a29a37143fc578.SelectedIndices.Clear();
	}

	private void xb42a82b3f5ccf808()
	{
		x7f7aa52be0bee831 = CodeManagerSettings.Instance.Favourites.Clone();
		xa5a29a37143fc578.Invalidate();
	}

	private void x3a38ce109ba7ad0e(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (xa5a29a37143fc578.SelectedIndices.Count != 1)
		{
			return;
		}
		xa0380078f0b6cbb7 xa0380078f0b6cbb = xe858f6a4b95d2b29[xa5a29a37143fc578.SelectedIndices[0]];
		if (xa0380078f0b6cbb == null)
		{
			return;
		}
		xa0380078f0b6cbb7 x44f5de605a = ((x0916a2b56e31172c == null) ? null : x0916a2b56e31172c.x45a46c637b44a527(xa0380078f0b6cbb.x52b8174788d367f9));
		using xfddbe928036d80d4 xfddbe928036d80d5 = new xfddbe928036d80d4(xa0380078f0b6cbb, x06ca69422bbb7502 == x2e26bc427243234e, x2e26bc427243234e, x93c06c96f0e1cbb2, x44f5de605a);
		bool favouritesChanged = false;
		bool activeListChanged = false;
		xfddbe928036d80d5.x978f28482caa2f52 += delegate
		{
			favouritesChanged = true;
		};
		xfddbe928036d80d5.xcded22aefe17fee1 += delegate
		{
			activeListChanged = true;
		};
		xfddbe928036d80d5.ShowDialog(this);
		if (favouritesChanged)
		{
			xb42a82b3f5ccf808();
			OnFavouriteGamesChanged(EventArgs.Empty);
		}
		if (activeListChanged)
		{
			xeb0bb1fd8b3dbf7b();
			OnActiveListChanged(EventArgs.Empty);
		}
	}

	private void xdb99f6f19adece6d(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		using x1536525b14cf2192 x1536525b14cf2193 = x1536525b14cf2192.xebcf83b00134300b(null, 0u, 0u, "Add Game", "(game name)", "", "Enter the game's (M) code here.");
		x1536525b14cf2193.x33db2684576804ef += x2b02b3cb39a7cc38;
		if (x1536525b14cf2193.ShowDialog(this) != DialogResult.OK)
		{
			return;
		}
		xa0380078f0b6cbb7 game = new xa0380078f0b6cbb7();
		game.x52b8174788d367f9 = x1536525b14cf2193.xb0b4ff1622a01d12.xbe23edc82b0342c0.x52b8174788d367f9;
		game.x759aa16c2016a289 = x1536525b14cf2193.xb0b4ff1622a01d12.Name;
		game.x4e020dae918bd2ce = x1536525b14cf2193.xb0b4ff1622a01d12.x4e020dae918bd2ce;
		x1536525b14cf2193.xb0b4ff1622a01d12.Name = "(M)";
		x1536525b14cf2193.xb0b4ff1622a01d12.x4e020dae918bd2ce = "";
		game.xd6b6ed77479ef68c(x1536525b14cf2193.xb0b4ff1622a01d12);
		x2e26bc427243234e.xd6b6ed77479ef68c(game);
		OnActiveListChanged(EventArgs.Empty);
		xeb0bb1fd8b3dbf7b();
		int num = xe858f6a4b95d2b29.FindIndex((xa0380078f0b6cbb7 xb5d079ea7e672a45) => xb5d079ea7e672a45.x52b8174788d367f9 == game.x52b8174788d367f9);
		if (num != -1)
		{
			if (xa5a29a37143fc578.SelectedIndices.Count > 0)
			{
				xa5a29a37143fc578.SelectedIndices.Clear();
			}
			xa5a29a37143fc578.SelectedIndices.Add(num);
			x3a38ce109ba7ad0e(xa5a29a37143fc578, EventArgs.Empty);
		}
	}

	private void x2b02b3cb39a7cc38(object xe0292b9ed559da7d, CancelEventArgs xfbf34718e704c6bc)
	{
		x1536525b14cf2192 x1536525b14cf2193 = (x1536525b14cf2192)xe0292b9ed559da7d;
		xbabc9feec6f641db xb0b4ff1622a01d = x1536525b14cf2193.xb0b4ff1622a01d12;
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
		xa0380078f0b6cbb7 xa0380078f0b6cbb = x2e26bc427243234e.x45a46c637b44a527(xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9);
		if (xa0380078f0b6cbb != null)
		{
			MessageBox.Show(x1536525b14cf2193, "A game with the same id (game \"" + xa0380078f0b6cbb.x759aa16c2016a289 + "\") already exists in your active list.\r\n\r\nIf this is the game you're trying to add, then you should modify the existing entry instead.\r\n\r\nIf this is a different game, then you will have to remove one or the other.  They cannot co-exist.", "Duplicate game id", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			xfbf34718e704c6bc.Cancel = true;
			return;
		}
		xa0380078f0b6cbb7 xa0380078f0b6cbb2 = x93c06c96f0e1cbb2.x45a46c637b44a527(xb0b4ff1622a01d.xbe23edc82b0342c0.x52b8174788d367f9);
		if (xa0380078f0b6cbb2 != null && MessageBox.Show(x1536525b14cf2193, "A game with the same id (game \"" + xa0380078f0b6cbb2.x759aa16c2016a289 + "\") already exists in the full list, although not in your currently active list.\r\n\r\nIf this is the game you're trying to add, then it's usually better to add that game to your active list, unless you know that the (M) code you've entered is better than the existing one.  (Note that this 'new' game entry will still inherit all the codes from the 'old' game entry.)\r\n\r\nIf this is a different game, then you can proceed, but be aware that the results will not be pretty -- you'll end up with a weird mishmash of codes from both games.  This is not a good idea.\r\n\r\nDo you still want to add this game?", "Duplicate game id", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			xfbf34718e704c6bc.Cancel = true;
		}
		else if (CodeManagerSettings.Instance.RegionCode != RegionCode.Mixed && CodeManagerSettings.Instance.RegionCode != xb0b4ff1622a01d.xb1d0737e4174a713 && MessageBox.Show(x1536525b14cf2193, string.Concat("The code you have just entered appears to be for a ", xb0b4ff1622a01d.xb1d0737e4174a713, " system, and you've told us that you're using a ", CodeManagerSettings.Instance.RegionCode, " system.\r\n\r\nWhile we'll let you do this, if you don't have a compatible ARMAX system then the game won't be visible.\r\n\r\nDo you still want to add this game?"), "Different game region", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			xfbf34718e704c6bc.Cancel = true;
		}
	}

	[CompilerGenerated]
	private static int x26b645d36a3189bb(xa0380078f0b6cbb7 x08db3aeabb253cb1, xa0380078f0b6cbb7 x1e218ceaee1bb583)
	{
		if (x08db3aeabb253cb1 == null && x1e218ceaee1bb583 == null)
		{
			return 0;
		}
		if (x08db3aeabb253cb1 == null)
		{
			return -1;
		}
		if (x1e218ceaee1bb583 == null)
		{
			return 1;
		}
		return string.Compare(x08db3aeabb253cb1.x759aa16c2016a289, x1e218ceaee1bb583.x759aa16c2016a289, ignoreCase: true);
	}
}
