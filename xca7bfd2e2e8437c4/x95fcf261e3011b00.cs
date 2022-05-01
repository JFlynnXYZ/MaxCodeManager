using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace xca7bfd2e2e8437c4;

[DefaultProperty("Text")]
[TypeConverter(typeof(xdd6bd945f9b82610))]
public class x95fcf261e3011b00
{
	internal class x66905b21d831a573 : x03a477b12104a885
	{
		private x95fcf261e3011b00 _9ce35bc295da5a81;

		public override ImageList ImageList
		{
			get
			{
				if (_9ce35bc295da5a81.x62e86f2fb9e3a57b == null)
				{
					return null;
				}
				return _9ce35bc295da5a81.x62e86f2fb9e3a57b.x7bc501a48fc6524b;
			}
			set
			{
			}
		}

		public x66905b21d831a573(x95fcf261e3011b00 x071bde1041617fce)
		{
			_9ce35bc295da5a81 = x071bde1041617fce;
		}
	}

	private Rectangle _5099f0a842899426;

	private string _f9ad6fb78355fe13 = string.Empty;

	private object _d229d86af0f16fb0;

	private x66905b21d831a573 _2a8b7cba94394169;

	private Color _7dd793a62d047456 = Color.Empty;

	private Color _f83c69bb98e96a69 = Color.Empty;

	private int _b0f146032f47c24e;

	private x0bc7d5c84e62d912 _63b0f7fed3f5bd88;

	private bool _5e48bd0c96038b5e;

	private bool _aa7558c320af04eb;

	private x95fcf261e3011b00 _332a8eedb847940d;

	private xea5e4be807a4597b _62e86f2fb9e3a57b;

	private string _759aa16c2016a289 = string.Empty;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Rectangle x5099f0a842899426
	{
		get
		{
			return _5099f0a842899426;
		}
		internal set
		{
			_5099f0a842899426 = value;
		}
	}

	public Size x884641cec39ad3eb
	{
		get
		{
			if (x5099f0a842899426.IsEmpty)
			{
				return Size.Empty;
			}
			xe072b21e8fe21a7e(x5099f0a842899426, out var _, out var _, out var xc685053fae6eaa);
			return xc685053fae6eaa.Size;
		}
	}

	[Description("Standard text for this node.")]
	[Category("Appearance")]
	[Localizable(true)]
	public string xf9ad6fb78355fe13
	{
		get
		{
			return _f9ad6fb78355fe13;
		}
		set
		{
			_f9ad6fb78355fe13 = value;
			xcbc511030aa1eefb();
		}
	}

	[Category("Behavior")]
	[Description("Custom value")]
	public object xd229d86af0f16fb0
	{
		get
		{
			return _d229d86af0f16fb0;
		}
		set
		{
			_d229d86af0f16fb0 = value;
		}
	}

