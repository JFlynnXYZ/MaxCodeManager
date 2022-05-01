using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace xca7bfd2e2e8437c4;

[DesignerCategory("")]
internal class xb4aca27d4042277c : Button
{
	private const int xea1a900984528f0e = 18;

	private PushButtonState _01b557925841ae51;

	private static int x5a2e5f1a044abafd = SystemInformation.Border3DSize.Width * 2;

	private bool x3801fb00f092121c;

	private Rectangle xa912c91339a9550a;

	private bool x302c8f3c3c54e796;

	private bool x83b528985b0490d3;

	private ContextMenuStrip xfcafee13fbdcb303;

	private ContextMenu x18ad87e3e5052114;

	private TextFormatFlags xec3b3f14b27d472e;

	private bool xdeb4d3f039e6d708;

	[Browsable(false)]
	public override ContextMenuStrip ContextMenuStrip
	{
		get
		{
			return xc2321a5736e68335;
		}
		set
		{
			xc2321a5736e68335 = value;
		}
	}

	[DefaultValue(null)]
	public ContextMenu xa566977334e480fe
	{
		get
		{
			return x18ad87e3e5052114;
		}
		set
		{
			if (x18ad87e3e5052114 != null)
			{
				x18ad87e3e5052114.Popup -= x2e035f02b354c1ce;
			}
			if (value != null)
			{
				x3365ea5e28f00dbc = true;
				value.Popup += x2e035f02b354c1ce;
			}
			else
			{
				x3365ea5e28f00dbc = false;
			}
			x18ad87e3e5052114 = value;
		}
	}

	[DefaultValue(null)]
	public ContextMenuStrip xc2321a5736e68335
	{
		get
		{
			return xfcafee13fbdcb303;
		}
		set
		{
			if (xfcafee13fbdcb303 != null)
			{
				xfcafee13fbdcb303.Closing -= x3ccfc8098244c64b;
				xfcafee13fbdcb303.Opening -= xc65c5c28d4f820e9;
			}
			if (value != null)
			{
				x3365ea5e28f00dbc = true;
				value.Closing += x3ccfc8098244c64b;
				value.Opening += xc65c5c28d4f820e9;
			}
			else
			{
				x3365ea5e28f00dbc = false;
			}
			xfcafee13fbdcb303 = value;
		}
	}

	[DefaultValue(false)]
	public bool x3365ea5e28f00dbc
	{
		set
		{
			if (value != x302c8f3c3c54e796)
			{
				x302c8f3c3c54e796 = value;
				Invalidate();
				if (base.Parent != null)
				{
					base.Parent.PerformLayout();
				}
			}
		}
	}

	private PushButtonState xffb3238a8fd59aa7
	{
		get
		{
			return _01b557925841ae51;
		}
		set
		{
			if (!_01b557925841ae51.Equals(value))
			{
				_01b557925841ae51 = value;
				Invalidate();
			}
		}
	}

	public xb4aca27d4042277c()
	{
		AutoSize = true;
	}

	protected override bool IsInputKey(Keys x7164e699dd95323c)
	{
		if (x7164e699dd95323c.Equals(Keys.Down) && x302c8f3c3c54e796)
		{
			return true;
		}
		return base.IsInputKey(x7164e699dd95323c);
	}

	protected override void OnGotFocus(EventArgs xfbf34718e704c6bc)
	{
		if (!x302c8f3c3c54e796)
		{
			base.OnGotFocus(xfbf34718e704c6bc);
		}
		else if (!xffb3238a8fd59aa7.Equals(PushButtonState.Pressed) && !xffb3238a8fd59aa7.Equals(PushButtonState.Disabled))
		{
			xffb3238a8fd59aa7 = PushButtonState.Default;
		}
	}

	protected override void OnKeyDown(KeyEventArgs xabade24c69547bb4)
	{
		if (x302c8f3c3c54e796)
		{
			if (xabade24c69547bb4.KeyCode.Equals(Keys.Down) && !x83b528985b0490d3)
			{
				x18c7810149270b9e();
			}
			else if (xabade24c69547bb4.KeyCode.Equals(Keys.Space) && xabade24c69547bb4.Modifiers == Keys.None)
			{
				xffb3238a8fd59aa7 = PushButtonState.Pressed;
			}
		}
		base.OnKeyDown(xabade24c69547bb4);
	}

