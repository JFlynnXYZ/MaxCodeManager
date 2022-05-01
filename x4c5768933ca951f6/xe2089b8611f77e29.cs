using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;
//using x923c6864cde2ef13;

namespace x4c5768933ca951f6;

[Designer(typeof(xc4c808ec3af0da79))]
public class xe2089b8611f77e29 : UserControl
{
	public class xc4c808ec3af0da79 : ControlDesigner
	{
		private int _775cda6c5b232bce = -1;

		private SnapLinePriority _7ce00484d4264fed;

		public override IList SnapLines
		{
			get
			{
				IList snapLines = base.SnapLines;
				if (_775cda6c5b232bce >= 0)
				{
					snapLines.Add(new SnapLine(SnapLineType.Baseline, _775cda6c5b232bce, _7ce00484d4264fed));
				}
				return snapLines;
			}
		}

		public override SelectionRules SelectionRules
		{
			get
			{
				SelectionRules selectionRules = base.SelectionRules;
				return selectionRules & ~(SelectionRules.TopSizeable | SelectionRules.BottomSizeable);
			}
		}

		public override void Initialize(IComponent x7f976b7a7a87b378)
		{
			base.Initialize(x7f976b7a7a87b378);
			if (!(Control is xe2089b8611f77e29 xe2089b8611f77e30))
			{
				return;
			}
			IDesigner designer = TypeDescriptor.CreateDesigner(xe2089b8611f77e30.x5804db456f18ed26, typeof(IDesigner));
			if (designer == null)
			{
				return;
			}
			designer.Initialize(xe2089b8611f77e30.x5804db456f18ed26);
			using (designer)
			{
				if (!(designer is ControlDesigner controlDesigner))
				{
					return;
				}
				foreach (SnapLine snapLine in controlDesigner.SnapLines)
				{
					if (snapLine.SnapLineType == SnapLineType.Baseline)
					{
						_775cda6c5b232bce = snapLine.Offset + xe2089b8611f77e30.x5804db456f18ed26.Top;
						_7ce00484d4264fed = snapLine.Priority;
					}
				}
			}
		}
	}

	private bool _070f78755d5832a1 = true;

	private uint _d2f68ee6f47e9dfb;

	private int _dee620ebb0ba201e = 32;

	private bool _4d592be9e7ccefd3;

	private IContainer xb7dfc13308b54974;

	private RadioButton x5e19470767636f43;

	private RadioButton x5ed59fc8af150d0f;

	private TextBox x5804db456f18ed26;

	private ErrorProvider x831ff96ccf41d267;

