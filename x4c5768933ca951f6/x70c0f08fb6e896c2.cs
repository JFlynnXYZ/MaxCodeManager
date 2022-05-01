using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Mirality.Max.CodeManager.Properties;
using x2ac61696da69bb5f;
using x3a260771fe762331;
using x7fd6e610350f13fb;
using xca7bfd2e2e8437c4;

namespace x4c5768933ca951f6;

public class x70c0f08fb6e896c2 : xea5e4be807a4597b
{
	private class x8f6a4861a1fa98b2
	{
		public xfd5dc9a89edfa955 xc8f46b505998937b;

		public xbabc9feec6f641db xb0b4ff1622a01d12;

		public string xe9297f3324ef6f28;

		public RectangleF x633856f77b322cec;

		public string x999a9e029fc88104;

		public RectangleF xffaf890d231e8b63;

		public string x4191326b8c285bfa;

		public RectangleF x81baaabf2ec59aa2;

		public x8f6a4861a1fa98b2(xfd5dc9a89edfa955 x9035cf16181332fc)
		{
			xc8f46b505998937b = x9035cf16181332fc;
			xb0b4ff1622a01d12 = x9035cf16181332fc.xb0b4ff1622a01d12;
		}
	}

	private IContainer xb7dfc13308b54974;

	private Font _83a3078ae721efed;

	private Font _896f29d711ea5f3c;

	private Font _61540a8cf0d38f6c;

	private Font _884ddcb4b34ebfd4;

	private Font _487d376dd4dc04ec;

	private Font _288a00e303b5ad49;

	private x717219df0ea9ffd3 _a0380078f0b6cbb7;

	private x95fcf261e3011b00 x7098cef51c198a8d;

	private Dictionary<uint, x95fcf261e3011b00> x13aa21d407581685;

	private IList<xfd5dc9a89edfa955> _7a83d5516f8079b5;

	[CompilerGenerated]
	private static Predicate<x95fcf261e3011b00> x2ead37855225a377;

	[CompilerGenerated]
	private static Predicate<xbabc9feec6f641db> xf7a1e5b55d7eece4;

	[Browsable(false)]
	[ReadOnly(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new x0bc7d5c84e62d912 x63b0f7fed3f5bd88 => base.x63b0f7fed3f5bd88;

	[ReadOnly(true)]
	public new bool x95a235bff44ec867 => base.x95a235bff44ec867;

	[ReadOnly(true)]
	[Browsable(false)]
	public new ImageList x7bc501a48fc6524b => base.x7bc501a48fc6524b;

	[ReadOnly(true)]
	[Browsable(false)]
	public new int xaa7785f730d8dd15 => base.xaa7785f730d8dd15;

	[Browsable(false)]
	[ReadOnly(true)]
	public new string xc439cbba6c00a3a0 => base.xc439cbba6c00a3a0;

	[ReadOnly(true)]
	public new VerticalAlignment xe7e03246bec9d3a9 => base.xe7e03246bec9d3a9;

	[RefreshProperties(RefreshProperties.All)]
	public override Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
			xe6e393cb7439a825();
		}
	}

	[Category("Appearance")]
	public Font x896f29d711ea5f3c
	{
		get
		{
			return _896f29d711ea5f3c;
		}
		set
		{
			_896f29d711ea5f3c = value;
		}
	}

	[Category("Appearance")]
	public Font x884ddcb4b34ebfd4
	{
		get
		{
			return _884ddcb4b34ebfd4;
		}
		set
		{
			_884ddcb4b34ebfd4 = value;
		}
	}

