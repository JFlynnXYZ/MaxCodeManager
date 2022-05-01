using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Mirality.Max.CodeManager;
using Mirality.Max.CodeManager.Properties;
using Mirality.Max.MaxCodes;
using x7fd6e610350f13fb;

namespace x4c5768933ca951f6;

public class xa781f36c24e56139 : Form
{
	private CheckBox x0865f209abc47e20;

	private CheckBox xecc70680e3124a02;

	private CheckBox x833f40ff9a375006;

	private TextBox x4bbcfe3ae938ec42;

	private TextBox xe5c0640d377dc04b;

	private Button x573ef430e89273b9;

	private Button xe1950bd75f8dbe3c;

	private Button x8c7441c6635b5683;

	private Button x77c138625e4a3561;

	private CheckBox x94ca1f4ebf662bf0;

	private RadioButton x7ec659e8e003c7a0;

	private RadioButton x5dcecdbcecfdf0c5;

	private GroupBox x11d2f95be7b33928;

	private GroupBox x44e4b4b35d0f09c5;

	private GroupBox xe914cb7dbc719011;

	private GroupBox x0193757cf329741b;

	private FolderBrowserDialog xfa5200f5f1f4031a;

	private FolderBrowserDialog xeea023a82ca83e7e;

	private GroupBox x8449073d6e83cb58;

	private RadioButton x5dea8ad7c68dcfc4;

	private RadioButton xd0c9b0178d2d2c96;

	private TextBox x55d8618b4282da0e;

	private Label xdd00d3692b1c1ee1;

	private NumericUpDown x083ab98fa187510b;

	private RadioButton x786ce70842516129;

	private TextBox x8499fa45735b4124;

	private Label x0cea059370674ec2;

	private TextBox xf337d5b05d4d4af6;

	private Label xc683d554d7a14bd8;

	private GroupBox xc8242ee8218aa77f;

	private Button x9799b6bfcca90c48;

	private RadioButton x655f693bc2258970;

	private PictureBox x75b47eeb97c30ae5;

	private Container xb7dfc13308b54974;

	private GroupBox xd4c6067caf5ba71b;

	private PictureBox x35c6eb08d8fcb363;

	private Label x64b4c4f4014c9e98;

	private Label x571f5f52141a48af;

	private CheckBox xc9110e497eaad60e;

	private GroupBox x850039c0e574346b;

	private PictureBox x0219d3460eb06088;

	private CheckBox xf397a94467ae55d2;

	private bool _68ff273cc374232d;