	protected override Size DefaultSize => new Size(121, 28);

	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(true)]
	public bool x070f78755d5832a1
	{
		get
		{
			return _070f78755d5832a1;
		}
		set
		{
			if (value != _070f78755d5832a1)
			{
				_070f78755d5832a1 = value;
				_4d592be9e7ccefd3 = true;
				try
				{
					x5ed59fc8af150d0f.Checked = !value;
					x5e19470767636f43.Checked = value;
				}
				finally
				{
					_4d592be9e7ccefd3 = false;
				}
				x0e339771bdf1cb88();
			}
		}
	}

	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	public bool xff96b3c50e8ffc1f
	{
		get
		{
			return !x070f78755d5832a1;
		}
		set
		{
			x070f78755d5832a1 = !value;
		}
	}

	public uint xd2f68ee6f47e9dfb
	{
		get
		{
			return _d2f68ee6f47e9dfb;
		}
		set
		{
			if (value != _d2f68ee6f47e9dfb)
			{
				_d2f68ee6f47e9dfb = value;
				if (!_4d592be9e7ccefd3)
				{
					x0e339771bdf1cb88();
				}
				OnValueChanged(EventArgs.Empty);
			}
		}
	}

	[DefaultValue(32)]
	public int xdee620ebb0ba201e
	{
		get
		{
			return _dee620ebb0ba201e;
		}
		set
		{
			_dee620ebb0ba201e = Math.Max(1, Math.Min(value, 32));
		}
	}

	public bool x6fdb60dbbbb1352b => !string.IsNullOrEmpty(x831ff96ccf41d267.GetError(x5804db456f18ed26));

	public event EventHandler xaab33ba2241d262a;

	public xe2089b8611f77e29()
	{
		x85601834555fb7d5();
		x5e19470767636f43.Checked = true;
		xd2f68ee6f47e9dfb = 305419896u;
	}

	protected void x8739094aa0187d3b()
	{
		xd2f68ee6f47e9dfb = 305419896u;
	}

	protected bool x49c68ad70d24498e()
	{
		return xd2f68ee6f47e9dfb != 305419896;
	}

	protected virtual void OnValueChanged(EventArgs xfbf34718e704c6bc)
	{
		this.xaab33ba2241d262a?.Invoke(this, xfbf34718e704c6bc);
	}

	private void x0e339771bdf1cb88()
	{
		_4d592be9e7ccefd3 = true;
		try
		{
			x831ff96ccf41d267.SetError(x5804db456f18ed26, null);
			if (x070f78755d5832a1)
			{
				x5804db456f18ed26.Text = xd2f68ee6f47e9dfb.ToString("X" + (xdee620ebb0ba201e + 3) / 4);
				return;
			}
			uint num = xd2f68ee6f47e9dfb;
			if (xdee620ebb0ba201e < 32 && (num & (1 << xdee620ebb0ba201e - 1)) != 0)
			{
				num |= (uint)((int)((1L << 32 - xdee620ebb0ba201e) - 1) << xdee620ebb0ba201e);
			}
			TextBox textBox = x5804db456f18ed26;
			int num2 = (int)num;
			textBox.Text = num2.ToString();
		}
		finally
		{
			_4d592be9e7ccefd3 = false;
		}
	}

	private void xa8afddebe03dfe72(uint xed7e1b20b1a14b86)
	{
		_4d592be9e7ccefd3 = true;
		try
		{
			xd2f68ee6f47e9dfb = xed7e1b20b1a14b86;
		}
		finally
		{
			_4d592be9e7ccefd3 = false;
		}
	}

	private void xa8afddebe03dfe72(long xed7e1b20b1a14b86)
	{
		uint xed7e1b20b1a14b87 = (uint)(xed7e1b20b1a14b86 & ((1L << xdee620ebb0ba201e) - 1));
		xa8afddebe03dfe72(xed7e1b20b1a14b87);
	}

	private void x3f5c4f74938b8f1e(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (_4d592be9e7ccefd3)
		{
			return;
		}
		long result2;
		if (x070f78755d5832a1)
		{
			if (uint.TryParse(x5804db456f18ed26.Text, NumberStyles.HexNumber, null, out var result))
			{
				if (result < 1L << xdee620ebb0ba201e)
				{
					x831ff96ccf41d267.SetError(x5804db456f18ed26, null);
					xa8afddebe03dfe72(result);
				}
				else
				{
					x831ff96ccf41d267.SetError(x5804db456f18ed26, "Value must range from 0 to " + ((1L << xdee620ebb0ba201e) - 1).ToString("X"));
				}
			}
			else
			{
				x831ff96ccf41d267.SetError(x5804db456f18ed26, "Not a valid hex number.");
			}
		}
		else if (long.TryParse(x5804db456f18ed26.Text, out result2))
		{
			if (result2 >= -(1L << xdee620ebb0ba201e - 1) && result2 < 1L << xdee620ebb0ba201e)
			{
				x831ff96ccf41d267.SetError(x5804db456f18ed26, null);
				xa8afddebe03dfe72(result2);
				return;
			}
			x831ff96ccf41d267.SetError(x5804db456f18ed26, "Value must range from " + -(1L << xdee620ebb0ba201e - 1) + " to " + ((1L << xdee620ebb0ba201e) - 1));
		}
		else
		{
			x831ff96ccf41d267.SetError(x5804db456f18ed26, "Not a valid decimal number.");
		}
	}

	private void xf2da30dd2f8a9fe5(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (!_4d592be9e7ccefd3)
		{
			xff96b3c50e8ffc1f = true;
		}
	}

	private void x98a8059645ca791d(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (!_4d592be9e7ccefd3)
		{
			x070f78755d5832a1 = true;
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
		x5e19470767636f43 = new RadioButton();
		x5ed59fc8af150d0f = new RadioButton();
		x5804db456f18ed26 = new TextBox();
		x831ff96ccf41d267 = new ErrorProvider(xb7dfc13308b54974);
		((ISupportInitialize)x831ff96ccf41d267).BeginInit();
		SuspendLayout();
		x5e19470767636f43.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x5e19470767636f43.AutoSize = true;
		x5e19470767636f43.Location = new Point(80, 13);
		x5e19470767636f43.Name = "radioButtonHex";
		x5e19470767636f43.Size = new Size(44, 17);
		x5e19470767636f43.TabIndex = 4;
		x5e19470767636f43.TabStop = true;
		x5e19470767636f43.Text = "Hex";
		x5e19470767636f43.UseVisualStyleBackColor = true;
		x5e19470767636f43.CheckedChanged += x98a8059645ca791d;
		x5ed59fc8af150d0f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x5ed59fc8af150d0f.AutoSize = true;
		x5ed59fc8af150d0f.Location = new Point(80, -2);
		x5ed59fc8af150d0f.Name = "radioButtonDec";
		x5ed59fc8af150d0f.Size = new Size(45, 17);
		x5ed59fc8af150d0f.TabIndex = 5;
		x5ed59fc8af150d0f.TabStop = true;
		x5ed59fc8af150d0f.Text = "Dec";
		x5ed59fc8af150d0f.UseVisualStyleBackColor = true;
		x5ed59fc8af150d0f.CheckedChanged += xf2da30dd2f8a9fe5;
		x5804db456f18ed26.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		x5804db456f18ed26.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x831ff96ccf41d267.SetIconAlignment(x5804db456f18ed26, ErrorIconAlignment.MiddleLeft);
		x831ff96ccf41d267.SetIconPadding(x5804db456f18ed26, -16);
		x5804db456f18ed26.Location = new Point(0, 3);
		x5804db456f18ed26.Name = "textBoxValue";
		x5804db456f18ed26.Size = new Size(73, 22);
		x5804db456f18ed26.TabIndex = 3;
		x5804db456f18ed26.Text = "12345678";
		x5804db456f18ed26.TextAlign = HorizontalAlignment.Right;
		x5804db456f18ed26.TextChanged += x3f5c4f74938b8f1e;
		x831ff96ccf41d267.ContainerControl = this;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(x5e19470767636f43);
		base.Controls.Add(x5ed59fc8af150d0f);
		base.Controls.Add(x5804db456f18ed26);
		MinimumSize = new Size(121, 28);
		base.Name = "DecHexValueControl";
		base.Size = new Size(121, 28);
		((ISupportInitialize)x831ff96ccf41d267).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