	protected override void OnKeyUp(KeyEventArgs xabade24c69547bb4)
	{
		if (xabade24c69547bb4.KeyCode.Equals(Keys.Space))
		{
			if (Control.MouseButtons == MouseButtons.None)
			{
				xffb3238a8fd59aa7 = PushButtonState.Normal;
			}
		}
		else if (xabade24c69547bb4.KeyCode.Equals(Keys.Apps) && Control.MouseButtons == MouseButtons.None && !x83b528985b0490d3)
		{
			x18c7810149270b9e();
		}
		base.OnKeyUp(xabade24c69547bb4);
	}

	protected override void OnEnabledChanged(EventArgs xfbf34718e704c6bc)
	{
		xffb3238a8fd59aa7 = (base.Enabled ? PushButtonState.Normal : PushButtonState.Disabled);
		base.OnEnabledChanged(xfbf34718e704c6bc);
	}

	protected override void OnLostFocus(EventArgs xfbf34718e704c6bc)
	{
		if (!x302c8f3c3c54e796)
		{
			base.OnLostFocus(xfbf34718e704c6bc);
		}
		else if (!xffb3238a8fd59aa7.Equals(PushButtonState.Pressed) && !xffb3238a8fd59aa7.Equals(PushButtonState.Disabled))
		{
			xffb3238a8fd59aa7 = PushButtonState.Normal;
		}
	}

	protected override void OnMouseEnter(EventArgs xfbf34718e704c6bc)
	{
		if (!x302c8f3c3c54e796)
		{
			base.OnMouseEnter(xfbf34718e704c6bc);
			return;
		}
		xdeb4d3f039e6d708 = true;
		if (!xffb3238a8fd59aa7.Equals(PushButtonState.Pressed) && !xffb3238a8fd59aa7.Equals(PushButtonState.Disabled))
		{
			xffb3238a8fd59aa7 = PushButtonState.Hot;
		}
	}

	protected override void OnMouseLeave(EventArgs xfbf34718e704c6bc)
	{
		if (!x302c8f3c3c54e796)
		{
			base.OnMouseLeave(xfbf34718e704c6bc);
			return;
		}
		xdeb4d3f039e6d708 = false;
		if (!xffb3238a8fd59aa7.Equals(PushButtonState.Pressed) && !xffb3238a8fd59aa7.Equals(PushButtonState.Disabled))
		{
			xffb3238a8fd59aa7 = ((!Focused) ? PushButtonState.Normal : PushButtonState.Default);
		}
	}

	protected override void OnMouseDown(MouseEventArgs xfbf34718e704c6bc)
	{
		if (!x302c8f3c3c54e796)
		{
			base.OnMouseDown(xfbf34718e704c6bc);
			return;
		}
		if (x18ad87e3e5052114 != null && xfbf34718e704c6bc.Button == MouseButtons.Left && !xdeb4d3f039e6d708)
		{
			x3801fb00f092121c = true;
		}
		if (xa912c91339a9550a.Contains(xfbf34718e704c6bc.Location) && !x83b528985b0490d3 && xfbf34718e704c6bc.Button == MouseButtons.Left)
		{
			x18c7810149270b9e();
		}
		else
		{
			xffb3238a8fd59aa7 = PushButtonState.Pressed;
		}
	}

	protected override void OnMouseUp(MouseEventArgs x797b7706f394da27)
	{
		if (!x302c8f3c3c54e796)
		{
			base.OnMouseUp(x797b7706f394da27);
		}
		else if (x797b7706f394da27.Button == MouseButtons.Right && base.ClientRectangle.Contains(x797b7706f394da27.Location) && !x83b528985b0490d3)
		{
			x18c7810149270b9e();
		}
		else if ((xfcafee13fbdcb303 == null && x18ad87e3e5052114 == null) || !x83b528985b0490d3)
		{
			x5379115e1ccee283();
			if (base.ClientRectangle.Contains(x797b7706f394da27.Location) && !xa912c91339a9550a.Contains(x797b7706f394da27.Location))
			{
				OnClick(new EventArgs());
			}
		}
	}