	[RefreshProperties(RefreshProperties.Repaint)]
	[Description("Image index for this specific node.")]
	[Category("Appearance")]
	[TypeConverter(typeof(TreeViewImageIndexConverter))]
	[Localizable(true)]
	[RelatedImageList("TreeView.ImageList")]
	[DefaultValue(-1)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public int xaa7785f730d8dd15
	{
		get
		{
			return _2a8b7cba94394169.Index;
		}
		set
		{
			_2a8b7cba94394169.Index = value;
			xcbc511030aa1eefb();
		}
	}

	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DefaultValue("")]
	[RelatedImageList("TreeView.ImageList")]
	[TypeConverter(typeof(TreeViewImageKeyConverter))]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Description("Image key for this specific node.")]
	[Category("Appearance")]
	[Localizable(true)]
	public string xc439cbba6c00a3a0
	{
		get
		{
			return _2a8b7cba94394169.Key;
		}
		set
		{
			_2a8b7cba94394169.Key = value;
			xcbc511030aa1eefb();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	internal x66905b21d831a573 x2a8b7cba94394169 => _2a8b7cba94394169;

	[Description("Foreground colour for this specific node (overrides the default colour)")]
	[DefaultValue(typeof(Color), "Empty")]
	[Category("Appearance")]
	public Color x7dd793a62d047456
	{
		get
		{
			return _7dd793a62d047456;
		}
		set
		{
			_7dd793a62d047456 = value;
			xcbc511030aa1eefb();
		}
	}

	[Description("Background colour for this specific node (overrides the default colour)")]
	[Category("Appearance")]
	[DefaultValue(typeof(Color), "Empty")]
	public Color xf83c69bb98e96a69
	{
		get
		{
			return _f83c69bb98e96a69;
		}
		set
		{
			_f83c69bb98e96a69 = value;
			xcbc511030aa1eefb();
		}
	}

	[Category("Appearance")]
	[Description("The custom height of this node (or 0 to use the default height from the view")]
	[DefaultValue(0)]
	public int xb0f146032f47c24e
	{
		get
		{
			return _b0f146032f47c24e;
		}
		set
		{
			_b0f146032f47c24e = value;
			xb5d6cd3b1217669c();
		}
	}

	[Description("The actual height of this node.  Change via the Height property.")]
	[Category("Appearance")]
	public int x449ad19c79665932 => Math.Max(xb0f146032f47c24e, (x62e86f2fb9e3a57b != null) ? x62e86f2fb9e3a57b.x5b1e6d73a61cb6dc : 0);

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Behavior")]
	[Description("Sub-nodes of this node.")]
	public x0bc7d5c84e62d912 x63b0f7fed3f5bd88 => _63b0f7fed3f5bd88;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool x5e48bd0c96038b5e
	{
		get
		{
			if (_5e48bd0c96038b5e)
			{
				return xf303b4c014a7017b;
			}
			return false;
		}
		private set
		{
			_5e48bd0c96038b5e = value;
			xb5d6cd3b1217669c();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool xaa7558c320af04eb
	{
		get
		{
			return _aa7558c320af04eb;
		}
		set
		{
			if (value && x62e86f2fb9e3a57b != null)
			{
				_62e86f2fb9e3a57b.x31ef454f832339b8(this);
			}
			if (_aa7558c320af04eb != value)
			{
				_aa7558c320af04eb = value;
				if (x62e86f2fb9e3a57b != null)
				{
					x62e86f2fb9e3a57b.xd83ad294b860926f(this);
				}
			}
			xcbc511030aa1eefb();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool xe87800b64c00467c
	{
		get
		{
			if (x332a8eedb847940d == null)
			{
				return false;
			}
			if (!x332a8eedb847940d.xaa7558c320af04eb)
			{
				return x332a8eedb847940d.xe87800b64c00467c;
			}
			return true;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public IList<x95fcf261e3011b00> xc82eff4818ce3f25
	{
		get
		{
			List<x95fcf261e3011b00> list = new List<x95fcf261e3011b00>();
			if (xaa7558c320af04eb)
			{
				list.Add(this);
			}
			foreach (x95fcf261e3011b00 item in x63b0f7fed3f5bd88)
			{
				list.AddRange(item.xc82eff4818ce3f25);
			}
			return list;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool xa853df7acdb217c8
	{
		get
		{
			if (_332a8eedb847940d != null)
			{
				if (_332a8eedb847940d.xa853df7acdb217c8)
				{
					return _332a8eedb847940d.x5e48bd0c96038b5e;
				}
				return false;
			}
			return true;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int x504f3d4040b356d7
	{
		get
		{
			if (_332a8eedb847940d != null)
			{
				return _332a8eedb847940d.x504f3d4040b356d7 + 1;
			}
			return 0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool xf303b4c014a7017b => x63b0f7fed3f5bd88.Count > 0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public x95fcf261e3011b00 x99d6b0b05cd7185f
	{
		get
		{
			if (_332a8eedb847940d == null)
			{
				return null;
			}
			int num = _332a8eedb847940d.x63b0f7fed3f5bd88.IndexOf(this) - 1;
			if (num < 0)
			{
				return null;
			}
			return _332a8eedb847940d.x63b0f7fed3f5bd88[num];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public x95fcf261e3011b00 x4f6686d624d5dfe1
	{
		get
		{
			if (_332a8eedb847940d == null)
			{
				return null;
			}
			int num = _332a8eedb847940d.x63b0f7fed3f5bd88.IndexOf(this) + 1;
			if (num < 0 || num >= _332a8eedb847940d.x63b0f7fed3f5bd88.Count)
			{
				return null;
			}
			return _332a8eedb847940d.x63b0f7fed3f5bd88[num];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public x95fcf261e3011b00 x332a8eedb847940d
	{
		get
		{
			xea5e4be807a4597b xea5e4be807a4597b2 = x62e86f2fb9e3a57b;
			if (xea5e4be807a4597b2 != null && _332a8eedb847940d == xea5e4be807a4597b2.x29e7ace4c90f74cd)
			{
				return null;
			}
			return _332a8eedb847940d;
		}
		internal set
		{
			_332a8eedb847940d = value;
			_62e86f2fb9e3a57b = null;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public xea5e4be807a4597b x62e86f2fb9e3a57b
	{
		get
		{
			if (_62e86f2fb9e3a57b == null)
			{
				x95fcf261e3011b00 x95fcf261e3011b = this;
				while (x95fcf261e3011b._332a8eedb847940d != null)
				{
					x95fcf261e3011b = x95fcf261e3011b._332a8eedb847940d;
				}
				_62e86f2fb9e3a57b = x95fcf261e3011b._62e86f2fb9e3a57b;
			}
			return _62e86f2fb9e3a57b;
		}
	}

	[Category("Design")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Name of this node (only really used in the designer.")]
	public string x759aa16c2016a289
	{
		get
		{
			return _759aa16c2016a289;
		}
		set
		{
			_759aa16c2016a289 = value;
		}
	}

	public event EventHandler<x495ca8a85eccbead> x6b30bb6c5f41e32f;

	public event EventHandler<x495ca8a85eccbead> x25302ae69cf01877;

	public event EventHandler<x8f674b723ab8cda2> x7757e023237c7679;

	public event EventHandler<x8f674b723ab8cda2> x8f530dd9a6341bae;

	public void xe072b21e8fe21a7e(Rectangle xda73fcb97c77d998, out Rectangle x87dd47ddb178ff41, out Rectangle x443b4b9ad47ce447, out Rectangle xc685053fae6eaa64)
	{
		xea5e4be807a4597b xea5e4be807a4597b2 = x62e86f2fb9e3a57b;
		if (xea5e4be807a4597b2 == null || xda73fcb97c77d998.IsEmpty || !xa853df7acdb217c8)
		{
			x87dd47ddb178ff41 = (x443b4b9ad47ce447 = (xc685053fae6eaa64 = Rectangle.Empty));
			return;
		}
		int width = x504f3d4040b356d7 * xea5e4be807a4597b2.x941a43d4a5637fd0 + ((!xea5e4be807a4597b2.xfb7eed5237ac7734 || !xea5e4be807a4597b2.x95a235bff44ec867) ? (-16) : 0);
		x87dd47ddb178ff41 = new Rectangle(xda73fcb97c77d998.Left, xda73fcb97c77d998.Top, width, xda73fcb97c77d998.Height);
		Size size = ((xea5e4be807a4597b2.x7bc501a48fc6524b == null || xaa7785f730d8dd15 == -2) ? Size.Empty : new Size(xea5e4be807a4597b2.x7bc501a48fc6524b.ImageSize.Width - 1, xea5e4be807a4597b2.x7bc501a48fc6524b.ImageSize.Height - 1));
		int num = xda73fcb97c77d998.Top;
		switch (xea5e4be807a4597b2.xe7e03246bec9d3a9)
		{
		default:
			num += xda73fcb97c77d998.Height / 2 - size.Height / 2;
			break;
		case VerticalAlignment.Bottom:
			num += xda73fcb97c77d998.Height - size.Height;
			break;
		case VerticalAlignment.Top:
			break;
		}
		x443b4b9ad47ce447 = new Rectangle(x87dd47ddb178ff41.Right + 2, num, size.Width, size.Height);
		xc685053fae6eaa64 = Rectangle.FromLTRB(x443b4b9ad47ce447.Right + 2, xda73fcb97c77d998.Top, xda73fcb97c77d998.Right, xda73fcb97c77d998.Bottom);
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

	internal x95fcf261e3011b00(xea5e4be807a4597b xc42c7c2f5b14bb4d)
		: this()
	{
		_62e86f2fb9e3a57b = xc42c7c2f5b14bb4d;
	}

	public x95fcf261e3011b00()
	{
		_2a8b7cba94394169 = new x66905b21d831a573(this);
		_63b0f7fed3f5bd88 = new x0bc7d5c84e62d912(this);
		x63b0f7fed3f5bd88.x6b30bb6c5f41e32f += xf1c3a78e6e151dda;
		x63b0f7fed3f5bd88.x25302ae69cf01877 += x7b61adcb2f242977;
		x63b0f7fed3f5bd88.x7757e023237c7679 += xafbee82c461498be;
		x63b0f7fed3f5bd88.x8f530dd9a6341bae += xd689deeff8cd53d4;
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

	public x95fcf261e3011b00(string xb41faee6912a2313)
		: this()
	{
		xf9ad6fb78355fe13 = xb41faee6912a2313;
	}

	public x95fcf261e3011b00(string xc15bd84e01929885, string xb41faee6912a2313)
		: this(xb41faee6912a2313)
	{
		x759aa16c2016a289 = xc15bd84e01929885;
	}

	private void xcbc511030aa1eefb()
	{
		if (x62e86f2fb9e3a57b != null)
		{
			x62e86f2fb9e3a57b.xe88ab84767e8fb69(this);
		}
	}

	private void xb5d6cd3b1217669c()
	{
		if (x62e86f2fb9e3a57b != null)
		{
			x62e86f2fb9e3a57b.x7facab8f46b5857c();
		}
	}

	public void x8810335244b90b9d()
	{
		xea5e4be807a4597b xea5e4be807a4597b2 = x62e86f2fb9e3a57b;
		bool flag = xea5e4be807a4597b2 != null && this == xea5e4be807a4597b2.x29e7ace4c90f74cd;
		if (!xf303b4c014a7017b && !flag)
		{
			return;
		}
		if (!flag)
		{
			x495ca8a85eccbead x495ca8a85eccbead2 = new x495ca8a85eccbead(this, x57602a0a0d178a2e: false);
			OnExpanding(x495ca8a85eccbead2);
			if (x495ca8a85eccbead2.Cancel)
			{
				return;
			}
		}
		x5e48bd0c96038b5e = true;
		if (!flag)
		{
			OnExpanded(new x8f674b723ab8cda2(this));
		}
	}

	public void x968eca275aff04e3()
	{
		xea5e4be807a4597b xea5e4be807a4597b2 = x62e86f2fb9e3a57b;
		bool flag = xea5e4be807a4597b2 != null && this == xea5e4be807a4597b2.x29e7ace4c90f74cd;
		if (xf303b4c014a7017b && !flag)
		{
			x495ca8a85eccbead x495ca8a85eccbead2 = new x495ca8a85eccbead(this, x57602a0a0d178a2e: false);
			OnCollapsing(x495ca8a85eccbead2);
			if (!x495ca8a85eccbead2.Cancel)
			{
				x5e48bd0c96038b5e = false;
				OnCollapsed(new x8f674b723ab8cda2(this));
			}
		}
	}

	public void x10a64d88e6f4fac9()
	{
		if (x5e48bd0c96038b5e)
		{
			x968eca275aff04e3();
		}
		else
		{
			x8810335244b90b9d();
		}
	}

	public void x65a62d6495d83a0f()
	{
		xea5e4be807a4597b xea5e4be807a4597b2 = x62e86f2fb9e3a57b;
		xea5e4be807a4597b2?.x5577363cc650aaeb();
		try
		{
			x8810335244b90b9d();
			foreach (x95fcf261e3011b00 item in x63b0f7fed3f5bd88)
			{
				item.x65a62d6495d83a0f();
			}
		}
		finally
		{
			xea5e4be807a4597b2?.x3ae2e4d73c7847ae();
		}
	}

	public void xa3d67626f8dfea9e()
	{
		xea5e4be807a4597b xea5e4be807a4597b2 = x62e86f2fb9e3a57b;
		xea5e4be807a4597b2?.x5577363cc650aaeb();
		try
		{
			x968eca275aff04e3();
			foreach (x95fcf261e3011b00 item in x63b0f7fed3f5bd88)
			{
				item.xa3d67626f8dfea9e();
			}
		}
		finally
		{
			xea5e4be807a4597b2?.x3ae2e4d73c7847ae();
		}
	}
}
