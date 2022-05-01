using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace xca7bfd2e2e8437c4;

[DefaultEvent("NodeMouseDoubleClick")]
[Designer(typeof(x63dfb5c0c0104071), typeof(IDesigner))]
[DefaultProperty("Nodes")]
public class xea5e4be807a4597b : ScrollableControl
{
	private int _941a43d4a5637fd0 = -1;

	private int _5b1e6d73a61cb6dc = 16;

	private bool _9c5ffe3efcbc9a09;

	private bool _f3e2af18efbec93d;

	private Color _3c68d0a3c5adb970 = Color.Black;

	private bool _fb7eed5237ac7734 = true;

	private bool _95a235bff44ec867 = true;

	private bool _eeb72f5f2d391f6f = true;

	private x03a477b12104a885 _2a8b7cba94394169 = new x03a477b12104a885();

	private VerticalAlignment _e7e03246bec9d3a9 = VerticalAlignment.Center;

	private BorderStyle _64b4c49ed703037e = BorderStyle.Fixed3D;

	private int _89559d4af34bdf2e;

	private int _6641d600af281f21;

	private bool _65ae7187ad9944b4;

	private IComparer<x95fcf261e3011b00> _97ebca14fccfbefa;

	private x95fcf261e3011b00 _29e7ace4c90f74cd;

	private IList<x95fcf261e3011b00> _4dcf8d74821042cd;

	protected override Size DefaultSize => new Size(121, 97);

	[Category("Appearance")]
	[Description("Horizontal indentation between successive node levels.")]
	public int x941a43d4a5637fd0
	{
		get
		{
			return Math.Max(_941a43d4a5637fd0, x9e6d06d2183a662c());
		}
		set
		{
			_941a43d4a5637fd0 = ((value <= x9e6d06d2183a662c()) ? (-1) : value);
			Invalidate();
		}
	}

	[DefaultValue(16)]
	[Category("Appearance")]
	[Description("Height for all nodes that don't specify otherwise.")]
	public int x5b1e6d73a61cb6dc
	{
		get
		{
			return Math.Max(_5b1e6d73a61cb6dc, xb649229befc1f999());
		}
		set
		{
			_5b1e6d73a61cb6dc = value;
			x7facab8f46b5857c();
		}
	}

	public override Color BackColor
	{
		get
		{
			return base.BackColor;
		}
		set
		{
			base.BackColor = value;
		}
	}

	public override Color ForeColor
	{
		get
		{
			return base.ForeColor;
		}
		set
		{
			base.ForeColor = value;
		}
	}

	[DefaultValue(typeof(Color), "Black")]
	[Description("Colour used to draw the node lines.")]
	[Category("Appearance")]
	public Color x3c68d0a3c5adb970
	{
		get
		{
			return _3c68d0a3c5adb970;
		}
		set
		{
			_3c68d0a3c5adb970 = value;
			Invalidate();
		}
	}