	protected override void OnPaint(PaintEventArgs x6e8f4405e0958692)
	{
		base.OnPaint(x6e8f4405e0958692);
		if (!x302c8f3c3c54e796)
		{
			return;
		}
		Graphics graphics = x6e8f4405e0958692.Graphics;
		Rectangle clientRectangle = base.ClientRectangle;
		if (xffb3238a8fd59aa7 != PushButtonState.Pressed && base.IsDefault && !Application.RenderWithVisualStyles)
		{
			Rectangle bounds = clientRectangle;
			bounds.Inflate(-1, -1);
			ButtonRenderer.DrawButton(graphics, bounds, xffb3238a8fd59aa7);
			graphics.DrawRectangle(SystemPens.WindowFrame, 0, 0, clientRectangle.Width - 1, clientRectangle.Height - 1);
		}
		else
		{
			ButtonRenderer.DrawButton(graphics, clientRectangle, xffb3238a8fd59aa7);
		}
		xa912c91339a9550a = new Rectangle(clientRectangle.Right - 18, 0, 18, clientRectangle.Height);
		int num = x5a2e5f1a044abafd;
		Rectangle rectangle = new Rectangle(num - 1, num - 1, clientRectangle.Width - xa912c91339a9550a.Width - num, clientRectangle.Height - num * 2 + 2);
		bool flag = xffb3238a8fd59aa7 == PushButtonState.Hot || xffb3238a8fd59aa7 == PushButtonState.Pressed || !Application.RenderWithVisualStyles;
		if (RightToLeft == RightToLeft.Yes)
		{
			xa912c91339a9550a.X = clientRectangle.Left + 1;
			rectangle.X = xa912c91339a9550a.Right;
			if (flag)
			{
				graphics.DrawLine(SystemPens.ButtonShadow, clientRectangle.Left + 18, x5a2e5f1a044abafd, clientRectangle.Left + 18, clientRectangle.Bottom - x5a2e5f1a044abafd);
				graphics.DrawLine(SystemPens.ButtonFace, clientRectangle.Left + 18 + 1, x5a2e5f1a044abafd, clientRectangle.Left + 18 + 1, clientRectangle.Bottom - x5a2e5f1a044abafd);
			}
		}
		else if (flag)
		{
			graphics.DrawLine(SystemPens.ButtonShadow, clientRectangle.Right - 18, x5a2e5f1a044abafd, clientRectangle.Right - 18, clientRectangle.Bottom - x5a2e5f1a044abafd);
			graphics.DrawLine(SystemPens.ButtonFace, clientRectangle.Right - 18 - 1, x5a2e5f1a044abafd, clientRectangle.Right - 18 - 1, clientRectangle.Bottom - x5a2e5f1a044abafd);
		}
		x70af040924580888(graphics, xa912c91339a9550a);
		x6ba66751655fb2ad(graphics, new Rectangle(0, 0, base.ClientRectangle.Width - 18, base.ClientRectangle.Height));
		if (xffb3238a8fd59aa7 != PushButtonState.Pressed && Focused && ShowFocusCues)
		{
			ControlPaint.DrawFocusRectangle(graphics, rectangle);
		}
	}

	private void x6ba66751655fb2ad(Graphics x4b101060f4767186, Rectangle xda73fcb97c77d998)
	{
		x260d4e9d92da5d8f(ref xda73fcb97c77d998, out var x1707ae60eecbcc7d, out var x98f3a6b7885b34be);
		if (base.Image != null)
		{
			if (base.Enabled)
			{
				x4b101060f4767186.DrawImage(base.Image, x98f3a6b7885b34be.X, x98f3a6b7885b34be.Y, base.Image.Width, base.Image.Height);
			}
			else
			{
				ControlPaint.DrawImageDisabled(x4b101060f4767186, base.Image, x98f3a6b7885b34be.X, x98f3a6b7885b34be.Y, BackColor);
			}
		}
		if (!base.UseMnemonic)
		{
			xec3b3f14b27d472e |= TextFormatFlags.NoPrefix;
		}
		else if (!ShowKeyboardCues)
		{
			xec3b3f14b27d472e |= TextFormatFlags.HidePrefix;
		}
		if (!string.IsNullOrEmpty(Text))
		{
			if (base.Enabled)
			{
				TextRenderer.DrawText(x4b101060f4767186, Text, Font, x1707ae60eecbcc7d, SystemColors.ControlText, xec3b3f14b27d472e);
			}
			else
			{
				ControlPaint.DrawStringDisabled(x4b101060f4767186, Text, Font, BackColor, x1707ae60eecbcc7d, xec3b3f14b27d472e);
			}
		}
	}

