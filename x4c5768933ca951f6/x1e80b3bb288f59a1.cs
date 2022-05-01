using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.CodeManager.Properties;
using Mirality.Max.MaxCodes;
using x2ac61696da69bb5f;
using x3a260771fe762331;
using x7fd6e610350f13fb;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class x1e80b3bb288f59a1 : Form
{
	private enum x3d163626ad4a53fb
	{
		x4d0b9d4447ba7566,
		xd6b6ed77479ef68c,
		xef23aa45e7612fdd
	}

	private IContainer xb7dfc13308b54974;

	private Button x8c7441c6635b5683;

	private GroupBox x8ca8f6472fdb4183;

	private NumericUpDown x6e8bfdc6088a4af1;

	private NumericUpDown x53df326839b15dd5;

	private ComboBox xd124b77381494879;

	private CheckBox xe8940d7a7707af8e;

	private ComboBox x70803a733f990c26;

	private NumericUpDown x97e273780f406bf3;

	private GroupBox xb4aadda44c560ced;

	private RadioButton xbb53653c9a60e0d9;

	private RadioButton x19fe185fc0700bb2;

	private RadioButton x343902aafcac4852;

	private GroupBox x7d0c7fea2256576c;

	private GroupBox xf1d2f5d8a92e453d;

	private RichTextBox x0ad337d717bf9075;

	private ListView x903f46c0ecaae5df;

	private ColumnHeader x5f5b6966c174887c;

	private ColumnHeader x92b661ebfbec8a03;

	private ColumnHeader x5b7b4987268c11fd;

	private ImageList x30c496e188024acf;

	private GroupBox x88a745fd562c8d72;

	private Button xc9b26929b323cbb6;

	private TextBox x4e62eb0888a7c4ab;

	private ListBox x011d364c1718ef4b;

	private Button x5de30670a1053843;

	private Button x77c138625e4a3561;

	private Label x3b9a6a473765907c;

	private Label xdc21fb076e1552c1;

	private x088825ceb6b57a07 x2dbbdc1cf57e684d;

	private x088825ceb6b57a07 x0e35f0004de1eee5;

	private Button x52b0e605f9793eb6;

	private Button xec54fc22e8952b04;

	private ContextMenuStrip xab4534fd1b138e3d;

	private ToolStripMenuItem x3fb5ee6875fab58e;

	private ToolStripMenuItem xc070740fa9206423;

	private ToolStripMenuItem x4c0eaa66aae1e5e1;

	private ToolStripMenuItem xaf67fbb764ff25b6;

	private ToolStripMenuItem xdf355b9e0e84f3c5;

	private ToolStripMenuItem x7cb765f22f8ec92d;

	private ToolStripMenuItem xf3d262e0f161cc09;

	private ToolStripMenuItem x3d527a5cdc987957;

	private ToolStripMenuItem xc306b84150b291a6;

	private ToolStripMenuItem x05f97dce51c30486;

	private ToolStripMenuItem x55d78d55e0ed0a87;

	private ToolStripMenuItem x913ae5fe86fb3fd6;

	private ToolStripMenuItem x4b33e0a92fb9ea35;

	private ToolStripMenuItem x45ecf3be92072d40;

	private ToolStripMenuItem x4b9a094f3b1ca3cd;

	private ToolStripMenuItem xbbde7c2214986be3;

	private ToolStripMenuItem xaafadd916a6d554e;

	private ToolStripMenuItem x4109b7afa02147c1;

	private ToolStripMenuItem x99a861416c2d6fb6;

	private ToolStripMenuItem xcdb6cb07c6727183;

	private ToolStripMenuItem x8934becf57cc9d71;

	private ToolStripMenuItem x3d592d024d6ae1a2;

	private ToolStripMenuItem x36acb224f661179d;

	private ToolStripMenuItem x50e0c2902e0d903d;

	private ToolStripMenuItem x52b8c895eb006b5d;

	private ToolStripMenuItem xc0f4af8720b77998;

	private readonly xa0380078f0b6cbb7 _c74ed71dea076128;

	private xbabc9feec6f641db _b0b4ff1622a01d12;

	private Font _288a00e303b5ad49;

	private bool _8329ef83c85d35c7;

	private x3d163626ad4a53fb _3208502366f4a7cc;

	[CompilerGenerated]
	private static Comparison<x9e548743c3f0e895.xf370fda13822d1f9> xb52cc720056569fd;

	public xbabc9feec6f641db xe55cfc2215257397 => _b0b4ff1622a01d12;

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		if (xb41acd866d5cbca8)
		{
			if (xb7dfc13308b54974 != null)
			{
				xb7dfc13308b54974.Dispose();
			}
			if (_288a00e303b5ad49 != null)
			{
				_288a00e303b5ad49.Dispose();
				_288a00e303b5ad49 = null;
			}
		}
		base.Dispose(xb41acd866d5cbca8);
	}

	private void x85601834555fb7d5()
	{
		xb7dfc13308b54974 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(x1e80b3bb288f59a1));
		x8c7441c6635b5683 = new Button();
		x8ca8f6472fdb4183 = new GroupBox();
		xd124b77381494879 = new ComboBox();
		x53df326839b15dd5 = new NumericUpDown();
		x6e8bfdc6088a4af1 = new NumericUpDown();
		xe8940d7a7707af8e = new CheckBox();
		x97e273780f406bf3 = new NumericUpDown();
		x70803a733f990c26 = new ComboBox();
		xb4aadda44c560ced = new GroupBox();
		xbb53653c9a60e0d9 = new RadioButton();
		x30c496e188024acf = new ImageList(xb7dfc13308b54974);
		x19fe185fc0700bb2 = new RadioButton();
		x343902aafcac4852 = new RadioButton();
		x7d0c7fea2256576c = new GroupBox();
		x52b0e605f9793eb6 = new Button();
		xec54fc22e8952b04 = new Button();
		x0e35f0004de1eee5 = new x088825ceb6b57a07();
		xab4534fd1b138e3d = new ContextMenuStrip(xb7dfc13308b54974);
		x3fb5ee6875fab58e = new ToolStripMenuItem();
		x4c0eaa66aae1e5e1 = new ToolStripMenuItem();
		xaf67fbb764ff25b6 = new ToolStripMenuItem();
		xdf355b9e0e84f3c5 = new ToolStripMenuItem();
		xc070740fa9206423 = new ToolStripMenuItem();
		x7cb765f22f8ec92d = new ToolStripMenuItem();
		xf3d262e0f161cc09 = new ToolStripMenuItem();
		x3d527a5cdc987957 = new ToolStripMenuItem();
		xc306b84150b291a6 = new ToolStripMenuItem();
		x05f97dce51c30486 = new ToolStripMenuItem();
		x55d78d55e0ed0a87 = new ToolStripMenuItem();
		x913ae5fe86fb3fd6 = new ToolStripMenuItem();
		x4b33e0a92fb9ea35 = new ToolStripMenuItem();
		x45ecf3be92072d40 = new ToolStripMenuItem();
		x4b9a094f3b1ca3cd = new ToolStripMenuItem();
		xbbde7c2214986be3 = new ToolStripMenuItem();
		xaafadd916a6d554e = new ToolStripMenuItem();
		x4109b7afa02147c1 = new ToolStripMenuItem();
		x99a861416c2d6fb6 = new ToolStripMenuItem();
		xcdb6cb07c6727183 = new ToolStripMenuItem();
		x8934becf57cc9d71 = new ToolStripMenuItem();
		x3d592d024d6ae1a2 = new ToolStripMenuItem();
		x2dbbdc1cf57e684d = new x088825ceb6b57a07();
		x903f46c0ecaae5df = new ListView();
		x5f5b6966c174887c = new ColumnHeader();
		x92b661ebfbec8a03 = new ColumnHeader();
		x5b7b4987268c11fd = new ColumnHeader();
		xf1d2f5d8a92e453d = new GroupBox();
		x0ad337d717bf9075 = new RichTextBox();
		x88a745fd562c8d72 = new GroupBox();
		x5de30670a1053843 = new Button();
		xc9b26929b323cbb6 = new Button();
		x4e62eb0888a7c4ab = new TextBox();
		x011d364c1718ef4b = new ListBox();
		x77c138625e4a3561 = new Button();
		x3b9a6a473765907c = new Label();
		xdc21fb076e1552c1 = new Label();
		x36acb224f661179d = new ToolStripMenuItem();
		x50e0c2902e0d903d = new ToolStripMenuItem();
		x52b8c895eb006b5d = new ToolStripMenuItem();
		xc0f4af8720b77998 = new ToolStripMenuItem();
		Label label = new Label();
		Label label2 = new Label();
		Label label3 = new Label();
		x8ca8f6472fdb4183.SuspendLayout();
		((ISupportInitialize)x53df326839b15dd5).BeginInit();
		((ISupportInitialize)x6e8bfdc6088a4af1).BeginInit();
		((ISupportInitialize)x97e273780f406bf3).BeginInit();
		xb4aadda44c560ced.SuspendLayout();
		x7d0c7fea2256576c.SuspendLayout();
		xab4534fd1b138e3d.SuspendLayout();
		xf1d2f5d8a92e453d.SuspendLayout();
		x88a745fd562c8d72.SuspendLayout();
		SuspendLayout();
		label.AutoSize = true;
		label.Location = new Point(6, 21);
		label.Name = "label1";
		label.Size = new Size(50, 13);
		label.TabIndex = 0;
		label.Text = "Game Id:";
		label2.AutoSize = true;
		label2.Location = new Point(6, 47);
		label2.Name = "label2";
		label2.Size = new Size(47, 13);
		label2.TabIndex = 2;
		label2.Text = "Code Id:";
		label3.AutoSize = true;
		label3.Location = new Point(6, 74);
		label3.Name = "label3";
		label3.Size = new Size(44, 13);
		label3.TabIndex = 4;
		label3.Text = "Region:";
		x8c7441c6635b5683.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x8c7441c6635b5683.DialogResult = DialogResult.Cancel;
		x8c7441c6635b5683.Location = new Point(659, 485);
		x8c7441c6635b5683.Margin = new Padding(4);
		x8c7441c6635b5683.Name = "buttonCancel";
		x8c7441c6635b5683.Size = new Size(100, 28);
		x8c7441c6635b5683.TabIndex = 6;
		x8c7441c6635b5683.Text = "Cancel";
		x8c7441c6635b5683.UseVisualStyleBackColor = true;
		x8ca8f6472fdb4183.Controls.Add(xd124b77381494879);
		x8ca8f6472fdb4183.Controls.Add(x53df326839b15dd5);
		x8ca8f6472fdb4183.Controls.Add(x6e8bfdc6088a4af1);
		x8ca8f6472fdb4183.Controls.Add(label3);
		x8ca8f6472fdb4183.Controls.Add(label2);
		x8ca8f6472fdb4183.Controls.Add(label);
		x8ca8f6472fdb4183.Location = new Point(12, 12);
		x8ca8f6472fdb4183.Name = "groupBoxInfo";
		x8ca8f6472fdb4183.Size = new Size(137, 100);
		x8ca8f6472fdb4183.TabIndex = 0;
		x8ca8f6472fdb4183.TabStop = false;
		x8ca8f6472fdb4183.Text = "Code Identification";
		xd124b77381494879.DropDownStyle = ComboBoxStyle.DropDownList;
		xd124b77381494879.Items.AddRange(new object[3] { "NTSC", "PAL", "NTSCJ" });
		xd124b77381494879.Location = new Point(62, 71);
		xd124b77381494879.Name = "comboBoxRegion";
		xd124b77381494879.Size = new Size(66, 21);
		xd124b77381494879.TabIndex = 5;
		x53df326839b15dd5.Location = new Point(62, 45);
		x53df326839b15dd5.Maximum = new decimal(new int[4] { 524287, 0, 0, 0 });
		x53df326839b15dd5.Name = "numericUpDownCodeId";
		x53df326839b15dd5.Size = new Size(66, 20);
		x53df326839b15dd5.TabIndex = 3;
		x6e8bfdc6088a4af1.Location = new Point(62, 19);
		x6e8bfdc6088a4af1.Maximum = new decimal(new int[4] { 8191, 0, 0, 0 });
		x6e8bfdc6088a4af1.Name = "numericUpDownGameId";
		x6e8bfdc6088a4af1.Size = new Size(66, 20);
		x6e8bfdc6088a4af1.TabIndex = 1;
		xe8940d7a7707af8e.AutoSize = true;
		xe8940d7a7707af8e.Location = new Point(6, 20);
		xe8940d7a7707af8e.Name = "checkBoxHasParent";
		xe8940d7a7707af8e.Size = new Size(64, 17);
		xe8940d7a7707af8e.TabIndex = 0;
		xe8940d7a7707af8e.Text = "Child of:";
		xe8940d7a7707af8e.UseVisualStyleBackColor = true;
		xe8940d7a7707af8e.CheckedChanged += x5247f59b7f2d7c0a;
		x97e273780f406bf3.Location = new Point(76, 19);
		x97e273780f406bf3.Maximum = new decimal(new int[4] { 524287, 0, 0, 0 });
		x97e273780f406bf3.Name = "numericUpDownParentId";
		x97e273780f406bf3.Size = new Size(66, 20);
		x97e273780f406bf3.TabIndex = 1;
		x97e273780f406bf3.ValueChanged += xd8226753760f31b6;
		x70803a733f990c26.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x70803a733f990c26.DisplayMember = "Name";
		x70803a733f990c26.DropDownStyle = ComboBoxStyle.DropDownList;
		x70803a733f990c26.Location = new Point(148, 19);
		x70803a733f990c26.Name = "comboBoxParentName";
		x70803a733f990c26.Size = new Size(451, 21);
		x70803a733f990c26.TabIndex = 2;
		x70803a733f990c26.SelectionChangeCommitted += xb9eb8eaabb6698cd;
		x70803a733f990c26.SelectedIndexChanged += x60d89ed4a1930ecd;
		xb4aadda44c560ced.Controls.Add(xbb53653c9a60e0d9);
		xb4aadda44c560ced.Controls.Add(x19fe185fc0700bb2);
		xb4aadda44c560ced.Controls.Add(x343902aafcac4852);
		xb4aadda44c560ced.Controls.Add(x70803a733f990c26);
		xb4aadda44c560ced.Controls.Add(xe8940d7a7707af8e);
		xb4aadda44c560ced.Controls.Add(x97e273780f406bf3);
		xb4aadda44c560ced.Location = new Point(155, 12);
		xb4aadda44c560ced.Name = "groupBoxStructure";
		xb4aadda44c560ced.Size = new Size(605, 100);
		xb4aadda44c560ced.TabIndex = 1;
		xb4aadda44c560ced.TabStop = false;
		xb4aadda44c560ced.Text = "Code Structure";
		xbb53653c9a60e0d9.AutoSize = true;
		xbb53653c9a60e0d9.ImageIndex = 4;
		xbb53653c9a60e0d9.ImageList = x30c496e188024acf;
		xbb53653c9a60e0d9.Location = new Point(421, 47);
		xbb53653c9a60e0d9.Name = "radioButtonTypeFolderRadio";
		xbb53653c9a60e0d9.Size = new Size(112, 49);
		xbb53653c9a60e0d9.TabIndex = 5;
		xbb53653c9a60e0d9.TabStop = true;
		xbb53653c9a60e0d9.Text = "Folder (select one)";
		xbb53653c9a60e0d9.TextImageRelation = TextImageRelation.ImageAboveText;
		xbb53653c9a60e0d9.UseVisualStyleBackColor = true;
		x30c496e188024acf.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListTypes.ImageStream");
		x30c496e188024acf.TransparentColor = Color.Transparent;
		x30c496e188024acf.Images.SetKeyName(0, "UnknownCode.ico");
		x30c496e188024acf.Images.SetKeyName(1, "CheckboxCode.ico");
		x30c496e188024acf.Images.SetKeyName(2, "RadioCode.ico");
		x30c496e188024acf.Images.SetKeyName(3, "CheckboxClosedFolder.ico");
		x30c496e188024acf.Images.SetKeyName(4, "RadioClosedFolder.ico");
		x19fe185fc0700bb2.AutoSize = true;
		x19fe185fc0700bb2.ImageIndex = 3;
		x19fe185fc0700bb2.ImageList = x30c496e188024acf;
		x19fe185fc0700bb2.Location = new Point(234, 47);
		x19fe185fc0700bb2.Name = "radioButtonTypeFolderCheckbox";
		x19fe185fc0700bb2.Size = new Size(111, 49);
		x19fe185fc0700bb2.TabIndex = 4;
		x19fe185fc0700bb2.TabStop = true;
		x19fe185fc0700bb2.Text = "Folder (select any)";
		x19fe185fc0700bb2.TextImageRelation = TextImageRelation.ImageAboveText;
		x19fe185fc0700bb2.UseVisualStyleBackColor = true;
		x343902aafcac4852.AutoSize = true;
		x343902aafcac4852.ImageIndex = 0;
		x343902aafcac4852.ImageList = x30c496e188024acf;
		x343902aafcac4852.Location = new Point(72, 47);
		x343902aafcac4852.Name = "radioButtonTypeNormal";
		x343902aafcac4852.Size = new Size(86, 49);
		x343902aafcac4852.TabIndex = 3;
		x343902aafcac4852.TabStop = true;
		x343902aafcac4852.Text = "Normal Code";
		x343902aafcac4852.TextImageRelation = TextImageRelation.ImageAboveText;
		x343902aafcac4852.UseVisualStyleBackColor = true;
		x7d0c7fea2256576c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x7d0c7fea2256576c.Controls.Add(x52b0e605f9793eb6);
		x7d0c7fea2256576c.Controls.Add(xec54fc22e8952b04);
		x7d0c7fea2256576c.Controls.Add(x0e35f0004de1eee5);
		x7d0c7fea2256576c.Controls.Add(x2dbbdc1cf57e684d);
		x7d0c7fea2256576c.Controls.Add(x903f46c0ecaae5df);
		x7d0c7fea2256576c.Location = new Point(12, 118);
		x7d0c7fea2256576c.Name = "groupBoxCommands";
		x7d0c7fea2256576c.Size = new Size(748, 234);
		x7d0c7fea2256576c.TabIndex = 3;
		x7d0c7fea2256576c.TabStop = false;
		x7d0c7fea2256576c.Text = "Commands";
		x52b0e605f9793eb6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x52b0e605f9793eb6.Location = new Point(595, 205);
		x52b0e605f9793eb6.Name = "buttonDeleteCommand";
		x52b0e605f9793eb6.Size = new Size(147, 23);
		x52b0e605f9793eb6.TabIndex = 4;
		x52b0e605f9793eb6.Text = "Delete";
		x52b0e605f9793eb6.UseVisualStyleBackColor = true;
		x52b0e605f9793eb6.Click += xca7b04547a4ceeb1;
		xec54fc22e8952b04.Anchor = AnchorStyles.Bottom;
		xec54fc22e8952b04.Location = new Point(377, 205);
		xec54fc22e8952b04.Name = "buttonEditCommand";
		xec54fc22e8952b04.Size = new Size(147, 23);
		xec54fc22e8952b04.TabIndex = 3;
		xec54fc22e8952b04.Text = "Edit";
		xec54fc22e8952b04.UseVisualStyleBackColor = true;
		xec54fc22e8952b04.Click += xb7cc93b3ff2fbe1b;
		x0e35f0004de1eee5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x0e35f0004de1eee5.AutoSize = true;
		x0e35f0004de1eee5.ContextMenuStrip = xab4534fd1b138e3d;
		x0e35f0004de1eee5.x80617f9edd4b550d = xab4534fd1b138e3d;
		x0e35f0004de1eee5.Location = new Point(160, 205);
		x0e35f0004de1eee5.Name = "buttonInsertCommand";
		x0e35f0004de1eee5.Size = new Size(147, 23);
		x0e35f0004de1eee5.TabIndex = 2;
		x0e35f0004de1eee5.Text = "Insert";
		x0e35f0004de1eee5.UseVisualStyleBackColor = true;
		x0e35f0004de1eee5.x0866e94d5cce8a49 += xe2c822e2ef1d59b0;
		x0e35f0004de1eee5.xfd092b8a1a55f3d3 += x66322f20ee60675d;
		xab4534fd1b138e3d.Items.AddRange(new ToolStripItem[6] { x3fb5ee6875fab58e, xc070740fa9206423, xc306b84150b291a6, x36acb224f661179d, x4b33e0a92fb9ea35, x4109b7afa02147c1 });
		xab4534fd1b138e3d.Name = "contextMenuCommandTypes";
		xab4534fd1b138e3d.Size = new Size(163, 158);
		x3fb5ee6875fab58e.DropDownItems.AddRange(new ToolStripItem[3] { x4c0eaa66aae1e5e1, xaf67fbb764ff25b6, xdf355b9e0e84f3c5 });
		x3fb5ee6875fab58e.Name = "menuItemWrite";
		x3fb5ee6875fab58e.Size = new Size(162, 22);
		x3fb5ee6875fab58e.Text = "Direct &Write";
		x4c0eaa66aae1e5e1.Name = "menuItemWrite8";
		x4c0eaa66aae1e5e1.Size = new Size(152, 22);
		x4c0eaa66aae1e5e1.Tag = "00";
		x4c0eaa66aae1e5e1.Text = "&8-bit";
		x4c0eaa66aae1e5e1.Click += x77775c7115731b67;
		xaf67fbb764ff25b6.Name = "menuItemWrite16";
		xaf67fbb764ff25b6.Size = new Size(152, 22);
		xaf67fbb764ff25b6.Tag = "02";
		xaf67fbb764ff25b6.Text = "1&6-bit";
		xaf67fbb764ff25b6.Click += x77775c7115731b67;
		xdf355b9e0e84f3c5.Name = "menuItemWrite32";
		xdf355b9e0e84f3c5.Size = new Size(152, 22);
		xdf355b9e0e84f3c5.Tag = "04";
		xdf355b9e0e84f3c5.Text = "3&2-bit";
		xdf355b9e0e84f3c5.Click += x77775c7115731b67;
		xc070740fa9206423.DropDownItems.AddRange(new ToolStripItem[3] { x7cb765f22f8ec92d, xf3d262e0f161cc09, x3d527a5cdc987957 });
		xc070740fa9206423.Name = "menuItemAdd";
		xc070740fa9206423.Size = new Size(162, 22);
		xc070740fa9206423.Text = "Direct &Add";
		x7cb765f22f8ec92d.Name = "menuItemAdd8";
		x7cb765f22f8ec92d.Size = new Size(152, 22);
		x7cb765f22f8ec92d.Tag = "80";
		x7cb765f22f8ec92d.Text = "&8-bit";
		x7cb765f22f8ec92d.Click += x77775c7115731b67;
		xf3d262e0f161cc09.Name = "menuItemAdd16";
		xf3d262e0f161cc09.Size = new Size(152, 22);
		xf3d262e0f161cc09.Tag = "82";
		xf3d262e0f161cc09.Text = "1&6-bit";
		xf3d262e0f161cc09.Click += x77775c7115731b67;
		x3d527a5cdc987957.Name = "menuItemAdd32";
		x3d527a5cdc987957.Size = new Size(152, 22);
		x3d527a5cdc987957.Tag = "84";
		x3d527a5cdc987957.Text = "3&2-bit";
		x3d527a5cdc987957.Click += x77775c7115731b67;
		xc306b84150b291a6.DropDownItems.AddRange(new ToolStripItem[3] { x05f97dce51c30486, x55d78d55e0ed0a87, x913ae5fe86fb3fd6 });
		xc306b84150b291a6.Name = "menuItemPointer";
		xc306b84150b291a6.Size = new Size(162, 22);
		xc306b84150b291a6.Text = "&Pointer Write";
		x05f97dce51c30486.Name = "menuItemPointer8";
		x05f97dce51c30486.Size = new Size(152, 22);
		x05f97dce51c30486.Tag = "40";
		x05f97dce51c30486.Text = "&8-bit";
		x05f97dce51c30486.Click += x77775c7115731b67;
		x55d78d55e0ed0a87.Name = "menuItemPointer16";
		x55d78d55e0ed0a87.Size = new Size(152, 22);
		x55d78d55e0ed0a87.Tag = "42";
		x55d78d55e0ed0a87.Text = "1&6-bit";
		x55d78d55e0ed0a87.Click += x77775c7115731b67;
		x913ae5fe86fb3fd6.Name = "menuItemPointer32";
		x913ae5fe86fb3fd6.Size = new Size(152, 22);
		x913ae5fe86fb3fd6.Tag = "44";
		x913ae5fe86fb3fd6.Text = "3&2-bit";
		x913ae5fe86fb3fd6.Click += x77775c7115731b67;
		x4b33e0a92fb9ea35.DropDownItems.AddRange(new ToolStripItem[4] { x45ecf3be92072d40, x4b9a094f3b1ca3cd, xbbde7c2214986be3, xaafadd916a6d554e });
		x4b33e0a92fb9ea35.Name = "menuItemTest";
		x4b33e0a92fb9ea35.Size = new Size(162, 22);
		x4b33e0a92fb9ea35.Text = "&Tests";
		x45ecf3be92072d40.Name = "menuItemTest8";
		x45ecf3be92072d40.Size = new Size(152, 22);
		x45ecf3be92072d40.Tag = "08";
		x45ecf3be92072d40.Text = "&8-bit";
		x45ecf3be92072d40.Click += x77775c7115731b67;
		x4b9a094f3b1ca3cd.Name = "menuItemTest16";
		x4b9a094f3b1ca3cd.Size = new Size(152, 22);
		x4b9a094f3b1ca3cd.Tag = "0A";
		x4b9a094f3b1ca3cd.Text = "1&6-bit";
		x4b9a094f3b1ca3cd.Click += x77775c7115731b67;
		xbbde7c2214986be3.Name = "menuItemTest32";
		xbbde7c2214986be3.Size = new Size(152, 22);
		xbbde7c2214986be3.Tag = "0C";
		xbbde7c2214986be3.Text = "3&2-bit";
		xbbde7c2214986be3.Click += x77775c7115731b67;
		xaafadd916a6d554e.Name = "menuItemTestAlways";
		xaafadd916a6d554e.Size = new Size(152, 22);
		xaafadd916a6d554e.Tag = "0E";
		xaafadd916a6d554e.Text = "&Always";
		xaafadd916a6d554e.Click += x77775c7115731b67;
		x4109b7afa02147c1.DropDownItems.AddRange(new ToolStripItem[4] { x99a861416c2d6fb6, xcdb6cb07c6727183, x8934becf57cc9d71, x3d592d024d6ae1a2 });
		x4109b7afa02147c1.Name = "menuItemSpecial";
		x4109b7afa02147c1.Size = new Size(162, 22);
		x4109b7afa02147c1.Text = "&Special Commands";
		x99a861416c2d6fb6.Name = "menuItemMaster";
		x99a861416c2d6fb6.Size = new Size(166, 22);
		x99a861416c2d6fb6.Tag = "C4";
		x99a861416c2d6fb6.Text = "&Master Command";
		x99a861416c2d6fb6.Click += x77775c7115731b67;
		xcdb6cb07c6727183.Name = "menuItemEndOfCodelist";
		xcdb6cb07c6727183.Size = new Size(166, 22);
		xcdb6cb07c6727183.Text = "&End of Codelist";
		xcdb6cb07c6727183.Click += xb7d7f2a61730fd12;
		x8934becf57cc9d71.Name = "menuItemResumeProcessing";
		x8934becf57cc9d71.Size = new Size(166, 22);
		x8934becf57cc9d71.Text = "&Resume Processing";
		x8934becf57cc9d71.Click += xac63c98cf8f1887f;
		x3d592d024d6ae1a2.Name = "menuItemCustom";
		x3d592d024d6ae1a2.Size = new Size(166, 22);
		x3d592d024d6ae1a2.Text = "&Custom";
		x3d592d024d6ae1a2.Click += x3918006fa6a9d429;
		x2dbbdc1cf57e684d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x2dbbdc1cf57e684d.AutoSize = true;
		x2dbbdc1cf57e684d.ContextMenuStrip = xab4534fd1b138e3d;
		x2dbbdc1cf57e684d.x80617f9edd4b550d = xab4534fd1b138e3d;
		x2dbbdc1cf57e684d.Location = new Point(7, 205);
		x2dbbdc1cf57e684d.Name = "buttonAddCommand";
		x2dbbdc1cf57e684d.Size = new Size(147, 23);
		x2dbbdc1cf57e684d.TabIndex = 1;
		x2dbbdc1cf57e684d.Text = "Add";
		x2dbbdc1cf57e684d.UseVisualStyleBackColor = true;
		x2dbbdc1cf57e684d.x0866e94d5cce8a49 += xd37bcfde8e810fe3;
		x2dbbdc1cf57e684d.xfd092b8a1a55f3d3 += x66322f20ee60675d;
		x903f46c0ecaae5df.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x903f46c0ecaae5df.Columns.AddRange(new ColumnHeader[3] { x5f5b6966c174887c, x92b661ebfbec8a03, x5b7b4987268c11fd });
		x903f46c0ecaae5df.FullRowSelect = true;
		x903f46c0ecaae5df.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		x903f46c0ecaae5df.HideSelection = false;
		x903f46c0ecaae5df.Location = new Point(6, 19);
		x903f46c0ecaae5df.Name = "listViewCommands";
		x903f46c0ecaae5df.ShowItemToolTips = true;
		x903f46c0ecaae5df.Size = new Size(736, 180);
		x903f46c0ecaae5df.TabIndex = 0;
		x903f46c0ecaae5df.UseCompatibleStateImageBehavior = false;
		x903f46c0ecaae5df.View = View.Details;
		x903f46c0ecaae5df.ItemActivate += x3cadc9a0b92f5349;
		x903f46c0ecaae5df.ClientSizeChanged += x84639ee2dff6c163;
		x903f46c0ecaae5df.SelectedIndexChanged += xf2784cfada2b7454;
		x903f46c0ecaae5df.ColumnWidthChanging += xe6b9ebda4f480941;
		x5f5b6966c174887c.Text = "#";
		x5f5b6966c174887c.Width = 32;
		x92b661ebfbec8a03.Text = "Line";
		x92b661ebfbec8a03.Width = 145;
		x5b7b4987268c11fd.Text = "Description";
		x5b7b4987268c11fd.Width = 424;
		xf1d2f5d8a92e453d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xf1d2f5d8a92e453d.Controls.Add(x0ad337d717bf9075);
		xf1d2f5d8a92e453d.Location = new Point(12, 358);
		xf1d2f5d8a92e453d.Name = "groupBoxWarnings";
		xf1d2f5d8a92e453d.Size = new Size(748, 120);
		xf1d2f5d8a92e453d.TabIndex = 4;
		xf1d2f5d8a92e453d.TabStop = false;
		xf1d2f5d8a92e453d.Text = "Warnings";
		x0ad337d717bf9075.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x0ad337d717bf9075.DetectUrls = false;
		x0ad337d717bf9075.Location = new Point(9, 19);
		x0ad337d717bf9075.Name = "richTextBoxWarnings";
		x0ad337d717bf9075.ReadOnly = true;
		x0ad337d717bf9075.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
		x0ad337d717bf9075.Size = new Size(733, 95);
		x0ad337d717bf9075.TabIndex = 0;
		x0ad337d717bf9075.Text = "";
		x88a745fd562c8d72.Controls.Add(x5de30670a1053843);
		x88a745fd562c8d72.Controls.Add(xc9b26929b323cbb6);
		x88a745fd562c8d72.Controls.Add(x4e62eb0888a7c4ab);
		x88a745fd562c8d72.Controls.Add(x011d364c1718ef4b);
		x88a745fd562c8d72.Location = new Point(155, 114);
		x88a745fd562c8d72.Name = "groupBoxDiscs";
		x88a745fd562c8d72.Size = new Size(210, 100);
		x88a745fd562c8d72.TabIndex = 2;
		x88a745fd562c8d72.TabStop = false;
		x88a745fd562c8d72.Text = "Discs";
		x5de30670a1053843.Location = new Point(101, 73);
		x5de30670a1053843.Name = "buttonDiscRemove";
		x5de30670a1053843.Size = new Size(100, 23);
		x5de30670a1053843.TabIndex = 3;
		x5de30670a1053843.Text = "Remove";
		x5de30670a1053843.UseVisualStyleBackColor = true;
		x5de30670a1053843.Click += x3fb381ab753e4775;
		xc9b26929b323cbb6.Location = new Point(101, 37);
		xc9b26929b323cbb6.Name = "buttonDiscAdd";
		xc9b26929b323cbb6.Size = new Size(100, 23);
		xc9b26929b323cbb6.TabIndex = 2;
		xc9b26929b323cbb6.Text = "Add";
		xc9b26929b323cbb6.UseVisualStyleBackColor = true;
		xc9b26929b323cbb6.Click += x4a9642c00fe24216;
		x4e62eb0888a7c4ab.Location = new Point(101, 13);
		x4e62eb0888a7c4ab.Name = "textBoxDiscId";
		x4e62eb0888a7c4ab.Size = new Size(100, 20);
		x4e62eb0888a7c4ab.TabIndex = 1;
		x011d364c1718ef4b.FormatString = "X8";
		x011d364c1718ef4b.FormattingEnabled = true;
		x011d364c1718ef4b.IntegralHeight = false;
		x011d364c1718ef4b.Location = new Point(6, 13);
		x011d364c1718ef4b.Name = "listBoxDiscs";
		x011d364c1718ef4b.SelectionMode = SelectionMode.MultiSimple;
		x011d364c1718ef4b.Size = new Size(89, 82);
		x011d364c1718ef4b.Sorted = true;
		x011d364c1718ef4b.TabIndex = 0;
		x011d364c1718ef4b.SelectedIndexChanged += x03ba3a0d6ace12db;
		x77c138625e4a3561.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x77c138625e4a3561.DialogResult = DialogResult.OK;
		x77c138625e4a3561.Location = new Point(551, 485);
		x77c138625e4a3561.Margin = new Padding(4);
		x77c138625e4a3561.Name = "buttonOk";
		x77c138625e4a3561.Size = new Size(100, 28);
		x77c138625e4a3561.TabIndex = 5;
		x77c138625e4a3561.Text = "OK";
		x77c138625e4a3561.UseVisualStyleBackColor = true;
		x77c138625e4a3561.Click += xeebb56e8f7be7895;
		x3b9a6a473765907c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x3b9a6a473765907c.Image = Resources.Warning;
		x3b9a6a473765907c.ImageAlign = ContentAlignment.MiddleLeft;
		x3b9a6a473765907c.Location = new Point(12, 485);
		x3b9a6a473765907c.Name = "label4";
		x3b9a6a473765907c.Size = new Size(36, 32);
		x3b9a6a473765907c.TabIndex = 7;
		x3b9a6a473765907c.TextAlign = ContentAlignment.MiddleLeft;
		xdc21fb076e1552c1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		xdc21fb076e1552c1.ImageAlign = ContentAlignment.MiddleLeft;
		xdc21fb076e1552c1.Location = new Point(54, 485);
		xdc21fb076e1552c1.Name = "label5";
		xdc21fb076e1552c1.Size = new Size(490, 32);
		xdc21fb076e1552c1.TabIndex = 7;
		xdc21fb076e1552c1.Text = "Pressing OK while editing an existing code that could not be properly decoded may result in a non-working code.  (As could making any other changes, unless you know what you're doing.)";
		xdc21fb076e1552c1.TextAlign = ContentAlignment.MiddleLeft;
		x36acb224f661179d.DropDownItems.AddRange(new ToolStripItem[3] { x50e0c2902e0d903d, x52b8c895eb006b5d, xc0f4af8720b77998 });
		x36acb224f661179d.Name = "menuItemSlide";
		x36acb224f661179d.Size = new Size(162, 22);
		x36acb224f661179d.Text = "&Slide Write";
		x50e0c2902e0d903d.Name = "menuItemSlide8";
		x50e0c2902e0d903d.Size = new Size(152, 22);
		x50e0c2902e0d903d.Tag = "80";
		x50e0c2902e0d903d.Text = "&8-bit";
		x50e0c2902e0d903d.Click += x100b213ce24580ac;
		x52b8c895eb006b5d.Name = "menuItemSlide16";
		x52b8c895eb006b5d.Size = new Size(152, 22);
		x52b8c895eb006b5d.Tag = "82";
		x52b8c895eb006b5d.Text = "1&6-bit";
		x52b8c895eb006b5d.Click += x100b213ce24580ac;
		xc0f4af8720b77998.Name = "menuItemSlide32";
		xc0f4af8720b77998.Size = new Size(152, 22);
		xc0f4af8720b77998.Tag = "84";
		xc0f4af8720b77998.Text = "3&2-bit";
		xc0f4af8720b77998.Click += x100b213ce24580ac;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(772, 526);
		base.Controls.Add(xdc21fb076e1552c1);
		base.Controls.Add(x3b9a6a473765907c);
		base.Controls.Add(x88a745fd562c8d72);
		base.Controls.Add(xf1d2f5d8a92e453d);
		base.Controls.Add(x7d0c7fea2256576c);
		base.Controls.Add(xb4aadda44c560ced);
		base.Controls.Add(x8ca8f6472fdb4183);
		base.Controls.Add(x77c138625e4a3561);
		base.Controls.Add(x8c7441c6635b5683);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		MinimumSize = new Size(780, 560);
		base.Name = "AdvancedCodeEditorForm";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Advanced Code Editor";
		x8ca8f6472fdb4183.ResumeLayout(performLayout: false);
		x8ca8f6472fdb4183.PerformLayout();
		((ISupportInitialize)x53df326839b15dd5).EndInit();
		((ISupportInitialize)x6e8bfdc6088a4af1).EndInit();
		((ISupportInitialize)x97e273780f406bf3).EndInit();
		xb4aadda44c560ced.ResumeLayout(performLayout: false);
		xb4aadda44c560ced.PerformLayout();
		x7d0c7fea2256576c.ResumeLayout(performLayout: false);
		x7d0c7fea2256576c.PerformLayout();
		xab4534fd1b138e3d.ResumeLayout(performLayout: false);
		xf1d2f5d8a92e453d.ResumeLayout(performLayout: false);
		x88a745fd562c8d72.ResumeLayout(performLayout: false);
		x88a745fd562c8d72.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public x1e80b3bb288f59a1(xa0380078f0b6cbb7 xbfd1755ba00cde3c, xbabc9feec6f641db x9035cf16181332fc)
	{
		x85601834555fb7d5();
		_288a00e303b5ad49 = new Font(FontFamily.GenericMonospace, x903f46c0ecaae5df.Font.SizeInPoints, FontStyle.Regular, GraphicsUnit.Point);
		x011d364c1718ef4b.Font = _288a00e303b5ad49;
		x88a745fd562c8d72.Location = xb4aadda44c560ced.Location;
		x0c4d83043d585aad();
		_c74ed71dea076128 = xbfd1755ba00cde3c;
		_b0b4ff1622a01d12 = x9035cf16181332fc;
		xea522ff5ab83cc71();
	}

	private void x0c4d83043d585aad()
	{
		int num = x903f46c0ecaae5df.ClientSize.Width;
		foreach (ColumnHeader column in x903f46c0ecaae5df.Columns)
		{
			if (column != x5b7b4987268c11fd)
			{
				num -= column.Width;
			}
		}
		x5b7b4987268c11fd.Width = num - 1;
	}

	private void x84639ee2dff6c163(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x0c4d83043d585aad();
	}

	private void xe6b9ebda4f480941(object xe0292b9ed559da7d, ColumnWidthChangingEventArgs xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.ColumnIndex != x5b7b4987268c11fd.Index)
		{
			x0c4d83043d585aad();
		}
	}

	private void xea522ff5ab83cc71()
	{
		x9fef04120a88daef();
		x91bd9aa1a9a3f3be();
	}

	private void x9fef04120a88daef()
	{
		if (_c74ed71dea076128 == null)
		{
			xb4aadda44c560ced.Enabled = false;
			xb4aadda44c560ced.Visible = false;
			x88a745fd562c8d72.Visible = true;
			if (_b0b4ff1622a01d12 == null)
			{
				_b0b4ff1622a01d12 = new xbabc9feec6f641db();
				_b0b4ff1622a01d12.xda8f238d1a051872 = true;
				_b0b4ff1622a01d12.xb1d0737e4174a713 = CodeManagerSettings.Instance.RegionCode;
				if (_b0b4ff1622a01d12.xb1d0737e4174a713 == RegionCode.Mixed)
				{
					_b0b4ff1622a01d12.xb1d0737e4174a713 = RegionCode.PAL;
				}
				_b0b4ff1622a01d12.xbe23edc82b0342c0 = new x047611ec9892e059(0u, 0u, _b0b4ff1622a01d12.xb1d0737e4174a713);
				_b0b4ff1622a01d12.xbe23edc82b0342c0.xda8f238d1a051872 = true;
			}
			else
			{
				_b0b4ff1622a01d12 = _b0b4ff1622a01d12.Clone();
				x6e8bfdc6088a4af1.Value = _b0b4ff1622a01d12.xbe23edc82b0342c0.x52b8174788d367f9;
				foreach (x047611ec9892e059.x8f4d4d97dd0fc840 item in _b0b4ff1622a01d12.xbe23edc82b0342c0.xa54a49b4cb11c6d1)
				{
					if (item.x3146d638ec378671 == 7)
					{
						x011d364c1718ef4b.Items.Add(item.x6b73aa01aa019d3a);
					}
				}
			}
			x03ba3a0d6ace12db(null, EventArgs.Empty);
		}
		else
		{
			xb4aadda44c560ced.Visible = true;
			x88a745fd562c8d72.Enabled = false;
			x88a745fd562c8d72.Visible = false;
			x343902aafcac4852.Checked = true;
			x6e8bfdc6088a4af1.Value = _c74ed71dea076128.x52b8174788d367f9;
			x6e8bfdc6088a4af1.Enabled = false;
			x2dff49496bdb3cf1();
			x5247f59b7f2d7c0a(null, EventArgs.Empty);
			if (_b0b4ff1622a01d12 == null)
			{
				_b0b4ff1622a01d12 = new xbabc9feec6f641db();
				_b0b4ff1622a01d12.xb1d0737e4174a713 = _c74ed71dea076128.x9b7a81a8f32a1422;
				if (_b0b4ff1622a01d12.xb1d0737e4174a713 == RegionCode.Mixed)
				{
					_b0b4ff1622a01d12.xb1d0737e4174a713 = RegionCode.PAL;
				}
				_b0b4ff1622a01d12.xbe23edc82b0342c0 = new x047611ec9892e059(_c74ed71dea076128.x52b8174788d367f9, 0u, _b0b4ff1622a01d12.xb1d0737e4174a713);
			}
			else
			{
				_b0b4ff1622a01d12 = _b0b4ff1622a01d12.Clone();
				x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc = _b0b4ff1622a01d12.xbe23edc82b0342c0.x4521e8bf4ec2b6be(4);
				if (x8f4d4d97dd0fc != null)
				{
					xe8940d7a7707af8e.Checked = true;
					x97e273780f406bf3.Value = x8f4d4d97dd0fc.x6b73aa01aa019d3a;
				}
				x8f4d4d97dd0fc = _b0b4ff1622a01d12.xbe23edc82b0342c0.x4521e8bf4ec2b6be(5);
				if (x8f4d4d97dd0fc != null)
				{
					if (x8f4d4d97dd0fc.x6b73aa01aa019d3a == 0)
					{
						x19fe185fc0700bb2.Checked = true;
					}
					else
					{
						xbb53653c9a60e0d9.Checked = true;
					}
				}
			}
		}
		x53df326839b15dd5.Value = _b0b4ff1622a01d12.xb3efee94cf138f44;
		xd124b77381494879.SelectedIndex = (int)_b0b4ff1622a01d12.xb1d0737e4174a713;
	}

	private void x2dff49496bdb3cf1()
	{
		foreach (xbabc9feec6f641db item in _c74ed71dea076128)
		{
			if (item.xbe23edc82b0342c0 != null)
			{
				x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc = item.xbe23edc82b0342c0.x4521e8bf4ec2b6be(5);
				if (x8f4d4d97dd0fc != null)
				{
					x70803a733f990c26.Items.Add(item);
				}
			}
		}
	}

	private void x91bd9aa1a9a3f3be()
	{
		x0ad337d717bf9075.Clear();
		if (_c74ed71dea076128 != null)
		{
			if (_b0b4ff1622a01d12.xbe23edc82b0342c0.x52b8174788d367f9 != _c74ed71dea076128.x52b8174788d367f9)
			{
				x6e8bfdc6088a4af1.Enabled = true;
				x0ad337d717bf9075.AppendText($"Game id within code is {_b0b4ff1622a01d12.xbe23edc82b0342c0.x52b8174788d367f9}, but id of containing game is {_c74ed71dea076128.x52b8174788d367f9}.\r\n");
			}
			if (_b0b4ff1622a01d12.xbe23edc82b0342c0.xb3efee94cf138f44 != _b0b4ff1622a01d12.xb3efee94cf138f44)
			{
				x0ad337d717bf9075.AppendText($"Code id within code is {_b0b4ff1622a01d12.xbe23edc82b0342c0.xb3efee94cf138f44}, but id in codelist is {_b0b4ff1622a01d12.xb3efee94cf138f44}.\r\n");
			}
		}
		List<string> list = new List<string>();
		List<x9e548743c3f0e895.xf370fda13822d1f9> list2;
		if (_b0b4ff1622a01d12.xbe23edc82b0342c0 == null)
		{
			list2 = new List<x9e548743c3f0e895.xf370fda13822d1f9>();
			list.Add("Code has not been successfully decrypted.");
		}
		else
		{
			list2 = x9e548743c3f0e895.xb4638aac69d75ced(_b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a, list);
		}
		foreach (string item in list)
		{
			x0ad337d717bf9075.AppendText(item + "\r\n");
		}
		x903f46c0ecaae5df.BeginUpdate();
		try
		{
			x903f46c0ecaae5df.Items.Clear();
			foreach (x9e548743c3f0e895.xf370fda13822d1f9 item2 in list2)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (x047611ec9892e059.x7a274f60ab25f2b9 item3 in item2.xfb8e025166a358a7())
				{
					stringBuilder.AppendFormat("{0:X8} {1:X8} ", item3.x1d5cfa3bffdfb042, item3.xd2f68ee6f47e9dfb);
				}
				ListViewItem listViewItem = new ListViewItem(new string[x903f46c0ecaae5df.Columns.Count]);
				listViewItem.UseItemStyleForSubItems = false;
				listViewItem.SubItems[x5f5b6966c174887c.Index].Text = (item2.x9f7648f40d0312e9 + 1).ToString();
				listViewItem.SubItems[x92b661ebfbec8a03.Index].Font = _288a00e303b5ad49;
				listViewItem.SubItems[x92b661ebfbec8a03.Index].Text = stringBuilder.ToString().TrimEnd();
				listViewItem.SubItems[x5b7b4987268c11fd.Index].Text = item2.LongDescription;
				listViewItem.Tag = item2;
				x903f46c0ecaae5df.Items.Add(listViewItem);
			}
		}
		finally
		{
			x903f46c0ecaae5df.EndUpdate();
			xf2784cfada2b7454(null, EventArgs.Empty);
		}
	}

	private void x03ba3a0d6ace12db(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x5de30670a1053843.Enabled = x011d364c1718ef4b.SelectedIndices.Count > 0;
	}

	private void x4a9642c00fe24216(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (uint.TryParse(x4e62eb0888a7c4ab.Text, NumberStyles.HexNumber, CultureInfo.CurrentUICulture, out var result))
		{
			if (x011d364c1718ef4b.Items.Contains(result))
			{
				MessageBox.Show(this, "Cannot add \"" + x4e62eb0888a7c4ab.Text + "\"; it is already in the list.", "Duplicate disc id", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				x011d364c1718ef4b.Items.Add(result);
			}
		}
		else
		{
			MessageBox.Show(this, "Cannot add \"" + x4e62eb0888a7c4ab.Text + "\"; it does not appear to be a valid hexadecimal number.", "Invalid disc id", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void x3fb381ab753e4775(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		ArrayList arrayList = new ArrayList(x011d364c1718ef4b.SelectedItems);
		foreach (uint item in arrayList)
		{
			x011d364c1718ef4b.Items.Remove(item);
		}
	}

	private void x5247f59b7f2d7c0a(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x97e273780f406bf3.Enabled = xe8940d7a7707af8e.Checked;
		x70803a733f990c26.Enabled = xe8940d7a7707af8e.Checked;
	}

	private void xd8226753760f31b6(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (_8329ef83c85d35c7)
		{
			return;
		}
		foreach (xbabc9feec6f641db item in x70803a733f990c26.Items)
		{
			if (item.xb3efee94cf138f44 == (uint)x97e273780f406bf3.Value)
			{
				_8329ef83c85d35c7 = true;
				try
				{
					x70803a733f990c26.SelectedItem = item;
					return;
				}
				finally
				{
					_8329ef83c85d35c7 = false;
					xf7172edd6d7047b1();
				}
			}
		}
		_8329ef83c85d35c7 = true;
		try
		{
			x70803a733f990c26.SelectedItem = null;
		}
		finally
		{
			_8329ef83c85d35c7 = false;
		}
	}

	private void x60d89ed4a1930ecd(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
	}

	private void xb9eb8eaabb6698cd(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (_8329ef83c85d35c7 || x70803a733f990c26.SelectedItem == null)
		{
			return;
		}
		_8329ef83c85d35c7 = true;
		try
		{
			x97e273780f406bf3.Value = ((xbabc9feec6f641db)x70803a733f990c26.SelectedItem).xb3efee94cf138f44;
		}
		finally
		{
			_8329ef83c85d35c7 = false;
			xf7172edd6d7047b1();
		}
	}

	private void xf7172edd6d7047b1()
	{
		xbabc9feec6f641db xbabc9feec6f641db = (xbabc9feec6f641db)x70803a733f990c26.SelectedItem;
		if (xbabc9feec6f641db == null || xbabc9feec6f641db.xbe23edc82b0342c0 == null)
		{
			x343902aafcac4852.ImageIndex = 0;
			return;
		}
		x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc = xbabc9feec6f641db.xbe23edc82b0342c0.x4521e8bf4ec2b6be(5);
		if (x8f4d4d97dd0fc == null)
		{
			x343902aafcac4852.ImageIndex = 0;
		}
		else if (x8f4d4d97dd0fc.x6b73aa01aa019d3a == 0)
		{
			x343902aafcac4852.ImageIndex = 1;
		}
		else
		{
			x343902aafcac4852.ImageIndex = 2;
		}
	}

	private void xeebb56e8f7be7895(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (x6e8bfdc6088a4af1.Value == 0m)
		{
			MessageBox.Show(this, "You must specify a non-zero Game ID.", "Invalid Game ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			base.DialogResult = DialogResult.None;
			return;
		}
		if (x53df326839b15dd5.Value == 0m)
		{
			MessageBox.Show(this, "You must specify a non-zero Code ID.", "Invalid Code ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			base.DialogResult = DialogResult.None;
			return;
		}
		_b0b4ff1622a01d12.xbe23edc82b0342c0.x52b8174788d367f9 = (uint)x6e8bfdc6088a4af1.Value;
		_b0b4ff1622a01d12.xbe23edc82b0342c0.xb3efee94cf138f44 = (uint)x53df326839b15dd5.Value;
		_b0b4ff1622a01d12.xbe23edc82b0342c0.x4b94e58155458175 = (RegionCode)xd124b77381494879.SelectedIndex;
		if (_b0b4ff1622a01d12.xda8f238d1a051872)
		{
			_b0b4ff1622a01d12.xbe23edc82b0342c0.x6a0f374870b7d174(7);
			foreach (uint item in x011d364c1718ef4b.Items)
			{
				_b0b4ff1622a01d12.xbe23edc82b0342c0.xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(7, item));
			}
		}
		else
		{
			if (!x343902aafcac4852.Checked && x903f46c0ecaae5df.Items.Count > 0)
			{
				MessageBox.Show(this, "Folder codes can't have any commands.  (Well, they could, but they'd never do anything, so what's the point?)", "Folder code with commands?", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.DialogResult = DialogResult.None;
				return;
			}
			_b0b4ff1622a01d12.xbe23edc82b0342c0.x6a0f374870b7d174(4);
			if (xe8940d7a7707af8e.Checked)
			{
				if (x97e273780f406bf3.Value == 0m)
				{
					MessageBox.Show(this, "You must specify a non-zero Parent ID, if the code has a parent at all.", "Invalid Parent ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					base.DialogResult = DialogResult.None;
					return;
				}
				_b0b4ff1622a01d12.xbe23edc82b0342c0.xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(4, (uint)x97e273780f406bf3.Value));
			}
			_b0b4ff1622a01d12.xbe23edc82b0342c0.x6a0f374870b7d174(5);
			if (x19fe185fc0700bb2.Checked)
			{
				_b0b4ff1622a01d12.xbe23edc82b0342c0.xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(5, 0u));
			}
			else if (xbb53653c9a60e0d9.Checked)
			{
				_b0b4ff1622a01d12.xbe23edc82b0342c0.xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(5, 1u));
			}
		}
		List<xbabc9feec6f641db> list = new List<xbabc9feec6f641db>();
		list.Add(_b0b4ff1622a01d12);
		List<string> list2 = x7bb28d9758d19dd0.x6b6fd0a44693bc2e(list);
		if (list2.Count > 0)
		{
			MessageBox.Show(this, "Errors occurred while trying to convert the code into MAX format.\r\n\r\n" + string.Join("\r\n", list2.ToArray()), "Code processing errors", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			base.DialogResult = DialogResult.None;
		}
	}

	private void xf2784cfada2b7454(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		bool enabled = x903f46c0ecaae5df.SelectedIndices.Count == 1;
		bool enabled2 = x903f46c0ecaae5df.SelectedIndices.Count >= 1;
		x0e35f0004de1eee5.Enabled = enabled;
		xec54fc22e8952b04.Enabled = enabled;
		x52b0e605f9793eb6.Enabled = enabled2;
	}

	private void x3cadc9a0b92f5349(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xec54fc22e8952b04.PerformClick();
	}

	private void xd37bcfde8e810fe3(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		_3208502366f4a7cc = x3d163626ad4a53fb.xd6b6ed77479ef68c;
	}

	private void xe2c822e2ef1d59b0(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		_3208502366f4a7cc = x3d163626ad4a53fb.xef23aa45e7612fdd;
	}

	private void x66322f20ee60675d(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
	}

	private void x832508dfd926834d(x9e548743c3f0e895.xf370fda13822d1f9 xfd6dd6e53b1a26d5)
	{
		using xd5ba7129f9995ffc xd5ba7129f9995ffc2 = new xd5ba7129f9995ffc(xfd6dd6e53b1a26d5);
		if (xd5ba7129f9995ffc2.ShowDialog(this) != DialogResult.OK)
		{
			return;
		}
		int xeb28d76ef7e;
		switch (_3208502366f4a7cc)
		{
		default:
			return;
		case x3d163626ad4a53fb.xd6b6ed77479ef68c:
			xeb28d76ef7e = _b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.Count;
			_b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.AddRange(xd5ba7129f9995ffc2.x0a444d8def87be79.xfb8e025166a358a7());
			break;
		case x3d163626ad4a53fb.xef23aa45e7612fdd:
			if (x903f46c0ecaae5df.SelectedItems.Count >= 1)
			{
				x9e548743c3f0e895.xf370fda13822d1f9 xf370fda13822d1f = (x9e548743c3f0e895.xf370fda13822d1f9)x903f46c0ecaae5df.SelectedItems[0].Tag;
				xeb28d76ef7e = xf370fda13822d1f.x9f7648f40d0312e9;
				_b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.InsertRange(xf370fda13822d1f.x9f7648f40d0312e9, xd5ba7129f9995ffc2.x0a444d8def87be79.xfb8e025166a358a7());
				break;
			}
			goto case x3d163626ad4a53fb.xd6b6ed77479ef68c;
		}
		x91bd9aa1a9a3f3be();
		x8bce2f1e235b4d58(xeb28d76ef7e);
	}

	private void x77775c7115731b67(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		string s = (string)((ToolStripMenuItem)xe0292b9ed559da7d).Tag;
		uint x179bb663e71b1f = (uint.Parse(s, NumberStyles.HexNumber) << 24) | 0x100000u;
		x832508dfd926834d(new x9e548743c3f0e895.x95af7b2efc150589(0, new x047611ec9892e059.x7a274f60ab25f2b9(x179bb663e71b1f, 0u)));
	}

	private void x100b213ce24580ac(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		string s = (string)((ToolStripMenuItem)xe0292b9ed559da7d).Tag;
		uint xbcea506a33cf = (uint.Parse(s, NumberStyles.HexNumber) << 24) | 0x100000u;
		x832508dfd926834d(new x9e548743c3f0e895.x9f51b856a6c0aa70(0, new x047611ec9892e059.x7a274f60ab25f2b9(0u, xbcea506a33cf), new x047611ec9892e059.x7a274f60ab25f2b9(0u, 0u)));
	}

	private void xb7d7f2a61730fd12(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x832508dfd926834d(new x9e548743c3f0e895.x0f0906c583e29b6b(0));
	}

	private void xac63c98cf8f1887f(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x832508dfd926834d(new x9e548743c3f0e895.xe948cf6a9cb0be5f(0));
	}

	private void x3918006fa6a9d429(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x832508dfd926834d(new x9e548743c3f0e895.xf8be28f9144c5748(0, new x047611ec9892e059.x7a274f60ab25f2b9(0u, 33554432u)));
	}

	private void xb7cc93b3ff2fbe1b(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (x903f46c0ecaae5df.SelectedItems.Count < 1)
		{
			return;
		}
		x9e548743c3f0e895.xf370fda13822d1f9 xf370fda13822d1f = (x9e548743c3f0e895.xf370fda13822d1f9)x903f46c0ecaae5df.SelectedItems[0].Tag;
		using xd5ba7129f9995ffc xd5ba7129f9995ffc2 = new xd5ba7129f9995ffc(xf370fda13822d1f);
		if (xd5ba7129f9995ffc2.ShowDialog(this) == DialogResult.OK)
		{
			int x9f7648f40d0312e = xf370fda13822d1f.x9f7648f40d0312e9;
			_b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.RemoveRange(x9f7648f40d0312e, xf370fda13822d1f.x1be93eed8950d961);
			_b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.InsertRange(x9f7648f40d0312e, xd5ba7129f9995ffc2.x0a444d8def87be79.xfb8e025166a358a7());
			x91bd9aa1a9a3f3be();
			x8bce2f1e235b4d58(x9f7648f40d0312e);
		}
	}

	private void x8bce2f1e235b4d58(int xeb28d76ef7e31289)
	{
		foreach (ListViewItem item in x903f46c0ecaae5df.Items)
		{
			if (((x9e548743c3f0e895.xf370fda13822d1f9)item.Tag).x9f7648f40d0312e9 == xeb28d76ef7e31289)
			{
				item.Selected = true;
				break;
			}
		}
	}

	private void xca7b04547a4ceeb1(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		List<x9e548743c3f0e895.xf370fda13822d1f9> list = new List<x9e548743c3f0e895.xf370fda13822d1f9>();
		foreach (ListViewItem selectedItem in x903f46c0ecaae5df.SelectedItems)
		{
			list.Add((x9e548743c3f0e895.xf370fda13822d1f9)selectedItem.Tag);
		}
		list.Sort((x9e548743c3f0e895.xf370fda13822d1f9 x610d380345868c98, x9e548743c3f0e895.xf370fda13822d1f9 x876a7017b96234f0) => x876a7017b96234f0.x9f7648f40d0312e9 - x610d380345868c98.x9f7648f40d0312e9);
		if (MessageBox.Show(this, "Are you sure you want to delete these " + list.Count + " command(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
		{
			return;
		}
		foreach (x9e548743c3f0e895.xf370fda13822d1f9 item in list)
		{
			_b0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.RemoveRange(item.x9f7648f40d0312e9, item.x1be93eed8950d961);
		}
		x91bd9aa1a9a3f3be();
	}

	[CompilerGenerated]
	private static int xe394082bca7009b5(x9e548743c3f0e895.xf370fda13822d1f9 x610d380345868c98, x9e548743c3f0e895.xf370fda13822d1f9 x876a7017b96234f0)
	{
		return x876a7017b96234f0.x9f7648f40d0312e9 - x610d380345868c98.x9f7648f40d0312e9;
	}
}