	[Description("Whether to show lines connecting each node or not.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool xfb7eed5237ac7734
	{
		get
		{
			return _fb7eed5237ac7734;
		}
		set
		{
			_fb7eed5237ac7734 = value;
			Invalidate();
		}
	}

	[Description("If false, no lines are drawn connecting the root nodes.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool x95a235bff44ec867
	{
		get
		{
			return _95a235bff44ec867;
		}
		set
		{
			_95a235bff44ec867 = value;
			Invalidate();
		}
	}

	[Description("Displays the plus/minus glyphs on parent nodes.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool xeeb72f5f2d391f6f
	{
		get
		{
			return _eeb72f5f2d391f6f;
		}
		set
		{
			_eeb72f5f2d391f6f = value;
			Invalidate();
		}
	}

	[Localizable(true)]
	[Description("The image list used to display node icons.")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(null)]
	[Category("Behavior")]
	public ImageList x7bc501a48fc6524b
	{
		get
		{
			return _2a8b7cba94394169.ImageList;
		}
		set
		{
			if (value != _2a8b7cba94394169.ImageList)
			{
				EventHandler value2 = xbb56c29a78b232c7;
				EventHandler value3 = x4adfb251dee41055;
				if (_2a8b7cba94394169.ImageList != null)
				{
					_2a8b7cba94394169.ImageList.RecreateHandle -= value3;
					_2a8b7cba94394169.ImageList.Disposed -= value2;
				}
				_2a8b7cba94394169.ImageList = value;
				if (_2a8b7cba94394169.ImageList != null)
				{
					_2a8b7cba94394169.ImageList.Disposed += value2;
					_2a8b7cba94394169.ImageList.RecreateHandle += value3;
				}
				x7facab8f46b5857c();
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(typeof(VerticalAlignment), "Center")]
	[Description("Where the image is shown, if it's smaller than the node height")]
	public VerticalAlignment xe7e03246bec9d3a9
	{
		get
		{
			return _e7e03246bec9d3a9;
		}
		set
		{
			_e7e03246bec9d3a9 = value;
			x7facab8f46b5857c();
		}
	}

	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	[TypeConverter(typeof(x3ffb2c0598c99a48))]
	[Description("Image index used by default.")]
	[DefaultValue(-1)]
	[RelatedImageList("ImageList")]
	[Localizable(true)]
	public int xaa7785f730d8dd15
	{
		get
		{
			if (x7bc501a48fc6524b == null)
			{
				return -1;
			}
			if (_2a8b7cba94394169.Index >= x7bc501a48fc6524b.Images.Count)
			{
				return Math.Max(0, x7bc501a48fc6524b.Images.Count - 1);
			}
			return _2a8b7cba94394169.Index;
		}
		set
		{
			if (value == -1)
			{
				value = 0;
			}
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", value, "Value cannot be negative.");
			}
			_2a8b7cba94394169.Index = value;
			Invalidate();
		}
	}

	[RefreshProperties(RefreshProperties.Repaint)]
	[Localizable(true)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Category("Behavior")]
	[DefaultValue("")]
	[RelatedImageList("ImageList")]
	[Description("Image key used by default.")]
	[TypeConverter(typeof(ImageKeyConverter))]
	public string xc439cbba6c00a3a0
	{
		get
		{
			return _2a8b7cba94394169.Key;
		}
		set
		{
			if (_2a8b7cba94394169.Key != value)
			{
				_2a8b7cba94394169.Key = value;
				if (string.IsNullOrEmpty(value))
				{
					xaa7785f730d8dd15 = ((x7bc501a48fc6524b == null) ? (-1) : 0);
				}
				Invalidate();
			}
		}
	}

	[DefaultValue(BorderStyle.Fixed3D)]
	[Description("The border drawn around the control (if any)")]
	[Category("Appearance")]
	public BorderStyle x64b4c49ed703037e
	{
		get
		{
			return _64b4c49ed703037e;
		}
		set
		{
			_64b4c49ed703037e = value;
			UpdateStyles();
		}
	}

	protected override CreateParams CreateParams
	{
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			CreateParams createParams = base.CreateParams;
			switch (_64b4c49ed703037e)
			{
			case BorderStyle.FixedSingle:
				createParams.Style |= 8388608;
				break;
			case BorderStyle.Fixed3D:
				if (xa2d155a7efb8fe1c() == null)
				{
					createParams.ExStyle |= 512;
				}
				break;
			}
			return createParams;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	protected override bool DoubleBuffered
	{
		get
		{
			return base.DoubleBuffered;
		}
		set
		{
			base.DoubleBuffered = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	protected bool x3587924af3bbb8b9
	{
		get
		{
			return base.ResizeRedraw;
		}
		set
		{
			base.ResizeRedraw = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool AutoScroll
	{
		get
		{
			return base.AutoScroll;
		}
		set
		{
			base.AutoScroll = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Bindable(false)]
	[Browsable(false)]
	public Size x4c4ce2a359986586
	{
		get
		{
			return base.AutoScrollMargin;
		}
		set
		{
			base.AutoScrollMargin = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Bindable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Size x5bbb82e31309cc73
	{
		get
		{
			return base.AutoScrollMinSize;
		}
		set
		{
			base.AutoScrollMinSize = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("If true, the tree is kept in sorted order.")]
	public bool x65ae7187ad9944b4
	{
		get
		{
			return _65ae7187ad9944b4;
		}
		set
		{
			if (_65ae7187ad9944b4 != value)
			{
				_65ae7187ad9944b4 = value;
				if (value)
				{
					x63b0f7fed3f5bd88.xee9aac96ed24c7f9();
				}
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public IComparer<x95fcf261e3011b00> x97ebca14fccfbefa
	{
		get
		{
			return _97ebca14fccfbefa;
		}
		set
		{
			if (_97ebca14fccfbefa != value)
			{
				_97ebca14fccfbefa = value;
				if (x65ae7187ad9944b4)
				{
					x63b0f7fed3f5bd88.xee9aac96ed24c7f9();
					Invalidate();
				}
			}
		}
	}

	internal x95fcf261e3011b00 x29e7ace4c90f74cd => _29e7ace4c90f74cd;

	[Category("Behavior")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[MergableProperty(false)]
	[Description("Tree view nodes.")]
	public x0bc7d5c84e62d912 x63b0f7fed3f5bd88 => _29e7ace4c90f74cd.x63b0f7fed3f5bd88;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IList<x95fcf261e3011b00> xc82eff4818ce3f25
	{
		get
		{
			if (_4dcf8d74821042cd == null)
			{
				_4dcf8d74821042cd = _29e7ace4c90f74cd.xc82eff4818ce3f25;
			}
			return _4dcf8d74821042cd;
		}
	}

	[Browsable(false)]
	public IEnumerable<x95fcf261e3011b00> x03a3afe609cec84c
	{
		get
		{
			if (x63b0f7fed3f5bd88.Count == 0)
			{
				yield break;
			}
			x95fcf261e3011b00 current = x63b0f7fed3f5bd88[0];
			while (current != null)
			{
				yield return current;
				if (current.x63b0f7fed3f5bd88.Count > 0)
				{
					current = current.x63b0f7fed3f5bd88[0];
					continue;
				}
				x95fcf261e3011b00 x4f6686d624d5dfe = current.x4f6686d624d5dfe1;
				while (x4f6686d624d5dfe == null)
				{
					current = current.x332a8eedb847940d;
					if (current != null)
					{
						x4f6686d624d5dfe = current.x4f6686d624d5dfe1;
						continue;
					}
					yield break;
				}
				current = x4f6686d624d5dfe;
			}
		}
	}

	[Category("Action")]
	[Description("Occurs when a node is about to be selected by the mouse.")]
	public event EventHandler<x495ca8a85eccbead> x12e020f3be9cb6f4;

	[Description("Occurs when a node's selection state has changed.")]
	[Category("Action")]
	public event EventHandler<x8f674b723ab8cda2> x1087ddccf8f41e6f;

	[Category("Action")]
	[Description("Occurs when the user clicks on the content part of a node.")]
	public event EventHandler<xfc646a3e9e0998cd> xa1547aa59dafcb58;

	[Description("Occurs when the user double-clicks on the content part of a node.")]
	[Category("Action")]
	public event EventHandler<xfc646a3e9e0998cd> x4d9c819fe95edefe;

	[Description("Occurs when a parent node is about to expand.")]
	[Category("Behavior")]
	public event EventHandler<x495ca8a85eccbead> x6b30bb6c5f41e32f;

	[Category("Behavior")]
	[Description("Occurs when a parent node is about to collapse.")]
	public event EventHandler<x495ca8a85eccbead> x25302ae69cf01877;

	[Description("Occurs when a parent node has been expanded.")]
	[Category("Behavior")]
	public event EventHandler<x8f674b723ab8cda2> x7757e023237c7679;

	[Description("Occurs when a parent node has been collapsed.")]
	[Category("Behavior")]
	public event EventHandler<x8f674b723ab8cda2> x8f530dd9a6341bae;

	private int x9e6d06d2183a662c()
	{
		return Math.Max(x39438fcd2804703e(), 16);
	}

	private int xb649229befc1f999()
	{
		return Math.Max(xcce8c934427d4656(), base.FontHeight);
	}

	public void xbe6554815812dcc4()
	{
		_941a43d4a5637fd0 = -1;
	}

	protected bool x0dc9194bddd27908()
	{
		return _941a43d4a5637fd0 != -1;
	}

	protected bool xeb89c6e7de3d9d0c()
	{
		return x5b1e6d73a61cb6dc > xb649229befc1f999();
	}

	protected virtual void UpdateNodeHeight(x95fcf261e3011b00 node, int x9b0739496f8b5475)
	{
	}

	private Rectangle xcd73b3729cbff83a(x95fcf261e3011b00 node, int xc941868c59399d3e)
	{
		return new Rectangle(base.ClientRectangle.Left, xc941868c59399d3e, base.ClientRectangle.Width, node.x449ad19c79665932);
	}

	internal void x7facab8f46b5857c()
	{
		if (_9c5ffe3efcbc9a09 || _89559d4af34bdf2e > 0)
		{
			_9c5ffe3efcbc9a09 = true;
			return;
		}
		x5577363cc650aaeb();
		try
		{
			Point autoScrollPosition = base.AutoScrollPosition;
			x5bbb82e31309cc73 = Size.Empty;
			int xc941868c59399d3e = base.ClientRectangle.Top;
			x7facab8f46b5857c(x63b0f7fed3f5bd88, ref xc941868c59399d3e);
			x5bbb82e31309cc73 = new Size(0, xc941868c59399d3e);
			base.AutoScrollPosition = new Point(-autoScrollPosition.X, -autoScrollPosition.Y);
		}
		finally
		{
			_9c5ffe3efcbc9a09 = false;
			x3ae2e4d73c7847ae();
		}
	}

	private void x7facab8f46b5857c(x0bc7d5c84e62d912 nodes, ref int xc941868c59399d3e)
	{
		foreach (x95fcf261e3011b00 item in nodes)
		{
			if (item.xa853df7acdb217c8)
			{
				item.x5099f0a842899426 = xcd73b3729cbff83a(item, xc941868c59399d3e);
				item.xe072b21e8fe21a7e(item.x5099f0a842899426, out var _, out var _, out var xc685053fae6eaa);
				UpdateNodeHeight(item, xc685053fae6eaa.Width);
				item.x5099f0a842899426 = xcd73b3729cbff83a(item, xc941868c59399d3e);
				xc941868c59399d3e = item.x5099f0a842899426.Bottom;
				x7facab8f46b5857c(item.x63b0f7fed3f5bd88, ref xc941868c59399d3e);
			}
			else
			{
				item.x5099f0a842899426 = Rectangle.Empty;
			}
		}
	}

	protected override void OnSizeChanged(EventArgs xfbf34718e704c6bc)
	{
		if (_f3e2af18efbec93d)
		{
			_f3e2af18efbec93d = false;
		}
		else
		{
			x7facab8f46b5857c();
		}
		base.OnSizeChanged(xfbf34718e704c6bc);
	}

	public void x65a62d6495d83a0f()
	{
		x29e7ace4c90f74cd.x65a62d6495d83a0f();
	}

	public void xa3d67626f8dfea9e()
	{
		x29e7ace4c90f74cd.xa3d67626f8dfea9e();
	}

	public x96bed71d06f031fe x68c86e2f125c51ea(Point x0b433f30d6157b49, out x95fcf261e3011b00 xb814177533985e8d)
	{
		xb814177533985e8d = null;
		x96bed71d06f031fe x96bed71d06f031fe2 = x96bed71d06f031fe.x4d0b9d4447ba7566;
		if (x0b433f30d6157b49.X < base.ClientRectangle.Left)
		{
			x96bed71d06f031fe2 |= x96bed71d06f031fe.xd1d7e90bb35953a4;
		}
		if (x0b433f30d6157b49.X > base.ClientRectangle.Right)
		{
			x96bed71d06f031fe2 |= x96bed71d06f031fe.x960e038eb6936d74;
		}
		if (x0b433f30d6157b49.Y < base.ClientRectangle.Top)
		{
			x96bed71d06f031fe2 |= x96bed71d06f031fe.x887a0c79ecbe5ee3;
		}
		if (x0b433f30d6157b49.Y > base.ClientRectangle.Bottom)
		{
			x96bed71d06f031fe2 |= x96bed71d06f031fe.x79a071bfba0c5e7d;
		}
		if (x96bed71d06f031fe2 != 0)
		{
			return x96bed71d06f031fe2;
		}
		return xf60cb2af5ee423f5(x0b433f30d6157b49, ref xb814177533985e8d, x63b0f7fed3f5bd88);
	}

	private x96bed71d06f031fe xf60cb2af5ee423f5(Point x0b433f30d6157b49, ref x95fcf261e3011b00 xb814177533985e8d, x0bc7d5c84e62d912 nodes)
	{
		x96bed71d06f031fe x96bed71d06f031fe2 = x96bed71d06f031fe.x4d0b9d4447ba7566;
		foreach (x95fcf261e3011b00 item in nodes)
		{
			Rectangle xda73fcb97c77d = x0d74e8d3eb8db1a0(item);
			if (!xda73fcb97c77d.IsEmpty && xda73fcb97c77d.Contains(x0b433f30d6157b49))
			{
				xb814177533985e8d = item;
				item.xe072b21e8fe21a7e(xda73fcb97c77d, out var x87dd47ddb178ff, out var x443b4b9ad47ce, out var xc685053fae6eaa);
				if (x87dd47ddb178ff.Contains(x0b433f30d6157b49))
				{
					x96bed71d06f031fe2 |= x96bed71d06f031fe.xd774dfd2741655e5;
				}
				if (x443b4b9ad47ce.Contains(x0b433f30d6157b49))
				{
					x96bed71d06f031fe2 |= x96bed71d06f031fe.x43368c0580f8c855;
				}
				if (xc685053fae6eaa.Contains(x0b433f30d6157b49))
				{
					x96bed71d06f031fe2 |= x96bed71d06f031fe.x4687427033f47a9e;
				}
				return x96bed71d06f031fe2;
			}
			x96bed71d06f031fe2 = xf60cb2af5ee423f5(x0b433f30d6157b49, ref xb814177533985e8d, item.x63b0f7fed3f5bd88);
			if (xb814177533985e8d != null)
			{
				return x96bed71d06f031fe2;
			}
		}
		return x96bed71d06f031fe2;
	}

	private Rectangle x0d74e8d3eb8db1a0(x95fcf261e3011b00 node)
	{
		if (node.xa853df7acdb217c8)
		{
			Rectangle x5099f0a = node.x5099f0a842899426;
			x5099f0a.Offset(base.AutoScrollPosition);
			return x5099f0a;
		}
		return Rectangle.Empty;
	}

	public void x8ec3e93c4c4b770b()
	{
		BackColor = SystemColors.Window;
	}

	protected bool x8b3f8f5d533e5ee1()
	{
		return BackColor != SystemColors.Window;
	}

	public void xe07820aa2e2d44c1()
	{
		ForeColor = SystemColors.WindowText;
	}

	protected bool xfb7de7fd3c763a63()
	{
		return ForeColor != SystemColors.WindowText;
	}

	private void xbb56c29a78b232c7(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		_2a8b7cba94394169.ImageList = null;
		x7facab8f46b5857c();
	}

	private void x4adfb251dee41055(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x7facab8f46b5857c();
	}

	private int x39438fcd2804703e()
	{
		if (x7bc501a48fc6524b == null)
		{
			return 0;
		}
		return x7bc501a48fc6524b.ImageSize.Width + 2;
	}

	private int xcce8c934427d4656()
	{
		if (x7bc501a48fc6524b == null)
		{
			return 0;
		}
		return x7bc501a48fc6524b.ImageSize.Height + 2;
	}

	protected static VisualStyleRenderer xb819faf9bf7096b0(VisualStyleElement x4bbc2c453c470189)
	{
		if (VisualStyleRenderer.IsSupported && VisualStyleRenderer.IsElementDefined(x4bbc2c453c470189))
		{
			return new VisualStyleRenderer(x4bbc2c453c470189);
		}
		return null;
	}

	private static VisualStyleRenderer xa2d155a7efb8fe1c()
	{
		return xb819faf9bf7096b0(VisualStyleElement.CreateElement(VisualStyleElement.TreeView.Item.Normal.ClassName, 0, 0));
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected override void WndProc(ref Message x6088325dec1baa2a)
	{
		if (x6088325dec1baa2a.Msg == 133)
		{
			xa3b776a68d7b296e(ref x6088325dec1baa2a);
		}
		else if (x6088325dec1baa2a.Msg == 131)
		{
			x5369e87fa89be86f(ref x6088325dec1baa2a);
		}
		else if (x6088325dec1baa2a.Msg == 794)
		{
			x3f1e052bc40bfa92(ref x6088325dec1baa2a);
		}
		else
		{
			base.WndProc(ref x6088325dec1baa2a);
		}
	}

	private void x5369e87fa89be86f(ref Message x6088325dec1baa2a)
	{
		base.WndProc(ref x6088325dec1baa2a);
		_f3e2af18efbec93d = true;
		if (x6088325dec1baa2a.WParam.ToInt32() == 0)
		{
			x842e24ef1160275b.x8dd4b7a13a696a09 x26545669838eb36e = (x842e24ef1160275b.x8dd4b7a13a696a09)x6088325dec1baa2a.GetLParam(typeof(x842e24ef1160275b.x8dd4b7a13a696a09));
			x54a556d5fcc53498(ref x26545669838eb36e);
			Marshal.StructureToPtr(x26545669838eb36e, x6088325dec1baa2a.LParam, fDeleteOld: false);
		}
		else
		{
			x842e24ef1160275b.x4b429ae161669a9e x4b429ae161669a9e = (x842e24ef1160275b.x4b429ae161669a9e)x6088325dec1baa2a.GetLParam(typeof(x842e24ef1160275b.x4b429ae161669a9e));
			x54a556d5fcc53498(ref x4b429ae161669a9e.x4c5f240eee47c6c5);
			Marshal.StructureToPtr(x4b429ae161669a9e, x6088325dec1baa2a.LParam, fDeleteOld: false);
			x6088325dec1baa2a.Result = new IntPtr(768);
		}
	}

	private void x54a556d5fcc53498(ref x842e24ef1160275b.x8dd4b7a13a696a09 x26545669838eb36e)
	{
		VisualStyleRenderer visualStyleRenderer = xa2d155a7efb8fe1c();
		if (visualStyleRenderer == null)
		{
			return;
		}
		using Graphics dc = CreateGraphics();
		Rectangle backgroundContentRectangle = visualStyleRenderer.GetBackgroundContentRectangle(dc, x26545669838eb36e);
		backgroundContentRectangle.Inflate(-1, -1);
		x26545669838eb36e = new x842e24ef1160275b.x8dd4b7a13a696a09(backgroundContentRectangle);
	}

	private void xa3b776a68d7b296e(ref Message x6088325dec1baa2a)
	{
		base.WndProc(ref x6088325dec1baa2a);
		x842e24ef1160275b.GetWindowRect(base.Handle, out var x84b201b219db0d6f);
		x84b201b219db0d6f.xfc2074a859a5db8c -= x84b201b219db0d6f.xa447fc54e41dfe06;
		x84b201b219db0d6f.xaf9a0436a70689de -= x84b201b219db0d6f.xc941868c59399d3e;
		x84b201b219db0d6f.xa447fc54e41dfe06 = (x84b201b219db0d6f.xc941868c59399d3e = 0);
		Rectangle rectangle = x84b201b219db0d6f;
		IntPtr windowDC = x842e24ef1160275b.GetWindowDC(base.Handle);
		try
		{
			using Graphics graphics = Graphics.FromHdc(windowDC);
			if (x64b4c49ed703037e != BorderStyle.Fixed3D)
			{
				return;
			}
			VisualStyleRenderer visualStyleRenderer = xa2d155a7efb8fe1c();
			if (visualStyleRenderer != null)
			{
				Rectangle backgroundContentRectangle = visualStyleRenderer.GetBackgroundContentRectangle(graphics, rectangle);
				backgroundContentRectangle.Inflate(-1, -1);
				GraphicsContainer container = graphics.BeginContainer();
				Region region = new Region(rectangle);
				region.Exclude(backgroundContentRectangle);
				graphics.Clip = region;
				if (visualStyleRenderer.IsBackgroundPartiallyTransparent())
				{
					visualStyleRenderer.DrawParentBackground(graphics, rectangle, this);
				}
				visualStyleRenderer.DrawBackground(graphics, rectangle);
				graphics.EndContainer(container);
				if (base.HScroll && base.VScroll)
				{
					int horizontalScrollBarHeight = SystemInformation.HorizontalScrollBarHeight;
					int verticalScrollBarWidth = SystemInformation.VerticalScrollBarWidth;
					graphics.FillRectangle(rect: new Rectangle(backgroundContentRectangle.Right - verticalScrollBarWidth, backgroundContentRectangle.Bottom - horizontalScrollBarHeight, verticalScrollBarWidth, horizontalScrollBarHeight), brush: SystemBrushes.Control);
				}
			}
		}
		finally
		{
			x842e24ef1160275b.ReleaseDC(base.Handle, windowDC);
		}
	}

	private void x3f1e052bc40bfa92(ref Message x6088325dec1baa2a)
	{
		base.WndProc(ref x6088325dec1baa2a);
		UpdateStyles();
	}

	public void x5577363cc650aaeb()
	{
		if (_89559d4af34bdf2e == 0)
		{
			x289f1a0ee2f795a7.x62dd9224cc6b1063(this, x972d12acec9b230c: false);
			_89559d4af34bdf2e++;
		}
	}

	public void x3ae2e4d73c7847ae()
	{
		if (_89559d4af34bdf2e <= 0)
		{
			return;
		}
		_89559d4af34bdf2e--;
		if (_89559d4af34bdf2e == 0)
		{
			x289f1a0ee2f795a7.x62dd9224cc6b1063(this, x972d12acec9b230c: true);
			if (_9c5ffe3efcbc9a09)
			{
				_9c5ffe3efcbc9a09 = false;
				x7facab8f46b5857c();
			}
			else
			{
				Invalidate();
			}
		}
	}

	internal void xe88ab84767e8fb69(x95fcf261e3011b00 node)
	{
		Rectangle rc = x0d74e8d3eb8db1a0(node);
		Invalidate(rc);
	}

	protected override void OnPaint(PaintEventArgs xfbf34718e704c6bc)
	{
		x0b247eed46221634(xfbf34718e704c6bc.Graphics, x63b0f7fed3f5bd88);
		base.OnPaint(xfbf34718e704c6bc);
	}

	private void x0b247eed46221634(Graphics x41347a961b838962, x0bc7d5c84e62d912 nodes)
	{
		foreach (x95fcf261e3011b00 item in nodes)
		{
			Rectangle xda73fcb97c77d = x0d74e8d3eb8db1a0(item);
			if (!xda73fcb97c77d.IsEmpty && xda73fcb97c77d.IntersectsWith(base.ClientRectangle))
			{
				PaintNode(x41347a961b838962, item, xda73fcb97c77d);
			}
			x0b247eed46221634(x41347a961b838962, item.x63b0f7fed3f5bd88);
		}
	}

	protected virtual void PaintNode(Graphics x41347a961b838962, x95fcf261e3011b00 node, Rectangle xda73fcb97c77d998)
	{
		node.xe072b21e8fe21a7e(xda73fcb97c77d998, out var x87dd47ddb178ff, out var x443b4b9ad47ce, out var xc685053fae6eaa);
		if (xfb7eed5237ac7734)
		{
			x0310a6d1f51902dd(x41347a961b838962, node, x87dd47ddb178ff, x443b4b9ad47ce, xc685053fae6eaa);
		}
		if (x443b4b9ad47ce.Size != Size.Empty)
		{
			PaintImage(x41347a961b838962, node, x443b4b9ad47ce);
		}
		GraphicsContainer container = x41347a961b838962.BeginContainer();
		x41347a961b838962.Clip = new Region(xda73fcb97c77d998);
		PaintContent(x41347a961b838962, node, xc685053fae6eaa);
		x41347a961b838962.EndContainer(container);
	}

	private void x0310a6d1f51902dd(Graphics x41347a961b838962, x95fcf261e3011b00 node, Rectangle x87dd47ddb178ff41, Rectangle x443b4b9ad47ce447, Rectangle xc685053fae6eaa64)
	{
		using Pen pen = new Pen(x3c68d0a3c5adb970, 1f);
		pen.DashStyle = DashStyle.Dot;
		Point point = ((!(x443b4b9ad47ce447.Size == Size.Empty)) ? new Point((x443b4b9ad47ce447.Left + x443b4b9ad47ce447.Right) / 2, (x443b4b9ad47ce447.Top + x443b4b9ad47ce447.Bottom) / 2) : new Point(xc685053fae6eaa64.Left - 1, (xc685053fae6eaa64.Top + xc685053fae6eaa64.Bottom) / 2));
		int num = Math.Abs(base.AutoScrollPosition.X) + Math.Abs(base.AutoScrollPosition.Y);
		if (x95a235bff44ec867 || node.x332a8eedb847940d != null)
		{
			Point point2 = new Point(x87dd47ddb178ff41.Right - x941a43d4a5637fd0 / 2, point.Y);
			pen.DashOffset = (point2.X + point2.Y + num) & 1;
			x41347a961b838962.DrawLine(pen, point2, point);
			if (node.x99d6b0b05cd7185f != null || node.x332a8eedb847940d != null)
			{
				pen.DashOffset = (point2.X + x87dd47ddb178ff41.Top - 1 + num) & 1;
				x41347a961b838962.DrawLine(pen, new Point(point2.X, x87dd47ddb178ff41.Top - 1), point2);
			}
			if (node.x4f6686d624d5dfe1 != null)
			{
				pen.DashOffset = (point2.X + point2.Y + num) & 1;
				x41347a961b838962.DrawLine(pen, point2, new Point(point2.X, x87dd47ddb178ff41.Bottom + 1));
			}
			x95fcf261e3011b00 x332a8eedb847940d = node.x332a8eedb847940d;
			int num2 = point2.X;
			while (x332a8eedb847940d != null)
			{
				num2 -= x941a43d4a5637fd0;
				if ((x95a235bff44ec867 || x332a8eedb847940d.x332a8eedb847940d != null) && x332a8eedb847940d.x4f6686d624d5dfe1 != null)
				{
					pen.DashOffset = (num2 + x87dd47ddb178ff41.Top + num) & 1;
					x41347a961b838962.DrawLine(pen, num2, x87dd47ddb178ff41.Top, num2, x87dd47ddb178ff41.Bottom);
				}
				x332a8eedb847940d = x332a8eedb847940d.x332a8eedb847940d;
			}
			if (xeeb72f5f2d391f6f && node.xf303b4c014a7017b)
			{
				xe56177bf052c1380(x41347a961b838962, node, point2, x87dd47ddb178ff41);
			}
		}
		if (node.x5e48bd0c96038b5e && x443b4b9ad47ce447.Size != Size.Empty)
		{
			pen.DashOffset = (point.X + point.Y + num) & 1;
			x41347a961b838962.DrawLine(pen, point, new Point(point.X, x87dd47ddb178ff41.Bottom));
		}
	}

	private void xe56177bf052c1380(Graphics x41347a961b838962, x95fcf261e3011b00 node, Point x16f75a4353bb408e, Rectangle xda73fcb97c77d998)
	{
		VisualStyleRenderer visualStyleRenderer = xb819faf9bf7096b0(node.x5e48bd0c96038b5e ? VisualStyleElement.TreeView.Glyph.Opened : VisualStyleElement.TreeView.Glyph.Closed);
		if (visualStyleRenderer == null)
		{
			Rectangle rect = new Rectangle(x16f75a4353bb408e - new Size(4, 4), new Size(8, 8));
			using (Brush brush = new SolidBrush(BackColor))
			{
				x41347a961b838962.FillRectangle(brush, rect);
			}
			using (Pen pen = new Pen(x3c68d0a3c5adb970))
			{
				x41347a961b838962.DrawRectangle(pen, rect);
			}
			using Pen pen2 = new Pen(ForeColor);
			Size size = new Size(rect.Width / 2 - 2, 0);
			Size size2 = new Size(0, rect.Height / 2 - 2);
			x41347a961b838962.DrawLine(pen2, x16f75a4353bb408e - size, x16f75a4353bb408e + size);
			if (!node.x5e48bd0c96038b5e)
			{
				x41347a961b838962.DrawLine(pen2, x16f75a4353bb408e - size2, x16f75a4353bb408e + size2);
			}
			return;
		}
		Size partSize = visualStyleRenderer.GetPartSize(x41347a961b838962, xda73fcb97c77d998, ThemeSizeType.Draw);
		Rectangle bounds = new Rectangle(x16f75a4353bb408e.X - partSize.Width / 2, x16f75a4353bb408e.Y - partSize.Height / 2, partSize.Width, partSize.Height);
		visualStyleRenderer.DrawBackground(x41347a961b838962, bounds);
	}

	protected virtual void PaintImage(Graphics x41347a961b838962, x95fcf261e3011b00 node, Rectangle xda73fcb97c77d998)
	{
		if (x7bc501a48fc6524b == null)
		{
			return;
		}
		int actualIndex = node.x2a8b7cba94394169.ActualIndex;
		switch (actualIndex)
		{
		case -2:
			return;
		case -1:
			actualIndex = _2a8b7cba94394169.ActualIndex;
			break;
		}
		if (actualIndex < 0 || actualIndex >= x7bc501a48fc6524b.Images.Count)
		{
			return;
		}
		using Image image = x7bc501a48fc6524b.Images[actualIndex];
		if (base.Enabled)
		{
			x41347a961b838962.DrawImageUnscaled(image, xda73fcb97c77d998);
		}
		else
		{
			ControlPaint.DrawImageDisabled(x41347a961b838962, image, xda73fcb97c77d998.X, xda73fcb97c77d998.Y, BackColor);
		}
	}

	protected virtual void PaintContent(Graphics x41347a961b838962, x95fcf261e3011b00 node, Rectangle xda73fcb97c77d998)
	{
		Color x53218bf919efffd = node.x7dd793a62d047456;
		Color x154083d58301ef = node.xf83c69bb98e96a69;
		if (node.xaa7558c320af04eb)
		{
			VisualStyleRenderer visualStyleRenderer = xb819faf9bf7096b0(VisualStyleElement.TreeView.Item.Selected);
			if (visualStyleRenderer == null)
			{
				x53218bf919efffd = SystemColors.HighlightText;
				x154083d58301ef = SystemColors.Highlight;
			}
			else
			{
				x53218bf919efffd = visualStyleRenderer.GetColor(ColorProperty.TextColor);
				x154083d58301ef = visualStyleRenderer.GetColor(ColorProperty.FillColor);
			}
		}
		else
		{
			VisualStyleRenderer visualStyleRenderer2;
			if (base.Enabled)
			{
				visualStyleRenderer2 = xb819faf9bf7096b0(VisualStyleElement.TreeView.Item.Normal);
				if (x53218bf919efffd.IsEmpty)
				{
					x53218bf919efffd = visualStyleRenderer2?.GetColor(ColorProperty.TextColor) ?? ForeColor;
				}
			}
			else
			{
				visualStyleRenderer2 = xb819faf9bf7096b0(VisualStyleElement.TreeView.Item.Disabled);
				x53218bf919efffd = visualStyleRenderer2?.GetColor(ColorProperty.TextColor) ?? SystemColors.GrayText;
			}
			if (x154083d58301ef.IsEmpty)
			{
				if (!node.xe87800b64c00467c)
				{
					x154083d58301ef = visualStyleRenderer2?.GetColor(ColorProperty.FillColor) ?? BackColor;
				}
				else
				{
					visualStyleRenderer2 = xb819faf9bf7096b0(VisualStyleElement.TreeView.Item.Selected);
					x154083d58301ef = ((visualStyleRenderer2 != null) ? Color.FromArgb(64, visualStyleRenderer2.GetColor(ColorProperty.FillColor)) : Color.FromArgb(64, SystemColors.Highlight));
				}
			}
		}
		PaintContentText(x41347a961b838962, xda73fcb97c77d998, node, x53218bf919efffd, x154083d58301ef);
	}

	protected virtual void PaintContentText(Graphics x41347a961b838962, Rectangle xda73fcb97c77d998, x95fcf261e3011b00 node, Color x53218bf919efffd4, Color x154083d58301ef75)
	{
		using Brush brush2 = new SolidBrush(x53218bf919efffd4);
		using Brush brush = new SolidBrush(x154083d58301ef75);
		x41347a961b838962.FillRectangle(brush, xda73fcb97c77d998);
		using StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.LineAlignment = StringAlignment.Center;
		x41347a961b838962.DrawString(node.xf9ad6fb78355fe13, Font, brush2, xda73fcb97c77d998, stringFormat);
	}

	private void x9bf3b5eed54b0145(int x6ca4005f748d141c)
	{
		Point autoScrollPosition = base.AutoScrollPosition;
		autoScrollPosition.Y -= x6ca4005f748d141c;
		autoScrollPosition.Y = Math.Min(0, Math.Max(autoScrollPosition.Y, -x5bbb82e31309cc73.Height));
		if (autoScrollPosition.Y != base.AutoScrollPosition.Y)
		{
			base.AutoScrollPosition = new Point(-autoScrollPosition.X, -autoScrollPosition.Y);
		}
	}

	protected override bool IsInputKey(Keys x7164e699dd95323c)
	{
		if ((x7164e699dd95323c & Keys.Alt) == 0)
		{
			switch (x7164e699dd95323c & Keys.KeyCode)
			{
			case Keys.Prior:
			case Keys.Next:
			case Keys.End:
			case Keys.Home:
			case Keys.Up:
			case Keys.Down:
				return true;
			}
		}
		return base.IsInputKey(x7164e699dd95323c);
	}

	protected override void OnKeyDown(KeyEventArgs xfbf34718e704c6bc)
	{
		if (!xfbf34718e704c6bc.Alt)
		{
			switch (xfbf34718e704c6bc.KeyCode)
			{
			case Keys.Up:
				x9bf3b5eed54b0145(-32);
				xfbf34718e704c6bc.Handled = true;
				break;
			case Keys.Down:
				x9bf3b5eed54b0145(32);
				xfbf34718e704c6bc.Handled = true;
				break;
			case Keys.Prior:
				x9bf3b5eed54b0145(-base.ClientSize.Height);
				xfbf34718e704c6bc.Handled = true;
				break;
			case Keys.Next:
				x9bf3b5eed54b0145(base.ClientSize.Height);
				xfbf34718e704c6bc.Handled = true;
				break;
			case Keys.Home:
				base.AutoScrollPosition = Point.Empty;
				xfbf34718e704c6bc.Handled = true;
				break;
			case Keys.End:
				base.AutoScrollPosition = new Point(0, x5bbb82e31309cc73.Height);
				xfbf34718e704c6bc.Handled = true;
				break;
			}
		}
		base.OnKeyDown(xfbf34718e704c6bc);
	}

	protected override void OnMouseWheel(MouseEventArgs xfbf34718e704c6bc)
	{
		_6641d600af281f21 += xfbf34718e704c6bc.Delta;
		int mouseWheelScrollLines = SystemInformation.MouseWheelScrollLines;
		int mouseWheelScrollDelta = SystemInformation.MouseWheelScrollDelta;
		int num = _6641d600af281f21 * mouseWheelScrollLines / mouseWheelScrollDelta;
		int num2 = num * mouseWheelScrollDelta / mouseWheelScrollLines;
		_6641d600af281f21 -= num2;
		x9bf3b5eed54b0145(-num);
		base.OnMouseWheel(xfbf34718e704c6bc);
	}

	protected override void OnMouseClick(MouseEventArgs xfbf34718e704c6bc)
	{
		x95fcf261e3011b00 xb814177533985e8d;
		x96bed71d06f031fe x96bed71d06f031fe2 = x68c86e2f125c51ea(xfbf34718e704c6bc.Location, out xb814177533985e8d);
		if (xb814177533985e8d != null)
		{
			if ((x96bed71d06f031fe2 & x96bed71d06f031fe.xe6d4b1b411ed94b5) != 0)
			{
				OnNodeMouseClick(new xfc646a3e9e0998cd(xb814177533985e8d, xfbf34718e704c6bc));
			}
			else if ((x96bed71d06f031fe2 & x96bed71d06f031fe.xd774dfd2741655e5) != 0)
			{
				xb814177533985e8d.x10a64d88e6f4fac9();
			}
		}
		base.OnMouseClick(xfbf34718e704c6bc);
	}

	protected override void OnMouseDoubleClick(MouseEventArgs xfbf34718e704c6bc)
	{
		x95fcf261e3011b00 xb814177533985e8d;
		x96bed71d06f031fe x96bed71d06f031fe2 = x68c86e2f125c51ea(xfbf34718e704c6bc.Location, out xb814177533985e8d);
		if (xb814177533985e8d != null && (x96bed71d06f031fe2 & x96bed71d06f031fe.xe6d4b1b411ed94b5) != 0)
		{
			OnNodeMouseDoubleClick(new xfc646a3e9e0998cd(xb814177533985e8d, xfbf34718e704c6bc));
		}
		base.OnMouseDoubleClick(xfbf34718e704c6bc);
	}

	protected virtual void OnNodeSelecting(x495ca8a85eccbead xfbf34718e704c6bc)
	{
		if (this.x12e020f3be9cb6f4 != null)
		{
			this.x12e020f3be9cb6f4(this, xfbf34718e704c6bc);
		}
	}

	internal void xd83ad294b860926f(x95fcf261e3011b00 node)
	{
		_4dcf8d74821042cd = null;
		OnNodeSelectionChanged(new x8f674b723ab8cda2(node));
	}

	protected virtual void OnNodeSelectionChanged(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (this.x1087ddccf8f41e6f != null)
		{
			this.x1087ddccf8f41e6f(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnNodeMouseClick(xfc646a3e9e0998cd xfbf34718e704c6bc)
	{
		x495ca8a85eccbead x495ca8a85eccbead2 = new x495ca8a85eccbead(xfbf34718e704c6bc.x40212106aad8a8b0, x57602a0a0d178a2e: false);
		OnNodeSelecting(x495ca8a85eccbead2);
		if (!x495ca8a85eccbead2.Cancel)
		{
			if ((Control.ModifierKeys & Keys.Control) != 0)
			{
				xfbf34718e704c6bc.x40212106aad8a8b0.xaa7558c320af04eb = true;
			}
			else
			{
				x89be10370322706f(xfbf34718e704c6bc.x40212106aad8a8b0);
			}
		}
		if (this.xa1547aa59dafcb58 != null)
		{
			this.xa1547aa59dafcb58(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnNodeMouseDoubleClick(xfc646a3e9e0998cd xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.Button == MouseButtons.Left)
		{
			xfbf34718e704c6bc.x40212106aad8a8b0.x10a64d88e6f4fac9();
		}
		if (this.x4d9c819fe95edefe != null)
		{
			this.x4d9c819fe95edefe(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnExpanding(x495ca8a85eccbead xfbf34718e704c6bc)
	{
		if (this.x6b30bb6c5f41e32f != null)
		{
			this.x6b30bb6c5f41e32f(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnCollapsing(x495ca8a85eccbead xfbf34718e704c6bc)
	{
		if (this.x25302ae69cf01877 != null)
		{
			this.x25302ae69cf01877(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnExpanded(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (this.x7757e023237c7679 != null)
		{
			this.x7757e023237c7679(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnCollapsed(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (this.x8f530dd9a6341bae != null)
		{
			this.x8f530dd9a6341bae(this, xfbf34718e704c6bc);
		}
	}

	public xea5e4be807a4597b()
	{
		SetStyle(ControlStyles.ContainerControl | ControlStyles.UseTextForAccessibility, value: false);
		SetStyle(ControlStyles.StandardClick | ControlStyles.Selectable | ControlStyles.UserMouse | ControlStyles.StandardDoubleClick, value: true);
		DoubleBuffered = true;
		x3587924af3bbb8b9 = true;
		x8ec3e93c4c4b770b();
		xe07820aa2e2d44c1();
		_29e7ace4c90f74cd = new x95fcf261e3011b00(this);
		_29e7ace4c90f74cd.x8810335244b90b9d();
		_29e7ace4c90f74cd.x63b0f7fed3f5bd88.x6b30bb6c5f41e32f += xf1c3a78e6e151dda;
		_29e7ace4c90f74cd.x63b0f7fed3f5bd88.x25302ae69cf01877 += x7b61adcb2f242977;
		_29e7ace4c90f74cd.x63b0f7fed3f5bd88.x7757e023237c7679 += xafbee82c461498be;
		_29e7ace4c90f74cd.x63b0f7fed3f5bd88.x8f530dd9a6341bae += xd689deeff8cd53d4;
		AutoScroll = true;
	}

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		if (xb41acd866d5cbca8 && _2a8b7cba94394169.ImageList != null)
		{
			_2a8b7cba94394169.ImageList.RecreateHandle -= x4adfb251dee41055;
			_2a8b7cba94394169.ImageList.Disposed -= xbb56c29a78b232c7;
			_2a8b7cba94394169.ImageList = null;
		}
		base.Dispose(xb41acd866d5cbca8);
	}

	private void xf1c3a78e6e151dda(object xe0292b9ed559da7d, x495ca8a85eccbead xfbf34718e704c6bc)
	{
		OnExpanding(xfbf34718e704c6bc);
	}

	private void x7b61adcb2f242977(object xe0292b9ed559da7d, x495ca8a85eccbead xfbf34718e704c6bc)
	{
		OnCollapsing(xfbf34718e704c6bc);
	}

	private void xafbee82c461498be(object xe0292b9ed559da7d, x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		OnExpanded(xfbf34718e704c6bc);
	}

	private void xd689deeff8cd53d4(object xe0292b9ed559da7d, x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		OnCollapsed(xfbf34718e704c6bc);
	}

	public void x8e238fd29a0c8441()
	{
		x1afa69e4cfcb7734(x63b0f7fed3f5bd88, null);
	}

	public void x89be10370322706f(x95fcf261e3011b00 node)
	{
		x8e238fd29a0c8441();
		if (node != null)
		{
			node.xaa7558c320af04eb = true;
		}
	}

	internal void x31ef454f832339b8(x95fcf261e3011b00 xa4ccebff87d304c1)
	{
		x1afa69e4cfcb7734(x63b0f7fed3f5bd88, xa4ccebff87d304c1);
	}

	private void x1afa69e4cfcb7734(x0bc7d5c84e62d912 nodes, x95fcf261e3011b00 xa4ccebff87d304c1)
	{
		foreach (x95fcf261e3011b00 item in nodes)
		{
			if (xa4ccebff87d304c1 == null || item.x332a8eedb847940d != xa4ccebff87d304c1.x332a8eedb847940d)
			{
				item.xaa7558c320af04eb = false;
			}
			x1afa69e4cfcb7734(item.x63b0f7fed3f5bd88, xa4ccebff87d304c1);
		}
	}
}