	private void x70af040924580888(Graphics x4b101060f4767186, Rectangle x7b34bad9328ee55d)
	{
		Point point = new Point(Convert.ToInt32(x7b34bad9328ee55d.Left + x7b34bad9328ee55d.Width / 2), Convert.ToInt32(x7b34bad9328ee55d.Top + x7b34bad9328ee55d.Height / 2));
		point.X += x7b34bad9328ee55d.Width % 2;
		Point[] points = new Point[3]
		{
			new Point(point.X - 2, point.Y - 1),
			new Point(point.X + 3, point.Y - 1),
			new Point(point.X, point.Y + 2)
		};
		if (base.Enabled)
		{
			x4b101060f4767186.FillPolygon(SystemBrushes.ControlText, points);
		}
		else
		{
			x4b101060f4767186.FillPolygon(SystemBrushes.ButtonShadow, points);
		}
	}

	public override Size GetPreferredSize(Size x2e2053abf8a9ea79)
	{
		Size preferredSize = base.GetPreferredSize(x2e2053abf8a9ea79);
		if (x302c8f3c3c54e796)
		{
			if (AutoSize)
			{
				return x1689c79971190159();
			}
			if (!string.IsNullOrEmpty(Text) && TextRenderer.MeasureText(Text, Font).Width + 18 > preferredSize.Width)
			{
				return preferredSize + new Size(18 + x5a2e5f1a044abafd * 2, 0);
			}
		}
		return preferredSize;
	}

	private Size x1689c79971190159()
	{
		Size empty = Size.Empty;
		Size size = TextRenderer.MeasureText(Text, Font);
		Size size2 = ((base.Image == null) ? Size.Empty : base.Image.Size);
		if (Text.Length != 0)
		{
			size.Height += 4;
			size.Width += 4;
		}
		switch (base.TextImageRelation)
		{
		case TextImageRelation.Overlay:
			empty.Height = Math.Max((Text.Length != 0) ? size.Height : 0, size2.Height);
			empty.Width = Math.Max(size.Width, size2.Width);
			break;
		case TextImageRelation.ImageAboveText:
		case TextImageRelation.TextAboveImage:
			empty.Height = size.Height + size2.Height;
			empty.Width = Math.Max(size.Width, size2.Width);
			break;
		case TextImageRelation.ImageBeforeText:
		case TextImageRelation.TextBeforeImage:
			empty.Height = Math.Max(size.Height, size2.Height);
			empty.Width = size.Width + size2.Width;
			break;
		}
		empty.Height += base.Padding.Vertical + 6;
		empty.Width += base.Padding.Horizontal + 6;
		if (x302c8f3c3c54e796)
		{
			empty.Width += 18;
		}
		return empty;
	}