	public bool x68ff273cc374232d => _68ff273cc374232d;

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
		x0865f209abc47e20 = new CheckBox();
		x11d2f95be7b33928 = new GroupBox();
		xc9110e497eaad60e = new CheckBox();
		x44e4b4b35d0f09c5 = new GroupBox();
		xecc70680e3124a02 = new CheckBox();
		x833f40ff9a375006 = new CheckBox();
		x94ca1f4ebf662bf0 = new CheckBox();
		xe914cb7dbc719011 = new GroupBox();
		x4bbcfe3ae938ec42 = new TextBox();
		xe5c0640d377dc04b = new TextBox();
		x573ef430e89273b9 = new Button();
		xe1950bd75f8dbe3c = new Button();
		x8c7441c6635b5683 = new Button();
		x77c138625e4a3561 = new Button();
		x0193757cf329741b = new GroupBox();
		x7ec659e8e003c7a0 = new RadioButton();
		x5dcecdbcecfdf0c5 = new RadioButton();
		x655f693bc2258970 = new RadioButton();
		xfa5200f5f1f4031a = new FolderBrowserDialog();
		xeea023a82ca83e7e = new FolderBrowserDialog();
		x8449073d6e83cb58 = new GroupBox();
		x083ab98fa187510b = new NumericUpDown();
		xdd00d3692b1c1ee1 = new Label();
		x55d8618b4282da0e = new TextBox();
		x5dea8ad7c68dcfc4 = new RadioButton();
		xd0c9b0178d2d2c96 = new RadioButton();
		x786ce70842516129 = new RadioButton();
		x8499fa45735b4124 = new TextBox();
		x0cea059370674ec2 = new Label();
		xf337d5b05d4d4af6 = new TextBox();
		xc683d554d7a14bd8 = new Label();
		xc8242ee8218aa77f = new GroupBox();
		x75b47eeb97c30ae5 = new PictureBox();
		x9799b6bfcca90c48 = new Button();
		xd4c6067caf5ba71b = new GroupBox();
		x35c6eb08d8fcb363 = new PictureBox();
		x571f5f52141a48af = new Label();
		x64b4c4f4014c9e98 = new Label();
		x850039c0e574346b = new GroupBox();
		x0219d3460eb06088 = new PictureBox();
		xf397a94467ae55d2 = new CheckBox();
		Label label = new Label();
		Label label2 = new Label();
		Label label3 = new Label();
		Label label4 = new Label();
		Label label5 = new Label();
		x11d2f95be7b33928.SuspendLayout();
		x44e4b4b35d0f09c5.SuspendLayout();
		xe914cb7dbc719011.SuspendLayout();
		x0193757cf329741b.SuspendLayout();
		x8449073d6e83cb58.SuspendLayout();
		((ISupportInitialize)x083ab98fa187510b).BeginInit();
		xc8242ee8218aa77f.SuspendLayout();
		((ISupportInitialize)x75b47eeb97c30ae5).BeginInit();
		xd4c6067caf5ba71b.SuspendLayout();
		((ISupportInitialize)x35c6eb08d8fcb363).BeginInit();
		x850039c0e574346b.SuspendLayout();
		((ISupportInitialize)x0219d3460eb06088).BeginInit();
		SuspendLayout();
		label.Location = new Point(8, 16);
		label.Name = "label1";
		label.Size = new Size(80, 20);
		label.TabIndex = 0;
		label.Text = "Saves folder:";
		label.TextAlign = ContentAlignment.MiddleLeft;
		label2.Location = new Point(8, 40);
		label2.Name = "label2";
		label2.Size = new Size(80, 20);
		label2.TabIndex = 3;
		label2.Text = "USB Drive:";
		label2.TextAlign = ContentAlignment.MiddleLeft;
		label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		label3.Location = new Point(8, 17);
		label3.Name = "label3";
		label3.Size = new Size(222, 28);
		label3.TabIndex = 0;
		label3.Text = "This is optional, but recommended.  You will need to have your ARMAX CD handy.";
		label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		label4.Location = new Point(8, 17);
		label4.Name = "label4";
		label4.Size = new Size(232, 16);
		label4.TabIndex = 0;
		label4.Text = "This allows you to add codes to a codelist.";
		label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		label5.Location = new Point(8, 37);
		label5.Name = "label7";
		label5.Size = new Size(340, 16);
		label5.TabIndex = 1;
		label5.Text = "Experimental functionality intended for experienced code authors.";
		x0865f209abc47e20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x0865f209abc47e20.Location = new Point(16, 19);
		x0865f209abc47e20.Name = "checkBoxCheckServer";
		x0865f209abc47e20.Size = new Size(438, 24);
		x0865f209abc47e20.TabIndex = 0;
		x0865f209abc47e20.Text = "Check CodeJunkies server on startup (detect whether a new codelist is available)";
		x11d2f95be7b33928.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x11d2f95be7b33928.Controls.Add(xc9110e497eaad60e);
		x11d2f95be7b33928.Controls.Add(x0865f209abc47e20);
		x11d2f95be7b33928.Location = new Point(12, 12);
		x11d2f95be7b33928.Name = "groupBoxStartup";
		x11d2f95be7b33928.Size = new Size(462, 76);
		x11d2f95be7b33928.TabIndex = 0;
		x11d2f95be7b33928.TabStop = false;
		x11d2f95be7b33928.Text = "Startup";
		xc9110e497eaad60e.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xc9110e497eaad60e.Location = new Point(16, 45);
		xc9110e497eaad60e.Name = "checkBoxCheckAssociations";
		xc9110e497eaad60e.Size = new Size(438, 24);
		xc9110e497eaad60e.TabIndex = 1;
		xc9110e497eaad60e.Text = "Check whether MCM is associated with .mcmcode files";
		x44e4b4b35d0f09c5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x44e4b4b35d0f09c5.Controls.Add(xecc70680e3124a02);
		x44e4b4b35d0f09c5.Controls.Add(x833f40ff9a375006);
		x44e4b4b35d0f09c5.Controls.Add(x94ca1f4ebf662bf0);
		x44e4b4b35d0f09c5.Location = new Point(12, 172);
		x44e4b4b35d0f09c5.Name = "groupBoxExport";
		x44e4b4b35d0f09c5.Size = new Size(348, 96);
		x44e4b4b35d0f09c5.TabIndex = 2;
		x44e4b4b35d0f09c5.TabStop = false;
		x44e4b4b35d0f09c5.Text = "Export";
		xecc70680e3124a02.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xecc70680e3124a02.Location = new Point(16, 17);
		xecc70680e3124a02.Name = "checkBoxExportSaves";
		xecc70680e3124a02.Size = new Size(326, 24);
		xecc70680e3124a02.TabIndex = 0;
		xecc70680e3124a02.Text = "Export to MaxDrive Saves folder";
		x833f40ff9a375006.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x833f40ff9a375006.Location = new Point(16, 43);
		x833f40ff9a375006.Name = "checkBoxExportUSB";
		x833f40ff9a375006.Size = new Size(326, 24);
		x833f40ff9a375006.TabIndex = 1;
		x833f40ff9a375006.Text = "Export to specific USB (or other) drive";
		x94ca1f4ebf662bf0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x94ca1f4ebf662bf0.Location = new Point(16, 67);
		x94ca1f4ebf662bf0.Name = "checkBoxExportRemovable";
		x94ca1f4ebf662bf0.Size = new Size(326, 24);
		x94ca1f4ebf662bf0.TabIndex = 2;
		x94ca1f4ebf662bf0.Text = "Export to all removable drives";
		xe914cb7dbc719011.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xe914cb7dbc719011.Controls.Add(x4bbcfe3ae938ec42);
		xe914cb7dbc719011.Controls.Add(label);
		xe914cb7dbc719011.Controls.Add(label2);
		xe914cb7dbc719011.Controls.Add(xe5c0640d377dc04b);
		xe914cb7dbc719011.Controls.Add(x573ef430e89273b9);
		xe914cb7dbc719011.Controls.Add(xe1950bd75f8dbe3c);
		xe914cb7dbc719011.Location = new Point(12, 94);
		xe914cb7dbc719011.Name = "groupBoxLocations";
		xe914cb7dbc719011.Size = new Size(462, 72);
		xe914cb7dbc719011.TabIndex = 1;
		xe914cb7dbc719011.TabStop = false;
		xe914cb7dbc719011.Text = "Locations";
		x4bbcfe3ae938ec42.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x4bbcfe3ae938ec42.Location = new Point(92, 16);
		x4bbcfe3ae938ec42.Name = "textBoxFolderSaves";
		x4bbcfe3ae938ec42.Size = new Size(338, 20);
		x4bbcfe3ae938ec42.TabIndex = 1;
		xe5c0640d377dc04b.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xe5c0640d377dc04b.Location = new Point(92, 40);
		xe5c0640d377dc04b.Name = "textBoxFolderUSB";
		xe5c0640d377dc04b.Size = new Size(338, 20);
		xe5c0640d377dc04b.TabIndex = 4;
		x573ef430e89273b9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x573ef430e89273b9.Location = new Point(430, 16);
		x573ef430e89273b9.Name = "buttonBrowseSaves";
		x573ef430e89273b9.Size = new Size(24, 20);
		x573ef430e89273b9.TabIndex = 2;
		x573ef430e89273b9.Text = "...";
		x573ef430e89273b9.Click += x51798353a01bae7d;
		xe1950bd75f8dbe3c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		xe1950bd75f8dbe3c.Location = new Point(430, 40);
		xe1950bd75f8dbe3c.Name = "buttonBrowseUSB";
		xe1950bd75f8dbe3c.Size = new Size(24, 20);
		xe1950bd75f8dbe3c.TabIndex = 5;
		xe1950bd75f8dbe3c.Text = "...";
		xe1950bd75f8dbe3c.Click += x6f80e1d4cf4cda0b;
		x8c7441c6635b5683.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x8c7441c6635b5683.DialogResult = DialogResult.Cancel;
		x8c7441c6635b5683.Location = new Point(399, 587);
		x8c7441c6635b5683.Name = "buttonCancel";
		x8c7441c6635b5683.Size = new Size(75, 23);
		x8c7441c6635b5683.TabIndex = 9;
		x8c7441c6635b5683.Text = "Cancel";
		x77c138625e4a3561.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x77c138625e4a3561.DialogResult = DialogResult.OK;
		x77c138625e4a3561.Location = new Point(318, 587);
		x77c138625e4a3561.Name = "buttonOk";
		x77c138625e4a3561.Size = new Size(75, 23);
		x77c138625e4a3561.TabIndex = 8;
		x77c138625e4a3561.Text = "OK";
		x77c138625e4a3561.Click += xeebb56e8f7be7895;
		x0193757cf329741b.Controls.Add(x7ec659e8e003c7a0);
		x0193757cf329741b.Controls.Add(x5dcecdbcecfdf0c5);
		x0193757cf329741b.Controls.Add(x655f693bc2258970);
		x0193757cf329741b.Location = new Point(366, 172);
		x0193757cf329741b.Name = "groupBoxRegion";
		x0193757cf329741b.Size = new Size(108, 96);
		x0193757cf329741b.TabIndex = 3;
		x0193757cf329741b.TabStop = false;
		x0193757cf329741b.Text = "Console Type";
		x7ec659e8e003c7a0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x7ec659e8e003c7a0.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		x7ec659e8e003c7a0.Location = new Point(16, 17);
		x7ec659e8e003c7a0.Name = "radioButtonRegionPal";
		x7ec659e8e003c7a0.Size = new Size(86, 24);
		x7ec659e8e003c7a0.TabIndex = 0;
		x7ec659e8e003c7a0.Text = "PAL";
		x5dcecdbcecfdf0c5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x5dcecdbcecfdf0c5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		x5dcecdbcecfdf0c5.Location = new Point(16, 41);
		x5dcecdbcecfdf0c5.Name = "radioButtonRegionNtsc";
		x5dcecdbcecfdf0c5.Size = new Size(86, 24);
		x5dcecdbcecfdf0c5.TabIndex = 1;
		x5dcecdbcecfdf0c5.Text = "NTSC";
		x655f693bc2258970.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x655f693bc2258970.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		x655f693bc2258970.Location = new Point(16, 65);
		x655f693bc2258970.Name = "radioButtonRegionMixed";
		x655f693bc2258970.Size = new Size(86, 24);
		x655f693bc2258970.TabIndex = 2;
		x655f693bc2258970.Text = "Both";
		xfa5200f5f1f4031a.Description = "Select your MaxDrive Saves folder:\r\n(normally C:\\Program Files\\Datel\\MaxDrive PS2\\Saves)";
		xeea023a82ca83e7e.Description = "Select your MAXDrive's drive letter (it will only appear if you already have it plugged in), or any other folder where you want exported codelists to be written:";
		x8449073d6e83cb58.Controls.Add(x083ab98fa187510b);
		x8449073d6e83cb58.Controls.Add(xdd00d3692b1c1ee1);
		x8449073d6e83cb58.Controls.Add(x55d8618b4282da0e);
		x8449073d6e83cb58.Controls.Add(x5dea8ad7c68dcfc4);
		x8449073d6e83cb58.Controls.Add(xd0c9b0178d2d2c96);
		x8449073d6e83cb58.Controls.Add(x786ce70842516129);
		x8449073d6e83cb58.Controls.Add(x8499fa45735b4124);
		x8449073d6e83cb58.Controls.Add(x0cea059370674ec2);
		x8449073d6e83cb58.Controls.Add(xf337d5b05d4d4af6);
		x8449073d6e83cb58.Controls.Add(xc683d554d7a14bd8);
		x8449073d6e83cb58.Location = new Point(12, 456);
		x8449073d6e83cb58.Name = "groupBoxProxy";
		x8449073d6e83cb58.Size = new Size(462, 124);
		x8449073d6e83cb58.TabIndex = 7;
		x8449073d6e83cb58.TabStop = false;
		x8449073d6e83cb58.Text = "Proxy";
		x083ab98fa187510b.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x083ab98fa187510b.Location = new Point(394, 68);
		x083ab98fa187510b.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		x083ab98fa187510b.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		x083ab98fa187510b.Name = "numericUpDownProxyPort";
		x083ab98fa187510b.Size = new Size(60, 20);
		x083ab98fa187510b.TabIndex = 5;
		x083ab98fa187510b.Value = new decimal(new int[4] { 8080, 0, 0, 0 });
		xdd00d3692b1c1ee1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		xdd00d3692b1c1ee1.Location = new Point(366, 70);
		xdd00d3692b1c1ee1.Name = "labelProxyPort";
		xdd00d3692b1c1ee1.Size = new Size(28, 16);
		xdd00d3692b1c1ee1.TabIndex = 4;
		xdd00d3692b1c1ee1.Text = "port";
		x55d8618b4282da0e.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x55d8618b4282da0e.Location = new Point(164, 68);
		x55d8618b4282da0e.Name = "textBoxProxyHost";
		x55d8618b4282da0e.Size = new Size(198, 20);
		x55d8618b4282da0e.TabIndex = 3;
		x5dea8ad7c68dcfc4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x5dea8ad7c68dcfc4.Location = new Point(16, 44);
		x5dea8ad7c68dcfc4.Name = "radioButtonProxyDefault";
		x5dea8ad7c68dcfc4.Size = new Size(434, 20);
		x5dea8ad7c68dcfc4.TabIndex = 1;
		x5dea8ad7c68dcfc4.Text = "Use manual proxy settings from the Internet control panel (and Internet Explorer)";
		x5dea8ad7c68dcfc4.CheckedChanged += x6fbbff5fdd3a64d7;
		xd0c9b0178d2d2c96.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xd0c9b0178d2d2c96.Location = new Point(16, 20);
		xd0c9b0178d2d2c96.Name = "radioButtonProxyNone";
		xd0c9b0178d2d2c96.Size = new Size(434, 20);
		xd0c9b0178d2d2c96.TabIndex = 0;
		xd0c9b0178d2d2c96.Text = "Do not use a proxy";
		xd0c9b0178d2d2c96.CheckedChanged += x6fbbff5fdd3a64d7;
		x786ce70842516129.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x786ce70842516129.Location = new Point(16, 68);
		x786ce70842516129.Name = "radioButtonProxySpecific";
		x786ce70842516129.Size = new Size(434, 20);
		x786ce70842516129.TabIndex = 2;
		x786ce70842516129.Text = "Use specific HTTP proxy:";
		x786ce70842516129.CheckedChanged += x6fbbff5fdd3a64d7;
		x8499fa45735b4124.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x8499fa45735b4124.Location = new Point(202, 92);
		x8499fa45735b4124.Name = "textBoxProxyUser";
		x8499fa45735b4124.Size = new Size(100, 20);
		x8499fa45735b4124.TabIndex = 7;
		x0cea059370674ec2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x0cea059370674ec2.Location = new Point(166, 94);
		x0cea059370674ec2.Name = "labelProxyUser";
		x0cea059370674ec2.Size = new Size(32, 16);
		x0cea059370674ec2.TabIndex = 6;
		x0cea059370674ec2.Text = "User:";
		xf337d5b05d4d4af6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		xf337d5b05d4d4af6.Location = new Point(356, 92);
		xf337d5b05d4d4af6.Name = "textBoxProxyPwd";
		xf337d5b05d4d4af6.Size = new Size(100, 20);
		xf337d5b05d4d4af6.TabIndex = 9;
		xf337d5b05d4d4af6.UseSystemPasswordChar = true;
		xc683d554d7a14bd8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		xc683d554d7a14bd8.Location = new Point(318, 94);
		xc683d554d7a14bd8.Name = "labelProxyPwd";
		xc683d554d7a14bd8.Size = new Size(32, 16);
		xc683d554d7a14bd8.TabIndex = 8;
		xc683d554d7a14bd8.Text = "Pwd:";
		xc8242ee8218aa77f.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xc8242ee8218aa77f.Controls.Add(x75b47eeb97c30ae5);
		xc8242ee8218aa77f.Controls.Add(x9799b6bfcca90c48);
		xc8242ee8218aa77f.Controls.Add(label3);
		xc8242ee8218aa77f.Location = new Point(12, 274);
		xc8242ee8218aa77f.Name = "groupBoxOriginal";
		xc8242ee8218aa77f.Size = new Size(462, 56);
		xc8242ee8218aa77f.TabIndex = 4;
		xc8242ee8218aa77f.TabStop = false;
		xc8242ee8218aa77f.Text = "Codelists from original CD";
		x75b47eeb97c30ae5.Image = Resources.OriginalListUnavailable;
		x75b47eeb97c30ae5.Location = new Point(354, 15);
		x75b47eeb97c30ae5.Name = "pictureBoxOriginalStatus";
		x75b47eeb97c30ae5.Size = new Size(100, 32);
		x75b47eeb97c30ae5.SizeMode = PictureBoxSizeMode.AutoSize;
		x75b47eeb97c30ae5.TabIndex = 3;
		x75b47eeb97c30ae5.TabStop = false;
		x9799b6bfcca90c48.Location = new Point(267, 19);
		x9799b6bfcca90c48.Name = "buttonOriginalImport";
		x9799b6bfcca90c48.Size = new Size(75, 23);
		x9799b6bfcca90c48.TabIndex = 1;
		x9799b6bfcca90c48.Text = "Import";
		x9799b6bfcca90c48.Click += xecd23237d2f0d999;
		xd4c6067caf5ba71b.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xd4c6067caf5ba71b.Controls.Add(x35c6eb08d8fcb363);
		xd4c6067caf5ba71b.Controls.Add(x571f5f52141a48af);
		xd4c6067caf5ba71b.Controls.Add(x64b4c4f4014c9e98);
		xd4c6067caf5ba71b.Controls.Add(label4);
		xd4c6067caf5ba71b.Location = new Point(12, 336);
		xd4c6067caf5ba71b.Name = "groupBoxEngine";
		xd4c6067caf5ba71b.Size = new Size(462, 56);
		xd4c6067caf5ba71b.TabIndex = 5;
		xd4c6067caf5ba71b.TabStop = false;
		xd4c6067caf5ba71b.Text = "Decryption Engine";
		x35c6eb08d8fcb363.Image = Resources.OriginalListUnavailable;
		x35c6eb08d8fcb363.Location = new Point(354, 15);
		x35c6eb08d8fcb363.Name = "pictureBoxEngineDecryptStatus";
		x35c6eb08d8fcb363.Size = new Size(100, 32);
		x35c6eb08d8fcb363.SizeMode = PictureBoxSizeMode.AutoSize;
		x35c6eb08d8fcb363.TabIndex = 3;
		x35c6eb08d8fcb363.TabStop = false;
		x571f5f52141a48af.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x571f5f52141a48af.Location = new Point(235, 15);
		x571f5f52141a48af.Name = "labelEngineOfficial";
		x571f5f52141a48af.Size = new Size(115, 16);
		x571f5f52141a48af.TabIndex = 1;
		x571f5f52141a48af.Text = "(official version or not)";
		x571f5f52141a48af.TextAlign = ContentAlignment.TopRight;
		x64b4c4f4014c9e98.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x64b4c4f4014c9e98.Location = new Point(16, 33);
		x64b4c4f4014c9e98.Name = "labelEngineInfo";
		x64b4c4f4014c9e98.Size = new Size(326, 16);
		x64b4c4f4014c9e98.TabIndex = 2;
		x64b4c4f4014c9e98.Text = "(version information)";
		x850039c0e574346b.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x850039c0e574346b.Controls.Add(xf397a94467ae55d2);
		x850039c0e574346b.Controls.Add(x0219d3460eb06088);
		x850039c0e574346b.Controls.Add(label5);
		x850039c0e574346b.Location = new Point(12, 398);
		x850039c0e574346b.Name = "groupBox1";
		x850039c0e574346b.Size = new Size(462, 56);
		x850039c0e574346b.TabIndex = 6;
		x850039c0e574346b.TabStop = false;
		x850039c0e574346b.Text = "Advanced Code Editing";
		x0219d3460eb06088.Image = Resources.OriginalListUnavailable;
		x0219d3460eb06088.Location = new Point(354, 15);
		x0219d3460eb06088.Name = "pictureBoxEngineEncryptStatus";
		x0219d3460eb06088.Size = new Size(100, 32);
		x0219d3460eb06088.SizeMode = PictureBoxSizeMode.AutoSize;
		x0219d3460eb06088.TabIndex = 3;
		x0219d3460eb06088.TabStop = false;
		xf397a94467ae55d2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		xf397a94467ae55d2.Location = new Point(12, 15);
		xf397a94467ae55d2.Name = "checkBoxAdvancedCodeEditing";
		xf397a94467ae55d2.Size = new Size(336, 19);
		xf397a94467ae55d2.TabIndex = 0;
		xf397a94467ae55d2.Text = "Enable advanced code editing features (if available)";
		AutoScaleBaseSize = new Size(5, 13);
		base.ClientSize = new Size(486, 622);
		base.ControlBox = false;
		base.Controls.Add(x850039c0e574346b);
		base.Controls.Add(xd4c6067caf5ba71b);
		base.Controls.Add(xc8242ee8218aa77f);
		base.Controls.Add(x8449073d6e83cb58);
		base.Controls.Add(x0193757cf329741b);
		base.Controls.Add(x8c7441c6635b5683);
		base.Controls.Add(x11d2f95be7b33928);
		base.Controls.Add(x44e4b4b35d0f09c5);
		base.Controls.Add(xe914cb7dbc719011);
		base.Controls.Add(x77c138625e4a3561);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Name = "SettingsForm";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Settings";
		x11d2f95be7b33928.ResumeLayout(performLayout: false);
		x44e4b4b35d0f09c5.ResumeLayout(performLayout: false);
		xe914cb7dbc719011.ResumeLayout(performLayout: false);
		xe914cb7dbc719011.PerformLayout();
		x0193757cf329741b.ResumeLayout(performLayout: false);
		x8449073d6e83cb58.ResumeLayout(performLayout: false);
		x8449073d6e83cb58.PerformLayout();
		((ISupportInitialize)x083ab98fa187510b).EndInit();
		xc8242ee8218aa77f.ResumeLayout(performLayout: false);
		xc8242ee8218aa77f.PerformLayout();
		((ISupportInitialize)x75b47eeb97c30ae5).EndInit();
		xd4c6067caf5ba71b.ResumeLayout(performLayout: false);
		xd4c6067caf5ba71b.PerformLayout();
		((ISupportInitialize)x35c6eb08d8fcb363).EndInit();
		x850039c0e574346b.ResumeLayout(performLayout: false);
		x850039c0e574346b.PerformLayout();
		((ISupportInitialize)x0219d3460eb06088).EndInit();
		ResumeLayout(performLayout: false);
	}

	public xa781f36c24e56139()
	{
		x85601834555fb7d5();
		xfa5200f5f1f4031a.RootFolder = Environment.SpecialFolder.MyComputer;
		xeea023a82ca83e7e.RootFolder = Environment.SpecialFolder.MyComputer;
	}

	protected override void OnLoad(EventArgs xfbf34718e704c6bc)
	{
		base.OnLoad(xfbf34718e704c6bc);
		x0865f209abc47e20.Checked = CodeManagerSettings.Instance.CheckServerOnStartup;
		xc9110e497eaad60e.Checked = CodeManagerSettings.Instance.CheckAssociations;
		x4bbcfe3ae938ec42.Text = CodeManagerSettings.Instance.SavesFolder;
		xe5c0640d377dc04b.Text = CodeManagerSettings.Instance.USBFolder;
		xecc70680e3124a02.Checked = CodeManagerSettings.Instance.ExportToSaves;
		x833f40ff9a375006.Checked = CodeManagerSettings.Instance.ExportToUSB;
		x94ca1f4ebf662bf0.Checked = CodeManagerSettings.Instance.ExportToRemovables;
		x7ec659e8e003c7a0.Checked = CodeManagerSettings.Instance.RegionCode == RegionCode.PAL;
		x5dcecdbcecfdf0c5.Checked = CodeManagerSettings.Instance.RegionCode == RegionCode.NTSC;
		x655f693bc2258970.Checked = CodeManagerSettings.Instance.RegionCode == RegionCode.Mixed;
		xd0c9b0178d2d2c96.Checked = CodeManagerSettings.Instance.Proxy == CodeManagerSettings.ProxyType.None;
		x5dea8ad7c68dcfc4.Checked = CodeManagerSettings.Instance.Proxy == CodeManagerSettings.ProxyType.Automatic;
		x786ce70842516129.Checked = CodeManagerSettings.Instance.Proxy == CodeManagerSettings.ProxyType.Specific;
		x55d8618b4282da0e.Text = CodeManagerSettings.Instance.SpecificProxyHost;
		x083ab98fa187510b.Value = CodeManagerSettings.Instance.SpecificProxyPort;
		x8499fa45735b4124.Text = CodeManagerSettings.Instance.SpecificProxyUsername;
		xf337d5b05d4d4af6.Text = CodeManagerSettings.Instance.SpecificProxyPassword;
		xf397a94467ae55d2.Checked = CodeManagerSettings.Instance.AdvancedEditingEnabled;
		x600ff1e284686a85();
		x58f34f0a504937f7();
	}

	private void x600ff1e284686a85()
	{
		bool flag = File.Exists(x77dccad1db69a78f.x93bd97d3afddf842);
		bool flag2 = File.Exists(x77dccad1db69a78f.x411b38a624544322);
		if (flag && flag2)
		{
			x75b47eeb97c30ae5.Image = Resources.OriginalListAvailable;
		}
		else if (flag)
		{
			x75b47eeb97c30ae5.Image = Resources.OriginalListPalOnly;
		}
		else if (flag2)
		{
			x75b47eeb97c30ae5.Image = Resources.OriginalListNtscOnly;
		}
		else
		{
			x75b47eeb97c30ae5.Image = Resources.OriginalListUnavailable;
		}
	}

	private void x58f34f0a504937f7()
	{
		x35c6eb08d8fcb363.Image = (x7bb28d9758d19dd0.x3452082a8fecf97d ? Resources.OriginalListAvailable : Resources.OriginalListUnavailable);
		x0219d3460eb06088.Image = (x7bb28d9758d19dd0.x3b67f7a0ce62b49b ? Resources.OriginalListAvailable : Resources.OriginalListUnavailable);
		if (x7bb28d9758d19dd0.x77fa6322561797a0 == null)
		{
			x64b4c4f4014c9e98.Text = "(no engine installed)";
			x571f5f52141a48af.Text = "";
			return;
		}
		string text = "";
		if (x7bb28d9758d19dd0.x54eeb852ed5036a2 == null)
		{
			x64b4c4f4014c9e98.Text = x7bb28d9758d19dd0.x77fa6322561797a0.FileDescription + " version " + x7bb28d9758d19dd0.x77fa6322561797a0.FileVersion;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] publicKeyToken = x7bb28d9758d19dd0.x54eeb852ed5036a2.GetPublicKeyToken();
			if (publicKeyToken != null)
			{
				byte[] array = publicKeyToken;
				foreach (byte b in array)
				{
					stringBuilder.AppendFormat("{0:X2}", b);
				}
			}
			text = stringBuilder.ToString();
			x64b4c4f4014c9e98.Text = x7bb28d9758d19dd0.x54eeb852ed5036a2.Name + " v" + x7bb28d9758d19dd0.x54eeb852ed5036a2.Version.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				Label label = x64b4c4f4014c9e98;
				label.Text = label.Text + ": " + text;
			}
		}
		x571f5f52141a48af.Text = ((text == "EDF4B7B938177FE8") ? "(official version)" : "(third party)");
	}

	private void x51798353a01bae7d(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xfa5200f5f1f4031a.SelectedPath = x4bbcfe3ae938ec42.Text;
		if (xfa5200f5f1f4031a.ShowDialog(this) == DialogResult.OK)
		{
			x4bbcfe3ae938ec42.Text = xfa5200f5f1f4031a.SelectedPath;
		}
	}

	private void x6f80e1d4cf4cda0b(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		xeea023a82ca83e7e.SelectedPath = xe5c0640d377dc04b.Text;
		if (xeea023a82ca83e7e.ShowDialog(this) == DialogResult.OK)
		{
			xe5c0640d377dc04b.Text = xeea023a82ca83e7e.SelectedPath;
		}
	}

	private void x6fbbff5fdd3a64d7(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		bool @checked = x786ce70842516129.Checked;
		x55d8618b4282da0e.Enabled = @checked;
		xdd00d3692b1c1ee1.Enabled = @checked;
		x083ab98fa187510b.Enabled = @checked;
		x0cea059370674ec2.Enabled = @checked;
		x8499fa45735b4124.Enabled = @checked;
		xc683d554d7a14bd8.Enabled = @checked;
		xf337d5b05d4d4af6.Enabled = @checked;
	}

	private void xecd23237d2f0d999(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (xe61d04ba452a602f.xeb24bb06e5c302f8(this))
		{
			_68ff273cc374232d = true;
			x600ff1e284686a85();
		}
	}

	private void xeebb56e8f7be7895(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		CodeManagerSettings.Instance.CheckServerOnStartup = x0865f209abc47e20.Checked;
		CodeManagerSettings.Instance.CheckAssociations = xc9110e497eaad60e.Checked;
		CodeManagerSettings.Instance.SavesFolder = x4bbcfe3ae938ec42.Text;
		CodeManagerSettings.Instance.USBFolder = xe5c0640d377dc04b.Text;
		CodeManagerSettings.Instance.ExportToSaves = xecc70680e3124a02.Checked;
		CodeManagerSettings.Instance.ExportToUSB = x833f40ff9a375006.Checked;
		CodeManagerSettings.Instance.ExportToRemovables = x94ca1f4ebf662bf0.Checked;
		if (x7ec659e8e003c7a0.Checked)
		{
			CodeManagerSettings.Instance.RegionCode = RegionCode.PAL;
		}
		else if (x5dcecdbcecfdf0c5.Checked)
		{
			CodeManagerSettings.Instance.RegionCode = RegionCode.NTSC;
		}
		else if (x655f693bc2258970.Checked)
		{
			CodeManagerSettings.Instance.RegionCode = RegionCode.Mixed;
		}
		if (xd0c9b0178d2d2c96.Checked)
		{
			CodeManagerSettings.Instance.Proxy = CodeManagerSettings.ProxyType.None;
		}
		else if (x786ce70842516129.Checked)
		{
			CodeManagerSettings.Instance.Proxy = CodeManagerSettings.ProxyType.Specific;
		}
		else
		{
			CodeManagerSettings.Instance.Proxy = CodeManagerSettings.ProxyType.Automatic;
		}
		CodeManagerSettings.Instance.SpecificProxyHost = x55d8618b4282da0e.Text;
		CodeManagerSettings.Instance.SpecificProxyPort = (int)x083ab98fa187510b.Value;
		CodeManagerSettings.Instance.SpecificProxyUsername = x8499fa45735b4124.Text;
		CodeManagerSettings.Instance.SpecificProxyPassword = xf337d5b05d4d4af6.Text;
		CodeManagerSettings.Instance.AdvancedEditingEnabled = xf397a94467ae55d2.Checked;
	}
}