	[Category("Appearance")]
	public Font x288a00e303b5ad49
	{
		get
		{
			return _288a00e303b5ad49;
		}
		set
		{
			_288a00e303b5ad49 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public x717219df0ea9ffd3 xa0380078f0b6cbb7
	{
		get
		{
			return _a0380078f0b6cbb7;
		}
		set
		{
			_a0380078f0b6cbb7 = value;
			x3cd69f5448118938();
		}
	}

	public IList<xfd5dc9a89edfa955> x30a02e7cd22d73f3
	{
		get
		{
			if (_7a83d5516f8079b5 == null)
			{
				List<xfd5dc9a89edfa955> list = new List<xfd5dc9a89edfa955>();
				foreach (x95fcf261e3011b00 item in base.xc82eff4818ce3f25)
				{
					list.Add(x9559a72e127afe45(item));
				}
				_7a83d5516f8079b5 = list;
			}
			return _7a83d5516f8079b5;
		}
	}

	private Form xbb288337c81afcb3
	{
		get
		{
			Control control = base.Parent;
			while (control != null && !(control is Form))
			{
				control = control.Parent;
			}
			return (Form)control;
		}
	}

	public x70c0f08fb6e896c2()
	{
		x85601834555fb7d5();
		base.x95a235bff44ec867 = false;
		base.x7bc501a48fc6524b = new ImageList(xb7dfc13308b54974)
		{
			ColorDepth = ColorDepth.Depth32Bit,
			ImageSize = new Size(32, 32),
			Images = 
			{
				{
					"UnknownCode",
					Resources.UnknownCode
				},
				{
					"Game",
					Resources.Game
				},
				{
					"CheckboxCode",
					Resources.CheckboxCode
				},
				{
					"RadioCode",
					Resources.RadioCode
				},
				{
					"CheckboxClosedFolder",
					Resources.CheckboxClosedFolder
				},
				{
					"CheckboxOpenFolder",
					Resources.CheckboxOpenFolder
				},
				{
					"RadioClosedFolder",
					Resources.RadioClosedFolder
				},
				{
					"RadioOpenFolder",
					Resources.RadioOpenFolder
				}
			}
		};
		base.xc439cbba6c00a3a0 = "UnknownCode";
		base.xe7e03246bec9d3a9 = VerticalAlignment.Top;
		xe6e393cb7439a825();
		x88e2c1c91f997feb();
		x34ef08978f85f03e();
		x93cb284a5f0915be();
	}

	protected override void Dispose(bool xb41acd866d5cbca8)
	{
		if (xb41acd866d5cbca8)
		{
			xb7dfc13308b54974.Dispose();
			_83a3078ae721efed.Dispose();
			_896f29d711ea5f3c.Dispose();
			_61540a8cf0d38f6c.Dispose();
			_884ddcb4b34ebfd4.Dispose();
			_487d376dd4dc04ec.Dispose();
			_288a00e303b5ad49.Dispose();
		}
		base.Dispose(xb41acd866d5cbca8);
	}

	private void x85601834555fb7d5()
	{
		xb7dfc13308b54974 = new Container();
	}

	public void x88e2c1c91f997feb()
	{
		_896f29d711ea5f3c = _83a3078ae721efed;
	}

	protected bool x84898887f3d017e3()
	{
		if (_896f29d711ea5f3c == null)
		{
			return false;
		}
		return !_896f29d711ea5f3c.Equals(_83a3078ae721efed);
	}

	public void x34ef08978f85f03e()
	{
		_884ddcb4b34ebfd4 = _61540a8cf0d38f6c;
	}

	protected bool x6d767e131673481d()
	{
		if (_884ddcb4b34ebfd4 == null)
		{
			return false;
		}
		return !_884ddcb4b34ebfd4.Equals(_61540a8cf0d38f6c);
	}

	public void x93cb284a5f0915be()
	{
		_288a00e303b5ad49 = _487d376dd4dc04ec;
	}

	protected bool x71a0c4bfbec4700b()
	{
		if (_288a00e303b5ad49 == null)
		{
			return false;
		}
		return !_288a00e303b5ad49.Equals(_487d376dd4dc04ec);
	}

	private static bool x7cf1081bb25dc247(bool x1dc4dcf3b971513e, ref Font xbbd073498f0ba08c, Font x9d1258bf35449396)
	{
		if (xbbd073498f0ba08c != null)
		{
			xbbd073498f0ba08c.Dispose();
		}
		xbbd073498f0ba08c = x9d1258bf35449396;
		return !x1dc4dcf3b971513e;
	}

	private void xe6e393cb7439a825()
	{
		if (x7cf1081bb25dc247(x84898887f3d017e3(), ref _83a3078ae721efed, new Font(Font.Name, Font.SizeInPoints + 2f, FontStyle.Bold)))
		{
			x88e2c1c91f997feb();
		}
		if (x7cf1081bb25dc247(x6d767e131673481d(), ref _61540a8cf0d38f6c, new Font(Font.Name, Font.SizeInPoints + 1f)))
		{
			x34ef08978f85f03e();
		}
		if (x7cf1081bb25dc247(x71a0c4bfbec4700b(), ref _487d376dd4dc04ec, new Font(FontFamily.GenericMonospace, Font.SizeInPoints, FontStyle.Regular, GraphicsUnit.Point)))
		{
			x93cb284a5f0915be();
		}
	}

	private void x3cd69f5448118938()
	{
		Converter<x95fcf261e3011b00, uint> converter = (x95fcf261e3011b00 xda5bf54deb817e37) => x9559a72e127afe45(xda5bf54deb817e37).xb0b4ff1622a01d12.xb3efee94cf138f44;
		List<uint> list = new List<x95fcf261e3011b00>(base.xc82eff4818ce3f25).ConvertAll(converter);
		List<uint> list2 = new List<x95fcf261e3011b00>(base.x03a3afe609cec84c).FindAll((x95fcf261e3011b00 xda5bf54deb817e37) => xda5bf54deb817e37.x5e48bd0c96038b5e).ConvertAll(converter);
		_7a83d5516f8079b5 = null;
		x5577363cc650aaeb();
		try
		{
			x7098cef51c198a8d = null;
			x13aa21d407581685 = new Dictionary<uint, x95fcf261e3011b00>();
			x63b0f7fed3f5bd88.Clear();
			if (xa0380078f0b6cbb7 == null)
			{
				return;
			}
			xc328f0e6fa38acaf();
			xa0380078f0b6cbb7.xcde1799d3b83bb92.x93b8c3e46ffd8a96();
			x5a26d6343df70953();
			foreach (xfd5dc9a89edfa955 item in xa0380078f0b6cbb7)
			{
				x72be6f2957b1e0ca(item);
			}
			x7098cef51c198a8d.x8810335244b90b9d();
			list2.ForEach(delegate(uint xeaf1b27180c0557b)
			{
				x394a3caa61f59fc1(xeaf1b27180c0557b)?.x8810335244b90b9d();
			});
			list.ForEach(delegate(uint xeaf1b27180c0557b)
			{
				x95fcf261e3011b00 x95fcf261e3011b = x394a3caa61f59fc1(xeaf1b27180c0557b);
				if (x95fcf261e3011b != null)
				{
					x95fcf261e3011b.xaa7558c320af04eb = true;
				}
			});
		}
		finally
		{
			x3ae2e4d73c7847ae();
		}
	}

	private void x5a26d6343df70953()
	{
		foreach (xfd5dc9a89edfa955 item in xa0380078f0b6cbb7)
		{
			if (item.xb0b4ff1622a01d12.xda8f238d1a051872)
			{
				if (x7098cef51c198a8d != null)
				{
					throw new NotSupportedException("A game is only permitted to contain one master code.");
				}
				x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00(item.xb0b4ff1622a01d12.Name);
				x95fcf261e3011b.xd229d86af0f16fb0 = new x8f6a4861a1fa98b2(item);
				x95fcf261e3011b.xc439cbba6c00a3a0 = "Game";
				x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
				x7098cef51c198a8d = x95fcf261e3011b;
				x13aa21d407581685.Add(item.xb0b4ff1622a01d12.xb3efee94cf138f44, x95fcf261e3011b);
			}
		}
		if (x7098cef51c198a8d == null)
		{
			throw new NotSupportedException("A game must contain a master code.");
		}
	}

	private void x72be6f2957b1e0ca(xfd5dc9a89edfa955 x9035cf16181332fc)
	{
		if (x9035cf16181332fc.xb0b4ff1622a01d12.xda8f238d1a051872)
		{
			return;
		}
		x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00(x9035cf16181332fc.xb0b4ff1622a01d12.Name);
		x95fcf261e3011b.xd229d86af0f16fb0 = new x8f6a4861a1fa98b2(x9035cf16181332fc);
		if (x9035cf16181332fc.xb0b4ff1622a01d12.xbe23edc82b0342c0 == null)
		{
			x7098cef51c198a8d.x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
		}
		else
		{
			x95fcf261e3011b.xc439cbba6c00a3a0 = "CheckboxCode";
			x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc = x9035cf16181332fc.xb0b4ff1622a01d12.xbe23edc82b0342c0.x4521e8bf4ec2b6be(4);
			if (x8f4d4d97dd0fc == null)
			{
				x7098cef51c198a8d.x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
			}
			else if (x13aa21d407581685.ContainsKey(x8f4d4d97dd0fc.x6b73aa01aa019d3a))
			{
				x95fcf261e3011b00 x95fcf261e3011b2 = x13aa21d407581685[x8f4d4d97dd0fc.x6b73aa01aa019d3a];
				if (x95fcf261e3011b2.xc439cbba6c00a3a0 == "RadioClosedFolder")
				{
					x95fcf261e3011b.xc439cbba6c00a3a0 = "RadioCode";
				}
				x95fcf261e3011b2.x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
			}
			else
			{
				x95fcf261e3011b.xc439cbba6c00a3a0 = "UnknownCode";
				x7098cef51c198a8d.x63b0f7fed3f5bd88.Add(x95fcf261e3011b);
			}
			x047611ec9892e059.x8f4d4d97dd0fc840 x8f4d4d97dd0fc2 = x9035cf16181332fc.xb0b4ff1622a01d12.xbe23edc82b0342c0.x4521e8bf4ec2b6be(5);
			if (x8f4d4d97dd0fc2 != null)
			{
				if (x8f4d4d97dd0fc2.x6b73aa01aa019d3a == 0)
				{
					x95fcf261e3011b.xc439cbba6c00a3a0 = "CheckboxClosedFolder";
				}
				else
				{
					x95fcf261e3011b.xc439cbba6c00a3a0 = "RadioClosedFolder";
				}
			}
		}
		x13aa21d407581685.Add(x9035cf16181332fc.xb0b4ff1622a01d12.xb3efee94cf138f44, x95fcf261e3011b);
	}

	public x95fcf261e3011b00 x394a3caa61f59fc1(xfd5dc9a89edfa955 x9035cf16181332fc)
	{
		if (x9035cf16181332fc == null)
		{
			throw new ArgumentNullException("code");
		}
		return x394a3caa61f59fc1(x9035cf16181332fc.xb0b4ff1622a01d12.xb3efee94cf138f44);
	}

	public x95fcf261e3011b00 x394a3caa61f59fc1(uint xba336f6c3ae33222)
	{
		if (x13aa21d407581685.TryGetValue(xba336f6c3ae33222, out var value))
		{
			return value;
		}
		return null;
	}

	public xfd5dc9a89edfa955 x9559a72e127afe45(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		if (xda5bf54deb817e37 == null)
		{
			throw new ArgumentNullException("node");
		}
		return ((x8f6a4861a1fa98b2)xda5bf54deb817e37.xd229d86af0f16fb0).xc8f46b505998937b;
	}

	protected override void OnNodeSelectionChanged(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		_7a83d5516f8079b5 = null;
		base.OnNodeSelectionChanged(xfbf34718e704c6bc);
	}

	public bool x9a39398ee4ef5b5f()
	{
		if (base.xc82eff4818ce3f25.Count != 1)
		{
			return false;
		}
		if (x9559a72e127afe45(base.xc82eff4818ce3f25[0]).xa157de8185757b11)
		{
			return false;
		}
		return base.xc82eff4818ce3f25[0].x99d6b0b05cd7185f != null;
	}

	public void x30e215f891925def()
	{
		if (base.xc82eff4818ce3f25.Count != 1)
		{
			throw new InvalidOperationException("Single selection required");
		}
		x95fcf261e3011b00 x95fcf261e3011b = base.xc82eff4818ce3f25[0];
		xf8992f666652d7b1(x95fcf261e3011b, x95fcf261e3011b.x99d6b0b05cd7185f);
	}

	public bool xb46e47a96f30797b()
	{
		if (base.xc82eff4818ce3f25.Count != 1)
		{
			return false;
		}
		if (x9559a72e127afe45(base.xc82eff4818ce3f25[0]).xa157de8185757b11)
		{
			return false;
		}
		if (base.xc82eff4818ce3f25[0].x4f6686d624d5dfe1 != null)
		{
			return x9559a72e127afe45(base.xc82eff4818ce3f25[0].x4f6686d624d5dfe1).x8c84b6fad60c11f5;
		}
		return false;
	}

	public void x6f0363886d340825()
	{
		if (base.xc82eff4818ce3f25.Count != 1)
		{
			throw new InvalidOperationException("Single selection required");
		}
		x95fcf261e3011b00 x95fcf261e3011b = base.xc82eff4818ce3f25[0];
		xf8992f666652d7b1(x95fcf261e3011b, x95fcf261e3011b.x4f6686d624d5dfe1);
	}

	private void xf8992f666652d7b1(x95fcf261e3011b00 xda5bf54deb817e37, x95fcf261e3011b00 x9885ca17c1b6bfb1)
	{
		if (xda5bf54deb817e37 == null)
		{
			throw new ArgumentNullException("node");
		}
		xfd5dc9a89edfa955 xfd5dc9a89edfa = x9559a72e127afe45(xda5bf54deb817e37);
		if (xfd5dc9a89edfa.xa157de8185757b11)
		{
			throw new InvalidOperationException("Cannot move inherited codes");
		}
		if (x9885ca17c1b6bfb1 != null)
		{
			int x873721d4383ca28a = xa0380078f0b6cbb7.xcde1799d3b83bb92.x2ee5ad3d826ed0fe(x9559a72e127afe45(x9885ca17c1b6bfb1).x5744d14068b65123);
			xa0380078f0b6cbb7.xcde1799d3b83bb92.x01b2723108ff3dfe(xfd5dc9a89edfa.x5744d14068b65123, x873721d4383ca28a);
			xa0380078f0b6cbb7.xcde1799d3b83bb92.x93b8c3e46ffd8a96();
			xa0380078f0b6cbb7.xf00ec3a0a012caa0();
			x3cd69f5448118938();
		}
	}

	private void xc328f0e6fa38acaf()
	{
		if (base.DesignMode || !x7bb28d9758d19dd0.x3452082a8fecf97d)
		{
			return;
		}
		Form owner = xbb288337c81afcb3;
		while (owner != null && !owner.Visible)
		{
			owner = owner.Owner;
		}
		List<xbabc9feec6f641db> list = xa0380078f0b6cbb7.xfd788c2d21a2ecf6((xbabc9feec6f641db x9035cf16181332fc) => x9035cf16181332fc.xbe23edc82b0342c0 == null);
		if (list.Count == 0)
		{
			return;
		}
		try
		{
			List<string> list2 = x7bb28d9758d19dd0.x2731b90dfbad5cbc(list);
			if (list2.Count > 0)
			{
				MessageBox.Show(owner, string.Join("\r\n", list2.ToArray()), "Code processing errors", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(owner, ex.Message, "Code processing failure", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	protected override void OnCollapsing(x495ca8a85eccbead xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.Node == x7098cef51c198a8d)
		{
			xfbf34718e704c6bc.Cancel = true;
		}
		base.OnCollapsing(xfbf34718e704c6bc);
	}

	protected override void OnCollapsed(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 == "CheckboxOpenFolder")
		{
			xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 = "CheckboxClosedFolder";
		}
		else if (xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 == "RadioOpenFolder")
		{
			xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 = "RadioClosedFolder";
		}
		base.OnCollapsed(xfbf34718e704c6bc);
	}

	protected override void OnExpanded(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 == "CheckboxClosedFolder")
		{
			xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 = "CheckboxOpenFolder";
		}
		else if (xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 == "RadioClosedFolder")
		{
			xfbf34718e704c6bc.x40212106aad8a8b0.xc439cbba6c00a3a0 = "RadioOpenFolder";
		}
		base.OnExpanded(xfbf34718e704c6bc);
	}

	protected override void UpdateNodeHeight(x95fcf261e3011b00 xda5bf54deb817e37, int x9b0739496f8b5475)
	{
		if (xda5bf54deb817e37.xd229d86af0f16fb0 is x8f6a4861a1fa98b2 x8f6a4861a1fa98b)
		{
			if (x8f6a4861a1fa98b.xb0b4ff1622a01d12.xda8f238d1a051872)
			{
				x8f6a4861a1fa98b.xe9297f3324ef6f28 = xa0380078f0b6cbb7.xcde1799d3b83bb92.x759aa16c2016a289;
				x8f6a4861a1fa98b.x999a9e029fc88104 = xa0380078f0b6cbb7.xcde1799d3b83bb92.x4e020dae918bd2ce;
			}
			else
			{
				x8f6a4861a1fa98b.xe9297f3324ef6f28 = x8f6a4861a1fa98b.xb0b4ff1622a01d12.Name;
				x8f6a4861a1fa98b.x999a9e029fc88104 = x8f6a4861a1fa98b.xb0b4ff1622a01d12.x4e020dae918bd2ce;
			}
			x8f6a4861a1fa98b.x4191326b8c285bfa = x8f6a4861a1fa98b.xb0b4ff1622a01d12.x4191326b8c285bfa;
			using (Graphics graphics = CreateGraphics())
			{
				int num = xda5bf54deb817e37.x884641cec39ad3eb.Width;
				SizeF size = graphics.MeasureString(x8f6a4861a1fa98b.xe9297f3324ef6f28, x896f29d711ea5f3c, num);
				x8f6a4861a1fa98b.x633856f77b322cec = new RectangleF(Point.Empty, size);
				SizeF sizeF = graphics.MeasureString(x8f6a4861a1fa98b.x999a9e029fc88104, x884ddcb4b34ebfd4, num - 8);
				x8f6a4861a1fa98b.xffaf890d231e8b63 = new RectangleF(x8f6a4861a1fa98b.x633856f77b322cec.Left + 8f, x8f6a4861a1fa98b.x633856f77b322cec.Bottom, sizeF.Width, sizeF.Height);
				SizeF sizeF2 = graphics.MeasureString(x8f6a4861a1fa98b.x4191326b8c285bfa, x288a00e303b5ad49, num - 16);
				x8f6a4861a1fa98b.x81baaabf2ec59aa2 = new RectangleF(x8f6a4861a1fa98b.x633856f77b322cec.Left + 16f, Math.Max(x8f6a4861a1fa98b.x633856f77b322cec.Bottom, x8f6a4861a1fa98b.xffaf890d231e8b63.Bottom), sizeF2.Width, sizeF2.Height);
			}
			xda5bf54deb817e37.xb0f146032f47c24e = (int)Math.Ceiling(x8f6a4861a1fa98b.x81baaabf2ec59aa2.Bottom - x8f6a4861a1fa98b.x633856f77b322cec.Top);
		}
		base.UpdateNodeHeight(xda5bf54deb817e37, x9b0739496f8b5475);
	}

	protected override void PaintContentText(Graphics x41347a961b838962, Rectangle xda73fcb97c77d998, x95fcf261e3011b00 xda5bf54deb817e37, Color x53218bf919efffd4, Color x154083d58301ef75)
	{
		if (!(xda5bf54deb817e37.xd229d86af0f16fb0 is x8f6a4861a1fa98b2 x8f6a4861a1fa98b))
		{
			return;
		}
		if (x8f6a4861a1fa98b.xc8f46b505998937b.xa157de8185757b11)
		{
			x53218bf919efffd4 = SystemColors.GrayText;
		}
		else if (!x8f6a4861a1fa98b.xc8f46b505998937b.xb0b4ff1622a01d12.xda8f238d1a051872 && x8f6a4861a1fa98b.xc8f46b505998937b.xb0b4ff1622a01d12.xbe23edc82b0342c0 != null && x8f6a4861a1fa98b.xc8f46b505998937b.xb0b4ff1622a01d12.xbe23edc82b0342c0.xea84056d876cd25a.Count == 0 && x8f6a4861a1fa98b.xc8f46b505998937b.xb0b4ff1622a01d12.xbe23edc82b0342c0.x4521e8bf4ec2b6be(5) == null)
		{
			x53218bf919efffd4 = Color.Green;
		}
		using Brush brush2 = new SolidBrush(x53218bf919efffd4);
		using Brush brush = new SolidBrush(x154083d58301ef75);
		x41347a961b838962.FillRectangle(brush, xda73fcb97c77d998);
		RectangleF x633856f77b322cec = x8f6a4861a1fa98b.x633856f77b322cec;
		RectangleF xffaf890d231e8b = x8f6a4861a1fa98b.xffaf890d231e8b63;
		RectangleF x81baaabf2ec59aa = x8f6a4861a1fa98b.x81baaabf2ec59aa2;
		x633856f77b322cec.Offset(xda73fcb97c77d998.Location);
		xffaf890d231e8b.Offset(xda73fcb97c77d998.Location);
		x81baaabf2ec59aa.Offset(xda73fcb97c77d998.Location);
		x41347a961b838962.DrawString(x8f6a4861a1fa98b.xe9297f3324ef6f28, x896f29d711ea5f3c, brush2, x633856f77b322cec);
		x41347a961b838962.DrawString(x8f6a4861a1fa98b.x999a9e029fc88104, x884ddcb4b34ebfd4, brush2, xffaf890d231e8b);
		x41347a961b838962.DrawString(x8f6a4861a1fa98b.x4191326b8c285bfa, x288a00e303b5ad49, brush2, x81baaabf2ec59aa);
	}

	[CompilerGenerated]
	private uint x061d076d22192317(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		return x9559a72e127afe45(xda5bf54deb817e37).xb0b4ff1622a01d12.xb3efee94cf138f44;
	}

	[CompilerGenerated]
	private static bool xfab0c875b6424502(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		return xda5bf54deb817e37.x5e48bd0c96038b5e;
	}

	[CompilerGenerated]
	private void x437ebb6944ee2943(uint xeaf1b27180c0557b)
	{
		x394a3caa61f59fc1(xeaf1b27180c0557b)?.x8810335244b90b9d();
	}

	[CompilerGenerated]
	private void x964ede6727df62a2(uint xeaf1b27180c0557b)
	{
		x95fcf261e3011b00 x95fcf261e3011b = x394a3caa61f59fc1(xeaf1b27180c0557b);
		if (x95fcf261e3011b != null)
		{
			x95fcf261e3011b.xaa7558c320af04eb = true;
		}
	}

	[CompilerGenerated]
	private static bool xcf9b486fe85c7d84(xbabc9feec6f641db x9035cf16181332fc)
	{
		return x9035cf16181332fc.xbe23edc82b0342c0 == null;
	}
}