	private void x260d4e9d92da5d8f(ref Rectangle x935564f18039e6af, out Rectangle x1707ae60eecbcc7d, out Rectangle x98f3a6b7885b34be)
	{
		Size x50dee20f943912f = TextRenderer.MeasureText(Text, Font, x935564f18039e6af.Size, xec3b3f14b27d472e);
		Size x50dee20f943912f2 = ((base.Image == null) ? Size.Empty : base.Image.Size);
		x1707ae60eecbcc7d = Rectangle.Empty;
		x98f3a6b7885b34be = Rectangle.Empty;
		switch (base.TextImageRelation)
		{
		case TextImageRelation.Overlay:
			x1707ae60eecbcc7d = xd783436d087a42db(ref x935564f18039e6af, ref x50dee20f943912f, TextAlign);
			if (_01b557925841ae51 == PushButtonState.Pressed && !Application.RenderWithVisualStyles)
			{
				x1707ae60eecbcc7d.Offset(1, 1);
			}
			if (base.Image != null)
			{
				x98f3a6b7885b34be = xd783436d087a42db(ref x935564f18039e6af, ref x50dee20f943912f2, base.ImageAlign);
			}
			break;
		case TextImageRelation.ImageAboveText:
			x935564f18039e6af.Inflate(-4, -4);
			x1ecb8c409a3c01cf(x935564f18039e6af, x34c043a23aa6dee6: false, x50dee20f943912f, x50dee20f943912f2, out x1707ae60eecbcc7d, out x98f3a6b7885b34be);
			break;
		case TextImageRelation.TextAboveImage:
			x935564f18039e6af.Inflate(-4, -4);
			x1ecb8c409a3c01cf(x935564f18039e6af, x34c043a23aa6dee6: true, x50dee20f943912f, x50dee20f943912f2, out x1707ae60eecbcc7d, out x98f3a6b7885b34be);
			break;
		case TextImageRelation.ImageBeforeText:
			x935564f18039e6af.Inflate(-4, -4);
			xc85dd5a3a5ff3e28(x935564f18039e6af, x34c043a23aa6dee6: false, x50dee20f943912f, x50dee20f943912f2, out x1707ae60eecbcc7d, out x98f3a6b7885b34be);
			break;
		case TextImageRelation.TextBeforeImage:
			x935564f18039e6af.Inflate(-4, -4);
			xc85dd5a3a5ff3e28(x935564f18039e6af, x34c043a23aa6dee6: true, x50dee20f943912f, x50dee20f943912f2, out x1707ae60eecbcc7d, out x98f3a6b7885b34be);
			break;
		case (TextImageRelation)3:
		case (TextImageRelation)5:
		case (TextImageRelation)6:
		case (TextImageRelation)7:
			break;
		}
	}

	private static Rectangle xd783436d087a42db(ref Rectangle xd3311d815ca25f02, ref Size x50dee20f943912f2, System.Drawing.ContentAlignment x4ec4022180cbf8f4)
	{
		int num;
		int num2;
		switch (x4ec4022180cbf8f4)
		{
		case System.Drawing.ContentAlignment.TopLeft:
			num = 4;
			num2 = 4;
			break;
		case System.Drawing.ContentAlignment.TopCenter:
			num = (xd3311d815ca25f02.Width - x50dee20f943912f2.Width) / 2;
			num2 = 4;
			break;
		case System.Drawing.ContentAlignment.TopRight:
			num = xd3311d815ca25f02.Width - x50dee20f943912f2.Width - 4;
			num2 = 4;
			break;
		case System.Drawing.ContentAlignment.MiddleLeft:
			num = 4;
			num2 = (xd3311d815ca25f02.Height - x50dee20f943912f2.Height) / 2;
			break;
		case System.Drawing.ContentAlignment.MiddleCenter:
			num = (xd3311d815ca25f02.Width - x50dee20f943912f2.Width) / 2;
			num2 = (xd3311d815ca25f02.Height - x50dee20f943912f2.Height) / 2;
			break;
		case System.Drawing.ContentAlignment.MiddleRight:
			num = xd3311d815ca25f02.Width - x50dee20f943912f2.Width - 4;
			num2 = (xd3311d815ca25f02.Height - x50dee20f943912f2.Height) / 2;
			break;
		case System.Drawing.ContentAlignment.BottomLeft:
			num = 4;
			num2 = xd3311d815ca25f02.Height - x50dee20f943912f2.Height - 4;
			break;
		case System.Drawing.ContentAlignment.BottomCenter:
			num = (xd3311d815ca25f02.Width - x50dee20f943912f2.Width) / 2;
			num2 = xd3311d815ca25f02.Height - x50dee20f943912f2.Height - 4;
			break;
		case System.Drawing.ContentAlignment.BottomRight:
			num = xd3311d815ca25f02.Width - x50dee20f943912f2.Width - 4;
			num2 = xd3311d815ca25f02.Height - x50dee20f943912f2.Height - 4;
			break;
		default:
			num = 4;
			num2 = 4;
			break;
		}
		return new Rectangle(num, num2, x50dee20f943912f2.Width, x50dee20f943912f2.Height);
	}

