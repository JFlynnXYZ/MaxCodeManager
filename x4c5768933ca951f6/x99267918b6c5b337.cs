using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;
//using xab8bd308de7d379a;

namespace x4c5768933ca951f6;

[Designer(typeof(xc4c808ec3af0da79))]
public class x99267918b6c5b337 : UserControl
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
			if (!(Control is x99267918b6c5b337 x99267918b6c5b338))
			{
				return;
			}
			IDesigner designer = TypeDescriptor.CreateDesigner(x99267918b6c5b338.x5804db456f18ed26, typeof(IDesigner));
			if (designer == null)
			{
				return;
			}
			designer.Initialize(x99267918b6c5b338.x5804db456f18ed26);
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
						_775cda6c5b232bce = snapLine.Offset + x99267918b6c5b338.x5804db456f18ed26.Top;
						_7ce00484d4264fed = snapLine.Priority;
					}
				}
			}
		}
	}

	private IContainer xb7dfc13308b54974;

	private TextBox x5804db456f18ed26;

	private ErrorProvider x831ff96ccf41d267;

	private uint _d2f68ee6f47e9dfb;

	private int _dee620ebb0ba201e = 32;

	private bool _4d592be9e7ccefd3;

	protected override Size DefaultSize => new Size(73, 22);

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
		x5804db456f18ed26 = new TextBox();
		x831ff96ccf41d267 = new ErrorProvider(xb7dfc13308b54974);
		((ISupportInitialize)x831ff96ccf41d267).BeginInit();
		SuspendLayout();
		x5804db456f18ed26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		x5804db456f18ed26.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x831ff96ccf41d267.SetIconAlignment(x5804db456f18ed26, ErrorIconAlignment.MiddleLeft);
		x831ff96ccf41d267.SetIconPadding(x5804db456f18ed26, -16);
		x5804db456f18ed26.Location = new Point(0, 0);
		x5804db456f18ed26.Name = "textBoxValue";
		x5804db456f18ed26.Size = new Size(73, 22);
		x5804db456f18ed26.TabIndex = 4;
		x5804db456f18ed26.Text = "12345678";
		x5804db456f18ed26.TextAlign = HorizontalAlignment.Right;
		x5804db456f18ed26.TextChanged += x3f5c4f74938b8f1e;
		x831ff96ccf41d267.ContainerControl = this;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(x5804db456f18ed26);
		base.Name = "HexValueControl";
		base.Size = new Size(73, 22);
		((ISupportInitialize)x831ff96ccf41d267).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public x99267918b6c5b337()
	{
		x85601834555fb7d5();
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
			x5804db456f18ed26.Text = xd2f68ee6f47e9dfb.ToString("X" + (xdee620ebb0ba201e + 3) / 4);
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

	private void x3f5c4f74938b8f1e(object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
	{
		if (_4d592be9e7ccefd3)
		{
			return;
		}
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
}