	private void xc85dd5a3a5ff3e28(Rectangle x3133ad5e84f586ce, bool x34c043a23aa6dee6, Size x411c9be51e5febde, Size x95dac044246123ac, out Rectangle x59dcf7372713ec60, out Rectangle x443b4b9ad47ce447)
	{
		int num = 0;
		int num2 = x411c9be51e5febde.Width + num + x95dac044246123ac.Width;
		if (!x34c043a23aa6dee6)
		{
			num += 2;
		}
		if (num2 > x3133ad5e84f586ce.Width)
		{
			x411c9be51e5febde.Width = x3133ad5e84f586ce.Width - num - x95dac044246123ac.Width;
			num2 = x3133ad5e84f586ce.Width;
		}
		int num3 = x3133ad5e84f586ce.Width - num2;
		int num4 = 0;
		HorizontalAlignment horizontalAlignment = x5b0c4d394d744e4b(TextAlign);
		HorizontalAlignment horizontalAlignment2 = x5b0c4d394d744e4b(base.ImageAlign);
		num4 = ((horizontalAlignment2 != 0) ? ((horizontalAlignment2 == HorizontalAlignment.Right && horizontalAlignment == HorizontalAlignment.Right) ? num3 : ((horizontalAlignment2 != HorizontalAlignment.Center || (horizontalAlignment != 0 && horizontalAlignment != HorizontalAlignment.Center)) ? (num4 + 2 * (num3 / 3)) : (num4 + num3 / 3))) : 0);
		Rectangle rectangle;
		Rectangle rectangle2;
		if (x34c043a23aa6dee6)
		{
			rectangle = new Rectangle(x3133ad5e84f586ce.Left + num4, x5948ec9747755f2c(x3133ad5e84f586ce, x411c9be51e5febde, TextAlign).Top, x411c9be51e5febde.Width, x411c9be51e5febde.Height);
			rectangle2 = new Rectangle(rectangle.Right + num, x5948ec9747755f2c(x3133ad5e84f586ce, x95dac044246123ac, base.ImageAlign).Top, x95dac044246123ac.Width, x95dac044246123ac.Height);
		}
		else
		{
			rectangle2 = new Rectangle(x3133ad5e84f586ce.Left + num4, x5948ec9747755f2c(x3133ad5e84f586ce, x95dac044246123ac, base.ImageAlign).Top, x95dac044246123ac.Width, x95dac044246123ac.Height);
			rectangle = new Rectangle(rectangle2.Right + num, x5948ec9747755f2c(x3133ad5e84f586ce, x411c9be51e5febde, TextAlign).Top, x411c9be51e5febde.Width, x411c9be51e5febde.Height);
		}
		x59dcf7372713ec60 = rectangle;
		x443b4b9ad47ce447 = rectangle2;
	}

	private void x1ecb8c409a3c01cf(Rectangle x3133ad5e84f586ce, bool x34c043a23aa6dee6, Size x411c9be51e5febde, Size x95dac044246123ac, out Rectangle x59dcf7372713ec60, out Rectangle x443b4b9ad47ce447)
	{
		int num = 0;
		int num2 = x411c9be51e5febde.Height + num + x95dac044246123ac.Height;
		if (x34c043a23aa6dee6)
		{
			num += 2;
		}
		if (x411c9be51e5febde.Width > x3133ad5e84f586ce.Width)
		{
			x411c9be51e5febde.Width = x3133ad5e84f586ce.Width;
		}
		if (num2 > x3133ad5e84f586ce.Height && x34c043a23aa6dee6)
		{
			x95dac044246123ac = Size.Empty;
			num2 = x3133ad5e84f586ce.Height;
		}
		int num3 = x3133ad5e84f586ce.Height - num2;
		int num4 = 0;
		VerticalAlignment verticalAlignment = xf839f06c84dcab9b(TextAlign);
		VerticalAlignment verticalAlignment2 = xf839f06c84dcab9b(base.ImageAlign);
		num4 = ((verticalAlignment2 != 0) ? ((verticalAlignment2 == VerticalAlignment.Bottom && verticalAlignment == VerticalAlignment.Bottom) ? num3 : ((verticalAlignment2 != VerticalAlignment.Center || (verticalAlignment != 0 && verticalAlignment != VerticalAlignment.Center)) ? (num4 + 2 * (num3 / 3)) : (num4 + num3 / 3))) : 0);
		Rectangle rectangle;
		Rectangle rectangle2;
		if (x34c043a23aa6dee6)
		{
			rectangle = new Rectangle(x5948ec9747755f2c(x3133ad5e84f586ce, x411c9be51e5febde, TextAlign).Left, x3133ad5e84f586ce.Top + num4, x411c9be51e5febde.Width, x411c9be51e5febde.Height);
			rectangle2 = new Rectangle(x5948ec9747755f2c(x3133ad5e84f586ce, x95dac044246123ac, base.ImageAlign).Left, rectangle.Bottom + num, x95dac044246123ac.Width, x95dac044246123ac.Height);
		}
		else
		{
			rectangle2 = new Rectangle(x5948ec9747755f2c(x3133ad5e84f586ce, x95dac044246123ac, base.ImageAlign).Left, x3133ad5e84f586ce.Top + num4, x95dac044246123ac.Width, x95dac044246123ac.Height);
			rectangle = new Rectangle(x5948ec9747755f2c(x3133ad5e84f586ce, x411c9be51e5febde, TextAlign).Left, rectangle2.Bottom + num, x411c9be51e5febde.Width, x411c9be51e5febde.Height);
			if (rectangle.Bottom > x3133ad5e84f586ce.Bottom)
			{
				rectangle.Y = x3133ad5e84f586ce.Top;
			}
		}
		x59dcf7372713ec60 = rectangle;
		x443b4b9ad47ce447 = rectangle2;
	}

	private static HorizontalAlignment x5b0c4d394d744e4b(System.Drawing.ContentAlignment x7717e14a55110734)
	{
		switch (x7717e14a55110734)
		{
		case System.Drawing.ContentAlignment.TopLeft:
		case System.Drawing.ContentAlignment.MiddleLeft:
		case System.Drawing.ContentAlignment.BottomLeft:
			return HorizontalAlignment.Left;
		case System.Drawing.ContentAlignment.TopCenter:
		case System.Drawing.ContentAlignment.MiddleCenter:
		case System.Drawing.ContentAlignment.BottomCenter:
			return HorizontalAlignment.Center;
		case System.Drawing.ContentAlignment.TopRight:
		case System.Drawing.ContentAlignment.MiddleRight:
		case System.Drawing.ContentAlignment.BottomRight:
			return HorizontalAlignment.Right;
		default:
			return HorizontalAlignment.Left;
		}
	}

	private static VerticalAlignment xf839f06c84dcab9b(System.Drawing.ContentAlignment x7717e14a55110734)
	{
		switch (x7717e14a55110734)
		{
		case System.Drawing.ContentAlignment.TopLeft:
		case System.Drawing.ContentAlignment.TopCenter:
		case System.Drawing.ContentAlignment.TopRight:
			return VerticalAlignment.Top;
		case System.Drawing.ContentAlignment.MiddleLeft:
		case System.Drawing.ContentAlignment.MiddleCenter:
		case System.Drawing.ContentAlignment.MiddleRight:
			return VerticalAlignment.Center;
		case System.Drawing.ContentAlignment.BottomLeft:
		case System.Drawing.ContentAlignment.BottomCenter:
		case System.Drawing.ContentAlignment.BottomRight:
			return VerticalAlignment.Bottom;
		default:
			return VerticalAlignment.Top;
		}
	}

	internal static Rectangle x5948ec9747755f2c(Rectangle x96fa000d4c9c0c90, Size xb35f79a43e184314, System.Drawing.ContentAlignment x7717e14a55110734)
	{
		int num = 0;
		int num2 = 0;
		switch (x7717e14a55110734)
		{
		case System.Drawing.ContentAlignment.TopLeft:
		case System.Drawing.ContentAlignment.MiddleLeft:
		case System.Drawing.ContentAlignment.BottomLeft:
			num = x96fa000d4c9c0c90.X;
			break;
		case System.Drawing.ContentAlignment.TopCenter:
		case System.Drawing.ContentAlignment.MiddleCenter:
		case System.Drawing.ContentAlignment.BottomCenter:
			num = Math.Max(x96fa000d4c9c0c90.X + (x96fa000d4c9c0c90.Width - xb35f79a43e184314.Width) / 2, x96fa000d4c9c0c90.Left);
			break;
		case System.Drawing.ContentAlignment.TopRight:
		case System.Drawing.ContentAlignment.MiddleRight:
		case System.Drawing.ContentAlignment.BottomRight:
			num = x96fa000d4c9c0c90.Right - xb35f79a43e184314.Width;
			break;
		}
		switch (x7717e14a55110734)
		{
		case System.Drawing.ContentAlignment.TopLeft:
		case System.Drawing.ContentAlignment.TopCenter:
		case System.Drawing.ContentAlignment.TopRight:
			num2 = x96fa000d4c9c0c90.Y;
			break;
		case System.Drawing.ContentAlignment.MiddleLeft:
		case System.Drawing.ContentAlignment.MiddleCenter:
		case System.Drawing.ContentAlignment.MiddleRight:
			num2 = x96fa000d4c9c0c90.Y + (x96fa000d4c9c0c90.Height - xb35f79a43e184314.Height) / 2;
			break;
		case System.Drawing.ContentAlignment.BottomLeft:
		case System.Drawing.ContentAlignment.BottomCenter:
		case System.Drawing.ContentAlignment.BottomRight:
			num2 = x96fa000d4c9c0c90.Bottom - xb35f79a43e184314.Height;
			break;
		}
		return new Rectangle(num, num2, Math.Min(xb35f79a43e184314.Width, x96fa000d4c9c0c90.Width), Math.Min(xb35f79a43e184314.Height, x96fa000d4c9c0c90.Height));
	}

	private void x18c7810149270b9e()
	{
		if (x3801fb00f092121c)
		{
			x3801fb00f092121c = false;
			return;
		}
		xffb3238a8fd59aa7 = PushButtonState.Pressed;
		if (x18ad87e3e5052114 != null)
		{
			x18ad87e3e5052114.Show(this, new Point(0, base.Height));
		}
		else if (xfcafee13fbdcb303 != null)
		{
			xfcafee13fbdcb303.Show(this, new Point(0, base.Height), ToolStripDropDownDirection.BelowRight);
		}
	}

	private void xc65c5c28d4f820e9(object xe0292b9ed559da7d, CancelEventArgs xfbf34718e704c6bc)
	{
		x83b528985b0490d3 = true;
	}

	private void x3ccfc8098244c64b(object xe0292b9ed559da7d, ToolStripDropDownClosingEventArgs xfbf34718e704c6bc)
	{
		x83b528985b0490d3 = false;
		x5379115e1ccee283();
		if (xfbf34718e704c6bc.CloseReason == ToolStripDropDownCloseReason.AppClicked)
		{
			x3801fb00f092121c = xa912c91339a9550a.Contains(PointToClient(Cursor.Position)) && Control.MouseButtons == MouseButtons.Left;
		}
	}

	private void x2e035f02b354c1ce(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		x83b528985b0490d3 = true;
	}

	protected override void WndProc(ref Message x6088325dec1baa2a)
	{
		if (x6088325dec1baa2a.Msg == 530)
		{
			x83b528985b0490d3 = false;
			x5379115e1ccee283();
		}
		base.WndProc(ref x6088325dec1baa2a);
	}

	private void x5379115e1ccee283()
	{
		if (base.Bounds.Contains(base.Parent.PointToClient(Cursor.Position)))
		{
			xffb3238a8fd59aa7 = PushButtonState.Hot;
		}
		else if (Focused)
		{
			xffb3238a8fd59aa7 = PushButtonState.Default;
		}
		else if (!base.Enabled)
		{
			xffb3238a8fd59aa7 = PushButtonState.Disabled;
		}
		else
		{
			xffb3238a8fd59aa7 = PushButtonState.Normal;
		}
	}
}
